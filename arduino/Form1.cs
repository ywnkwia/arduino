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

namespace arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdatePorts_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Text = "";
            comboBoxPorts.Items.Clear();
            if (ports.Length != 0 )
            {
                comboBoxPorts.Items.AddRange(ports);
                comboBoxPorts.SelectedIndex = 0;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Подключиться")
            {
                try
                {
                    MySerialPort.PortName = comboBoxPorts.Text; //выбираем порт
                    MySerialPort.Open(); //открываем порт 
                    comboBoxPorts.Enabled = false;
                    
                    buttonConnect.Text = "Отключиться";
                }
                catch 
                {
                    MessageBox.Show("Ошибка подключения к порту");
                }
            }
            else if (buttonConnect.Text == "Отключиться")
            {
                MySerialPort.Close();
                buttonOnAll.Enabled = false;
               
                buttonConnect.Text = "Подключиться";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (buttonOnAll.Text == "Вкл.")
            {
                try
                {
                    MySerialPort.Write("9");
                    buttonOffProector.Text = "Выкл.";
                    buttonOnSvet.Text = "Выкл.";
                    buttonOnTrenaz.Text = "Выкл.";
                    buttonOnTumba.Text = "Выкл.";
                    buttonOnAll.Text = "Выкл.";
                    buttonOffProector.Enabled = false;
                    buttonOnSvet.Enabled = false;
                    buttonOnTrenaz.Enabled = false;
                    buttonOnTumba.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Ошибка работы устройства");
                }
            }
            else if (buttonOnAll.Text == "Выкл.")
            {
                MySerialPort.Write("10");
                buttonOffProector.Text = "Вкл.";
                buttonOnSvet.Text = "Вкл.";
                buttonOnTrenaz.Text = "Вкл.";
                buttonOnTumba.Text = "Вкл.";
                buttonOnAll.Text = "Вкл.";
                buttonOffProector.Enabled = true;
                buttonOnSvet.Enabled = true;
                buttonOnTrenaz.Enabled = true;
                buttonOnTumba.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonOnTumba.Text == "Вкл.")
            {
                try
                {
                    MySerialPort.Write("1");
                    buttonOnTumba.Text = "Выкл.";
                }
                catch
                {
                    MessageBox.Show("Ошибка работы устройства");
                }
            }
            else if (buttonOnTumba.Text == "Выкл.")
            {
                MySerialPort.Write("2");
                buttonOnTumba.Text = "Вкл.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonOnTrenaz_Click(object sender, EventArgs e)
        {
            if (buttonOnTrenaz.Text == "Вкл.")
            {
                try
                {
                    MySerialPort.Write("3");
                    buttonOnTrenaz.Text = "Выкл.";
                }
                catch
                {
                    MessageBox.Show("Ошибка работы устройства");
                }
            }
            else if (buttonOnTrenaz.Text == "Выкл.")
            {
                MySerialPort.Write("4");
                buttonOnTrenaz.Text = "Вкл.";
            }
        }

        private void buttonOnSvet_Click(object sender, EventArgs e)
        {
            if (buttonOnSvet.Text == "Вкл.")
            {
                try
                {
                    MySerialPort.Write("5");
                    buttonOnSvet.Text = "Выкл.";
                }
                catch
                {
                    MessageBox.Show("Ошибка работы устройства");
                }
            }
            else if (buttonOnSvet.Text == "Выкл.")
            {

                MySerialPort.Write("6");
                buttonOnSvet.Text = "Вкл.";
            }
        }

        private void buttonOffProector_Click(object sender, EventArgs e)
        {
            if (buttonOffProector.Text == "Вкл.")
            {
                try
                {
                    MySerialPort.Write("7");
                    buttonOffProector.Text = "Выкл.";
                }
                catch
                {
                    MessageBox.Show("Ошибка работы устройства");
                }
            }
            else if (buttonOffProector.Text == "Выкл.")
            {
                MySerialPort.Write("8");
                buttonOffProector.Text = "Вкл.";
            }
        }
    }
}
