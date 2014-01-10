using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;
namespace SERIALDUBUG
{
    public partial class Form1 : Form
    {
        bool flag = true;

        delegate void UpdateTextEventHandler(string text);  //委托，此为重点
        UpdateTextEventHandler updateText;


        public Form1()
        {
            //  Encoding gb = Encoding.GetEncoding("gb2312");  

            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            if (ports == null)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;
            }
            this.comBoxSerial.Items.Clear();
            foreach (string port in ports)
            {
                this.comBoxSerial.Items.Add(port);
            }
            comBoxSerial.SelectedIndex = 3;
            comboBoxBuad.SelectedIndex = 4;
            comboBoxDatabits.SelectedIndex = 3;
            comBoxCheckbits.SelectedIndex = 0;
            comboBoxStopbits.SelectedIndex = 0;
            updateText = new UpdateTextEventHandler(UpdateTextBox);
           
        //利用ZedGraph创建绘图窗体


           GraphPane  myPane = zedGraphControl1.GraphPane;
            zedGraphControl1.MasterPane.Title.Text = "测试实例";

            zedGraphControl1.GraphPane.Title.Text = "我的第一个实例";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "数值大小";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "时间";
            double x, y1, y2;
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            for (int i = 0; i < 36; i++)
            {
                x = (double)i + 5;
                y1 = 1.5 + Math.Sin((double)i * 0.2);
                y2 = 3.0 * (1.5 + Math.Sin((double)i * 0.2));
                list1.Add(x, y1);
                list2.Add(x, y2);
            }

            // 创建红色的菱形曲线
            // 标记, 图中的 "Porsche" 
            LineItem myCurve = myPane.AddCurve("Porsche", list1, Color.Red, SymbolType.Diamond);

            // 创建蓝色的圆形曲线
            // 标记, 图中的 "Piper"    
            LineItem myCurve2 = zedGraphControl1.GraphPane.AddCurve("Piper", list2, Color.Blue, SymbolType.Circle);

            // 在数据变化时绘制图形
            zedGraphControl1.GraphPane.AxisChange(this.CreateGraphics());



            //加载地图
            try
            {
                System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com.hk");
            }
            catch
            {
                mapControl.Manager.Mode = AccessMode.CacheOnly;
                //MessageBox.Show("No internet connection avaible, going to CacheOnly mode.", "GMap.NET Demo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            mapControl.MapProvider = GMapProviders.GoogleChinaMap; //google china 地图
            mapControl.MinZoom = 2;  //最小缩放
            mapControl.MaxZoom = 17; //最大缩放
            mapControl.Zoom = 5;     //当前缩放
            //mapControl.ShowCenter = false; //不显示中心十字点
            //mapControl.DragButton = MouseButton.Left; //左键拖拽地图
            mapControl.Position = new PointLatLng(32.064, 118.704); //地图中心位置：南京

            //mapControl.OnMapZoomChanged += new MapZoomChanged(mapControl_OnMapZoomChanged);
            //mapControl.MouseLeftButtonDown += new MouseButtonEventHandler(mapControl_MouseLeftButtonDown);


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            serialPort1.Encoding = System.Text.Encoding.GetEncoding("GB2312");
            try
            {
                if (Init.Text == "打开")
                {
                    try
                    {
                        if (comBoxSerial.Text != null)
                        {
                            serialPort1.PortName = comBoxSerial.Text;


                        }


                        else
                            Console.WriteLine("请选择串口");


                    }
                    catch (System.ArgumentException)
                    {
                        Console.WriteLine("串口选择失败");
                    }


                    switch (comboBoxStopbits.Text)
                    {
                        case "0":
                            serialPort1.StopBits = StopBits.None;
                            break;

                        case "1":
                            serialPort1.StopBits = StopBits.One;
                            break;

                        case "1.5":
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            serialPort1.StopBits = StopBits.One;
                            break;

                    }
                    try
                    {

                        {
                            serialPort1.BaudRate = Convert.ToInt32(comboBoxBuad.Text);
                        }

                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("请选择对应的波特率");

                    }
                    catch (ArgumentNullException)
                    {
                        serialPort1.BaudRate = 115200;
                    }

                    switch (comBoxCheckbits.Text)
                    {
                        case null:
                            Console.WriteLine("请选择校验位");
                            break;
                        case "Even":
                            serialPort1.Parity = Parity.Even;
                            break;

                        case "None":
                            serialPort1.Parity = Parity.None;
                            break;

                        case "Odd":
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case "Mark":
                            serialPort1.Parity = Parity.Mark;
                            break;
                        case "Space":
                            serialPort1.Parity = Parity.Space;
                            break;

                        default:
                            serialPort1.Parity = Parity.None;
                            break;
                    }
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                        Init.Text = "关闭";
                    }
                }
                else
                {
                    while (!flag)
                        Application.DoEvents();

                    serialPort1.Close();
                    Init.Text = "打开";

                }
            }

