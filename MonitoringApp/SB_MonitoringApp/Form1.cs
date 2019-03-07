using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace SB_MonitoringApp
{
    public partial class mainForm : Form
    {
        IPEndPoint ipep;
        private Thread thr;
        Socket client;
        private Queue<double> q1 = new Queue<double>();
        private Queue<double> q2 = new Queue<double>();
        private Queue<double> q3 = new Queue<double>();
        private Queue<double> q4 = new Queue<double>();
        private Queue<double> q5 = new Queue<double>();
        private Queue<double> q6 = new Queue<double>();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public mainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            StatusList.Text += "Exitting..." + Environment.NewLine;
            this.Close();
        }

        private void Databoard_Click(object sender, EventArgs e)
        {
            databoardPanel.Visible = true;
            connectPanel.Visible = false;
            classificationPanel.Visible = false;
            TabTitle.Text = "Databoard";
        }

        private void Connection_Click(object sender, EventArgs e)
        {
            databoardPanel.Visible = false;
            connectPanel.Visible = true;
            classificationPanel.Visible = false;
            TabTitle.Text = "Connection";
        }

        private void Classification_Click(object sender, EventArgs e)
        {
            databoardPanel.Visible = false;
            connectPanel.Visible = false;
            classificationPanel.Visible = true;
            TabTitle.Text = "Classification";
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (IPTextBox.Text == "" || portTextBox.Text == "")
            {
                StatusList.Text += "IP or PORT error occured" + Environment.NewLine;
                return;
            }
            try
            {
                ipep = new IPEndPoint(IPAddress.Parse(IPTextBox.Text), int.Parse(portTextBox.Text));
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(ipep);
                ChangeConnectLabel(1);
                for (int i = 0; i < 30; i++)
                {
                    q1.Enqueue(0);
                    q2.Enqueue(0);
                    q3.Enqueue(0);
                    q4.Enqueue(0);
                    q5.Enqueue(0);
                    q6.Enqueue(0);
                }

                thr = new Thread(new ThreadStart(this.getPerformance));
                thr.IsBackground = true;
                thr.Start();
                StatusList.Text += "Connected" + Environment.NewLine;

            }
            catch (SocketException exc)
            {
                StatusList.Text += exc.ToString() + Environment.NewLine;
            }
            /*catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception : {0}", ex.ToString());
            }*/
        }

        private void ChangeConnectLabel(int ConnextState)//0 : 연결안됨 ::::::: 1 : 연결됨
        {
            if (ConnextState == 0)
            {
                status.ForeColor = Color.Red;
                status.Text = "Disconnected";
            }
            if (ConnextState == 1)
            {
                status.ForeColor = Color.Green;
                status.Text = "Connected";
            }
        }

        private void getPerformance()
        {
            while (true)
            {
                try
                {
                    Byte[] _byte = new Byte[1024];
                    client.Receive(_byte);
                    String incodeByte = Encoding.Default.GetString(_byte);
                    client.Send(_byte);
                    JObject obj = JObject.Parse(incodeByte);
                    this.Invoke((MethodInvoker)delegate
                    {
                        UpdateChart(obj["ax"].ToString(), obj["ay"].ToString(), obj["az"].ToString(), obj["gx"].ToString(), obj["gy"].ToString(), obj["gz"].ToString());
                        UpdateClassification(obj["target"].ToString(), obj["score"].ToString());
                        StatusList.Text += obj["ax"].ToString() + obj["ay"].ToString() + obj["az"].ToString() + obj["gx"].ToString() + obj["gy"].ToString() + obj["gz"].ToString() + Environment.NewLine;
                        StatusList.Text += obj["target"].ToString() + obj["score"].ToString() + Environment.NewLine;
                    });
                }
                catch (SocketException exc)
                {
                    StatusList.Text += exc.ToString() + Environment.NewLine;
                }
            }
        }
        private void UpdateChart(String ax, String ay, String az, String gx, String gy, String gz)
        {
            chart.Series["gx"].Points.Clear();
            chart.Series["gy"].Points.Clear();
            chart.Series["gz"].Points.Clear();
            chart.Series["ax"].Points.Clear();
            chart.Series["ay"].Points.Clear();
            chart.Series["az"].Points.Clear();

            q1.Enqueue(double.Parse(ax));
            q1.Dequeue();
            q2.Enqueue(double.Parse(ay));
            q2.Dequeue();
            q3.Enqueue(double.Parse(az));
            q3.Dequeue();
            q4.Enqueue(double.Parse(gx));
            q4.Dequeue();
            q5.Enqueue(double.Parse(gy));
            q5.Dequeue();
            q6.Enqueue(double.Parse(gz));
            q6.Dequeue();

            double[] axList1 = new double[q1.Count];
            q1.CopyTo(axList1, 0);
            double[] axList2 = new double[q2.Count];
            q2.CopyTo(axList2, 0);
            double[] axList3 = new double[q3.Count];
            q3.CopyTo(axList3, 0);
            double[] axList4 = new double[q4.Count];
            q4.CopyTo(axList4, 0);
            double[] axList5 = new double[q5.Count];
            q5.CopyTo(axList5, 0);
            double[] axList6 = new double[q6.Count];
            q6.CopyTo(axList6, 0);

            for (int i = 0; i < 30; i++)
            {
                chart.Series["gx"].Points.AddY(axList1[i]);
                chart.Series["gy"].Points.AddY(axList2[i]);
                chart.Series["gz"].Points.AddY(axList3[i]);
                chart.Series["ax"].Points.AddY(axList4[i]);
                chart.Series["ay"].Points.AddY(axList5[i]);
                chart.Series["az"].Points.AddY(axList6[i]);
            }
        }

        private void UpdateClassification(string target, string score)
        {
            Target.Text = target;
            PredictionScore.Text = score;
            
            switch (Int32.Parse(target))
            {
                case 0:
                    StandingIcon.Visible = true;
                    WalkingIcon.Visible = false;
                    RunningIcon.Visible = false;
                    UpstairIcon.Visible = false;
                    DownstairIcon.Visible = false;
                    break;
                case 1:
                    StandingIcon.Visible = false;
                    WalkingIcon.Visible = true;
                    RunningIcon.Visible = false;
                    UpstairIcon.Visible = false;
                    DownstairIcon.Visible = false;
                    break;
                case 2:
                    StandingIcon.Visible = false;
                    WalkingIcon.Visible = false;
                    RunningIcon.Visible = true;
                    UpstairIcon.Visible = false;
                    DownstairIcon.Visible = false;
                    break;
                case 3:
                    StandingIcon.Visible = false;
                    WalkingIcon.Visible = false;
                    RunningIcon.Visible = false;
                    UpstairIcon.Visible = true;
                    DownstairIcon.Visible = false;
                    break;
                case 4:
                    StandingIcon.Visible = false;
                    WalkingIcon.Visible = false;
                    RunningIcon.Visible = false;
                    UpstairIcon.Visible = false;
                    DownstairIcon.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void connectPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;           
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
