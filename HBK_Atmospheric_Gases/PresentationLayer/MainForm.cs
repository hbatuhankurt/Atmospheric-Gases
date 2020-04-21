using System;
using System.IO.Ports;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using BusinessLayer.Models;
using PresentationLayer.ServiceReference1;
using MessageBox = System.Windows.MessageBox;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private SerialPort serialPort;
        public MainForm()
        {
            serialPort = new SerialPort("COM6");
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Handshake = Handshake.None;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.ReadTimeout = -1;
            serialPort.WriteTimeout = -1;
            //serialPort.Open();
            InitializeComponent();

            if (serialPort.IsOpen == true)
            {
                lbl_connection.Text = "Connected";
                timer1.Start();
                timer2.Start();
            }
            else
            {
                lbl_connection.Text = "Not Connected";
            }           
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm();
            form.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                serialPort.DiscardInBuffer(); //bir önceden kalan verileri siliyor ve temiz veri sağlanıyor.
                serialPort.Close();               
                lbl_connection.Text = "Disconnected";
            }
        }

        public string[] data2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string data = serialPort.ReadLine().Replace("\r","");
            data2 = data.Split('*');
            txt_data2.Text = data;
            switch (data2.Length)
            {
                case 1:
                    txt_hum.Text = data2[0];
                    break;
                case 2:
                    txt_hum.Text = data2[0];
                    txt_temp.Text = data2[1];
                    break;
                case 3:
                    txt_hum.Text = data2[0];
                    txt_temp.Text = data2[1];
                    txt_co.Text = data2[2];
                    break;
                case 4:
                    txt_hum.Text = data2[0];
                    txt_temp.Text = data2[1];
                    txt_co.Text = data2[2];
                    txt_smoke.Text = data2[3];
                    break;
                case 5:
                    txt_hum.Text = data2[0];
                    txt_temp.Text = data2[1];
                    txt_co.Text = data2[2];
                    txt_smoke.Text = data2[3];
                    txt_air.Text = data2[4];
                    break;
            }

            //Nem - Humidity
            sgHumidity.Uses360Mode = true;
            sgHumidity.From = 0;
            sgHumidity.To = 100;
            if (!txt_hum.Text.Equals(""))
            {
                sgHumidity.Value = Convert.ToDouble(txt_hum.Text);
            }
            sgHumidity.Base.LabelsVisibility = Visibility.Hidden;
            sgHumidity.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                    {
                        new GradientStop(Colors.Yellow, 0.45),
                        new GradientStop(Colors.Orange, 0.70),
                        new GradientStop(Colors.Red, .1)
                    }
            };

            //Sıcaklık - Temperature
            sgTemperature.Uses360Mode = true;
            sgTemperature.From = 0;
            sgTemperature.To = 100;
            if (!txt_temp.Text.Equals(""))
            {
                sgTemperature.Value = Convert.ToDouble(txt_temp.Text);
            }
            sgTemperature.Base.LabelsVisibility = Visibility.Hidden;
            sgTemperature.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Yellow, 0.45),
                    new GradientStop(Colors.Orange, 0.70),
                    new GradientStop(Colors.Red, 1)
                }
            };

            //Karbonmonoksit - CarbonMonoxide
            sgCarbonMonoxide.Uses360Mode = true;
            sgCarbonMonoxide.From = 0;
            sgCarbonMonoxide.To = 100;
            if (!txt_co.Text.Equals(""))
            {
                sgCarbonMonoxide.Value = Convert.ToDouble(txt_co.Text);
            }
            sgCarbonMonoxide.Base.LabelsVisibility = Visibility.Hidden;
            sgCarbonMonoxide.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Yellow, 0.45),
                    new GradientStop(Colors.Orange, 0.70),
                    new GradientStop(Colors.Red, 1)
                }
            };

            //Duman - Smoke
            sgSmoke.Uses360Mode = true;
            sgSmoke.From = 0;
            sgSmoke.To = 1000;
            if (!txt_smoke.Text.Equals(""))
            {
                sgSmoke.Value = Convert.ToDouble(txt_smoke.Text);
            }
            sgSmoke.Base.LabelsVisibility = Visibility.Hidden;
            sgSmoke.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Yellow, 0.45),
                    new GradientStop(Colors.Orange, 0.70),
                    new GradientStop(Colors.Red, 1)
                }
            };

            //Hava Kalitesi - Air Quality
            sgAir.Uses360Mode = true;
            sgAir.From = 0;
            sgAir.To = 1000;
            if (!txt_air.Text.Equals(""))
            {
                sgAir.Value = Convert.ToDouble(txt_air.Text);
            }
            sgAir.Base.LabelsVisibility = Visibility.Hidden;
            sgAir.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Yellow, 0.45),
                    new GradientStop(Colors.Orange, 0.70),
                    new GradientStop(Colors.Red, 1)
                }
            };
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DataServiceClient service = new DataServiceClient();

            MDataPublish dataPublish1 = new MDataPublish();
            dataPublish1.SensorId = 1;
            dataPublish1.DataId = 1;
            dataPublish1.DataValue = txt_hum.Text;
            dataPublish1.PublishDateTime = DateTime.Now;

            if (service.InsertSensorData(dataPublish1) == true)
            {
                Console.WriteLine("Kayıt Edildi");
            }
            else
            {
                Console.WriteLine("Hata Oluştu");
            }
            Thread.Sleep(500);

            MDataPublish dataPublish2 = new MDataPublish();
            dataPublish2.SensorId = 1;
            dataPublish2.DataId = 2;
            dataPublish2.DataValue = txt_temp.Text;
            dataPublish2.PublishDateTime = DateTime.Now;
            if (service.InsertSensorData(dataPublish2) == true)
            {
                Console.WriteLine("Kayıt Edildi");
            }
            else
            {
                Console.WriteLine("Hata Oluştu");
            }
            Thread.Sleep(500);

            MDataPublish dataPublish3 = new MDataPublish();
            dataPublish3.SensorId = 2;
            dataPublish3.DataId = 3;
            dataPublish3.DataValue = txt_co.Text;
            dataPublish3.PublishDateTime = DateTime.Now;
            if (service.InsertSensorData(dataPublish3) == true)
            {
                Console.WriteLine("Kayıt Edildi");
            }
            else
            {
                Console.WriteLine("Hata Oluştu");
            }
            Thread.Sleep(500);

            MDataPublish dataPublish4 = new MDataPublish();
            dataPublish4.SensorId = 3;
            dataPublish4.DataId = 4;
            dataPublish4.DataValue = txt_smoke.Text;
            dataPublish4.PublishDateTime = DateTime.Now;
            if (service.InsertSensorData(dataPublish4) == true)
            {
                Console.WriteLine("Kayıt Edildi");
            }
            else
            {
                Console.WriteLine("Hata Oluştu");
            }
            Thread.Sleep(500);

            MDataPublish dataPublish5 = new MDataPublish();
            dataPublish5.SensorId = 4;
            dataPublish5.DataId = 5;
            dataPublish5.DataValue = txt_air.Text;
            dataPublish5.PublishDateTime = DateTime.Now;
            if (service.InsertSensorData(dataPublish5) == true)
            {
                Console.WriteLine("Kayıt Edildi");
            }
            else
            {
                Console.WriteLine("Hata Oluştu");
            }
            Thread.Sleep(500);
        }
    }
}
