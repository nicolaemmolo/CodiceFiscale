using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodiceFiscaleWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var el in GetComuni())
            {
                cbx_comuneNascita.Items.Add(el.Nome);
            }
        }

        private void btn_generaCF_Click(object sender, EventArgs e)
        {
            if (!ControlliCorretti())
            {
                MessageBox.Show("Dati inseriti non corretti");
                return;
            }

            var nome = tbx_nome.Text;

            var cognome = tbx_cognome.Text;

            var sesso = string.Empty;
            if (rbn_maschio.Checked) { sesso = rbn_maschio.Text; }
            else { sesso =  }
        }

        public List<Comune> GetComuni()
        {
            List<Comune> list = new List<Comune>();

            using (StreamReader sr = new StreamReader("C:\\Users\\nicola.emmolo\\source\\repos\\EserciziWindowsFormsApp\\CodiceFiscaleWindowsFormsApp\\ElencoComuni.csv"))
            {
                while (!sr.EndOfStream)
                {
                    var arr = (sr.ReadLine()).Split(',');
                    list.Add(new Comune(arr[0], arr[1]));
                }
            }
            return list;
        }

        public bool ControlliCorretti()
        {
            if (tbx_nome.Text == "" || tbx_cognome.Text == "") { return false; }
            else if (!rbn_maschio.Checked && !rbn_femmina.Checked) { return false; }
            else if (dtp_dataNascita.Checked || dtp_dataNascita.Value > DateTime.Now) { return false; }
            else if (!GetComuni().Any(x => x.Nome == cbx_comuneNascita.Text)) { return false; }
            else { return true; }
        }
    }

    public class Comune
    {
        public string Nome { get; set; }
        public string Codice { get; set; }

        public Comune(string nome, string codice)
        {
            Nome = nome;
            Codice = codice;
        }
    }
}
