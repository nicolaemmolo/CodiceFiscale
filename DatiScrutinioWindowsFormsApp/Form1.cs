/* 13) DATI SCRUTINIO
 * Gestione form per analisi dati scrutinio che permetta di:
 *  - Inserire i voti per studente e per materia
 *  - Scelto uno studente, calcolare la media dei voti
 *  - Scelto uno studente, mostrrate i voti (materia-voto)
 *  - Scelto uno studente, mostri il voto più alto e in che materia
 *  - Scelto uno studente, dica se lo studente è stato:
 *      . promosso = 0 insufficenze
 *      . bocciato = insufficenze > 3
 *      . rimandato = altri casi
 */

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

namespace DatiScrutinioWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScrutinioDB.Studenti.Add("Mario Rossi");
            ScrutinioDB.Studenti.Add("Giacomo Verdi");
            ScrutinioDB.Studenti.Add("Carla Gialli");
            ScrutinioDB.Studenti.Add("Michele Neri");

            ScrutinioDB.Materie.Add("Italiano");
            ScrutinioDB.Materie.Add("Storia");
            ScrutinioDB.Materie.Add("Geografia");
            ScrutinioDB.Materie.Add("Matematica");
            ScrutinioDB.Materie.Add("Inglese");

            cbx_studenti1.Items.AddRange(ScrutinioDB.Studenti.ToArray());
            cbx_studenti2.Items.AddRange(ScrutinioDB.Studenti.ToArray());
            cbx_materie.Items.AddRange(ScrutinioDB.Materie.ToArray());
        }

        private void btn_addVoto_Click(object sender, EventArgs e)
        {
            float voto = 0;

            if (!float.TryParse(tbx_voto.Text, out voto))
            {
                MessageBox.Show("Devi inserire il voto");
            }
            else if (voto < 2 || voto > 10)
            {
                MessageBox.Show("Il voto deve essere compreso tra 2 e 10");
            }
            else if (cbx_studenti1.Text == "" || cbx_materie.Text == "")
            {
                MessageBox.Show("Devi inserire sutente e materia");
            }
            else if(!ScrutinioDB.Studenti.Any(x => x == cbx_studenti1.Text))
            {
                MessageBox.Show("Studente non presente");
            }
            else if(!ScrutinioDB.Materie.Any(x => x == cbx_materie.Text))
            {
                MessageBox.Show("Materia non presente");
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(ScrutinioDB.path, true))
                {
                    sw.WriteLine($"{cbx_studenti1.Text};{cbx_materie.Text};{voto}");
                }
                MessageBox.Show("Voto Aggiunto");

                tbx_voto.Clear();
                cbx_studenti1.ResetText();
                cbx_materie.ResetText();
            }
        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            if (!ScrutinioDB.Studenti.Any(x => x == cbx_studenti2.Text))
            {
                MessageBox.Show("Studente non presente");
            }
            else
            {
                using (StreamReader sr = new StreamReader(ScrutinioDB.path))
                {
                    while (!sr.EndOfStream)
                    {
                        var arr = (sr.ReadLine()).Split(';');
                        ScrutinioDB.Scrutini.Add(new Scrutinio(arr[0], arr[1], arr[2]));
                    }
                }

                ScrutinioDB.StudenteSelezionato = cbx_studenti2.Text;

                MessageBox.Show("Studente confermato");
            }
        }

        private void btn_avg_Click(object sender, EventArgs e)
        {
            var l = ScrutinioDB.Scrutini.FindAll(x => x.Nome == ScrutinioDB.StudenteSelezionato);

            float media = 0;

            foreach(var el in l)
            {
                media += float.Parse(el.Voto);
            }
            media /= l.Count();

            lbl_avg.Text = "Media: " + media.ToString();
        }

        private void btn_mostraVoti_Click(object sender, EventArgs e)
        {
            var l = ScrutinioDB.Scrutini.FindAll(x => x.Nome == ScrutinioDB.StudenteSelezionato);

            lbx_voti.Items.Clear();

            foreach (var el in l)
            {
                lbx_voti.Items.Add($"{el.Materia}-{el.Voto}");
            }
        }

        private void btn_maxVoto_Click(object sender, EventArgs e)
        {
            var l = ScrutinioDB.Scrutini.FindAll(x => x.Nome == ScrutinioDB.StudenteSelezionato);

            float maxVoto = 0;
            foreach (var el in l)
            {
                if(float.Parse(el.Voto) > maxVoto)
                {
                    maxVoto = float.Parse(el.Voto);
                }
            }

            lbl_maxVoto.Text = "Voto: " + maxVoto.ToString();
        }

        private void btn_checkPromosso_Click(object sender, EventArgs e)
        {
            var l = ScrutinioDB.Scrutini.FindAll(x => x.Nome == ScrutinioDB.StudenteSelezionato);

            int countInsufficenze = 0;

            foreach (var el in l)
            {
                if (float.Parse(el.Voto) < 6)
                {
                    countInsufficenze++;
                }
            }

            if(countInsufficenze == 0)
            {
                lbl_esito.Text = "Esito: PROMOSSO";
            }
            else if (countInsufficenze > 3)
            {
                lbl_esito.Text = "Esito: BOCCIATO";
            }
            else
            {
                lbl_esito.Text = "Esito: RIMANDATO";
            }
        }
    }

    public class ScrutinioDB
    {
        public static List<string> Studenti { get; set; } = new List<string>();
        public static List<string> Materie { get; set; } = new List<string>();

        public static List<Scrutinio> Scrutini { get; set; } = new List<Scrutinio>();
        public static string StudenteSelezionato { get; set; }

        public static string path = "C:\\Users\\nicola.emmolo\\source\\repos\\EserciziWindowsFormsApp\\ScrutinioFileCSV.csv";
    }

    public class Scrutinio
    {
        public string Nome { get; set; }
        public string Materia { get; set; }
        public string Voto { get; set; }

        public Scrutinio(string nome, string materia, string voto)
        {
            Nome = nome;
            Materia = materia;
            Voto = voto;
        }
    }
}
