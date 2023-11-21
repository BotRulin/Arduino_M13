using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sprint2_Arduino
{
    public partial class frmBalises : Form
    {
        SerialPort serialPort;

        public frmBalises()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;

            string[] ports = SerialPort.GetPortNames();

            lvDades.View = View.Details;
            lvDades.Columns.Add("Times");
            lvDades.Columns.Add("Values");

            if (ports.Length > 0)
            {
                cmbPorts.Items.AddRange(ports);
            }
            else
            {
                cmbPorts.Items.Add("No hay puertos disponibles");
                cmbPorts.Enabled = false;
                btnConnect.Enabled = false;
            }
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            string selectedPort = cmbPorts.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedPort))
            {
                serialPort.PortName = selectedPort;
                try
                {
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el puerto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un puerto COM válido.");
            }
        }

        private void ReceiveData(object num)
        { 
            try
            {
                
                int i = (int)num;
                while ((int.Parse(txtGrupsCicle.Text) + 1) != i)
                {
                    string response = serialPort.ReadLine();
                    string[] row = { i.ToString(), response };
                    ListViewItem item = new ListViewItem(row);
                    lvDades.Items.Add(item);
                    i++;
                    if (int.TryParse(response, out int dataValue))
                    {
                        chartDades.Series["Datos"].Points.AddXY(i - 1, dataValue);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recibir datos: " + ex.Message);
            }
        }

        private void textBox_OnlyNumbersAccept(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SerialReceive(int i)
        {
            Thread filEscolta = new Thread(ReceiveData);
            filEscolta.Start(i);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                chartDades.Series.Clear();
                Series series = chartDades.Series.Add("Datos");
                series.ChartType = SeriesChartType.Line;
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                int i = 1;
                int cicles = int.Parse(txtGrupsCicle.Text);
                int divisor = int.Parse(txtDivisor.Text);
                serialPort.Write(cicles.ToString() + "#" + divisor.ToString() + "\n");                
                SerialReceive(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