            catch (System.Exception ex)
            {
                Console.WriteLine("无法打开");
            }



        }




        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            flag = false;
            if (serialPort1.IsOpen)
            {
                string readString = serialPort1.ReadExisting();
                this.Invoke(updateText, new string[] { readString });

            }
            flag = true;
        }
        private void UpdateTextBox(string text)
        {

            richTextBox2.AppendText(text);
            if (richTextBox2.TextLength >= 100000)
            {
                richTextBox2.Text = "";
            }
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comBoxSerial_SelectedIndexChanged(object sender, EventArgs e)
        {   if (serialPort1.IsOpen)
               {
            while (!flag)
                   Application.DoEvents();
            serialPort1.Close();
            
            string port = serialPort1.PortName;

            if (serialPort1.PortName == comBoxSerial.Text)
            {

            }
            else
            {
                try
                {
                    serialPort1.PortName = comBoxSerial.Text;
                    serialPort1.Open();



                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("此串口正在占用");
                   
                        comBoxSerial.SelectedIndex = 0;
                        serialPort1.PortName = comBoxSerial.Text;
                    
                }
            }
        }
           
            

            
           
        }
     
        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            double x, y1, y2;
        //    PointPairList list1 = new PointPairList();
        //    PointPairList list2 = new PointPairList();
        //    for (int i = 0; i < 36; i++)
        //    {
        //        x = (double)i + 5;
        //        y1 = 1.5 + Math.Sin((double)i * 0.2);
        //        y2 = 3.0 * (1.5 + Math.Sin((double)i * 0.2));
        //        list1.Add(x, y1);
        //        list2.Add(x, y2);
        //    }
        //    LineItem myCurve = zedGraphControl1.GraphPane.AddCurve("Porsche",
        //list1, Color.Red, SymbolType.Diamond);

        //    // Generate a blue curve with circle
        //    // symbols, and "Piper" in the legend
        //    LineItem myCurve2 = zedGraphControl1.GraphPane.AddCurve("Piper",
        //          list2, Color.Blue, SymbolType.Circle);

        //    // Tell ZedGraph to refigure the
        //    // axes since the data have changed
           zedGraphControl1.AxisChange();
        }

       

        private void 曲线显示_Click(object sender, EventArgs e)
        {

            //  CreateGraph(zedGraphControl1);
            zedGraphControl1.MasterPane.Title.Text = "测试实例";

            zedGraphControl1.GraphPane.Title.Text = "我的第一个实例";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "数值大小";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "时间";
            double x, y1, y2;
        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            //Point clickPoint = e.GetPosition(mapControl);
            //PointLatLng point = mapControl.FromLocalToLatLng((int)clickPoint.X, (int)clickPoint.Y);
            //GMapMarker marker = new GMapMarker(point);
            //mapControl.Markers.Add(marker);

        }


        //private void CreateGraph(ZedGraphControl zgc)
        //{
        //    // get a reference to the GraphPane
        //    GraphPane myPane = zgc.GraphPane;

        //    // Set the Titles
        //    myPane.Title.Text = "My Test Graph\n(For CodeProject Sample)";
        //    myPane.XAxis.Title.Text = "My X Axis";
        //    myPane.YAxis.Title.Text = "My Y Axis";

        //    // Make up some data arrays based on the Sine function
        //    double x, y1, y2;
        //    PointPairList list1 = new PointPairList();
        //    PointPairList list2 = new PointPairList();
        //    for (int i = 0; i < 36; i++)
        //    {
        //        x = (double)i + 5;
        //        y1 = 1.5 + Math.Sin((double)i * 0.2);
        //        y2 = 3.0 * (1.5 + Math.Sin((double)i * 0.2));
        //        list1.Add(x, y1);
        //        list2.Add(x, y2);
        ////    }

        //    // Generate a red curve with diamond
        //    // symbols, and "Porsche" in the legend
        //    LineItem myCurve = myPane.AddCurve("Porsche",
        //          list1, Color.Red, SymbolType.Diamond);

        //    // Generate a blue curve with circle
        //    // symbols, and "Piper" in the legend
        //    LineItem myCurve2 = myPane.AddCurve("Piper",
        //          list2, Color.Blue, SymbolType.Circle);

        //    // Tell ZedGraph to refigure the
        //    // axes since the data have changed
        //    //zgc.AxisChange();
        ////}





    }
}

           
       
       
  


