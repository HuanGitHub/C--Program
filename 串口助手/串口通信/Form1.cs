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


namespace 串口通信
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sp.DataReceived += new SerialDataReceivedEventHandler(GetData_Click);
        }
        SerialPort sp = new SerialPort();
        int flag=0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort sp = new SerialPort();
            string[] name = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(name);
            comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
      
        private void OpenPort_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                if (sp.PortName != comboBox1.Text)
                {
                    sp.PortName = comboBox1.Text;
                }
                sp.BaudRate = 9600;
                try
                {
                    sp.Open();
                }
                catch (Exception ex)
                {
                    sp = new SerialPort();
                    MessageBox.Show(ex.Message);
                }

                if (sp.IsOpen)
                {
                    textBox3.Text = "串口已打开";
                    
                }
                else
                {
                    textBox3.Text = "串口已关闭";
                    flag = 0;
                }
            }
        }
        private void ClosePort_Click(object sender, EventArgs e)
        {
            sp.Close();
            if (sp.IsOpen)
            {
                textBox3.Text = "串口已打开";
            }
            else
            {
                textBox3.Text = "串口已关闭";
            }
        }

        private void SendData_Click(object sender, EventArgs e)
        {
           
            string a = textBox1.Text;
            textBox1.Text = null;
            byte[] b = new byte[1];
            b[0] = Convert.ToByte(a, 16); ;
            sp.Write(b, 0, 1);


        }
        
        private void GetData_Click(object sender, EventArgs e)
        {
            int n = sp.BytesToRead;
            
            byte[] buf = new byte[n];
            sp.Read(buf,0,n);
            int x=sp.ReadByte();

            string st = buf[0].ToString();
            textBox5.Text += x.ToString()+" ";

        }
      
    }
}
