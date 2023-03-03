using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EserciziWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form sta caricando...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\nicola.emmolo\\source\\repos\\EserciziWindowsFormsApp\\FileCSV.csv";

            
            if (tbx_cognome.Text == "" ||
                tbx_nome.Text == "" ||
                tbx_consumo.Text == "" ||
                tbx_unitamisura.Text == "" ||
                tbx_data.Text == "")
            {
                MessageBox.Show("Devi inserire tutti i dati");
            }
            else
            {
                try
                {
                    string cognome = tbx_cognome.Text;
                    string nome = tbx_nome.Text;
                    double consumo = double.Parse(tbx_consumo.Text);
                    string unitamisura = tbx_unitamisura.Text;
                    DateTime data = DateTime.Parse(tbx_data.Text);

                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine($"{cognome};{nome};{consumo};{unitamisura};{data}");
                    }
                    MessageBox.Show("Dati inseriti");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            tbx_cognome.Clear();
            tbx_nome.Clear();
            tbx_consumo.Clear();
            tbx_unitamisura.Clear();
            tbx_data.Clear();
        }
    }
}
