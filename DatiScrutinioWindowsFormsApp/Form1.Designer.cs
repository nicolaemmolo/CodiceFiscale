namespace DatiScrutinioWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_studente1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addVoto = new System.Windows.Forms.Button();
            this.cbx_studenti1 = new System.Windows.Forms.ComboBox();
            this.cbx_materie = new System.Windows.Forms.ComboBox();
            this.tbx_voto = new System.Windows.Forms.TextBox();
            this.lbl_studente2 = new System.Windows.Forms.Label();
            this.cbx_studenti2 = new System.Windows.Forms.ComboBox();
            this.btn_avg = new System.Windows.Forms.Button();
            this.lbl_avg = new System.Windows.Forms.Label();
            this.lbx_voti = new System.Windows.Forms.ListBox();
            this.btn_maxVoto = new System.Windows.Forms.Button();
            this.lbl_maxVoto = new System.Windows.Forms.Label();
            this.btn_checkPromosso = new System.Windows.Forms.Button();
            this.lbl_esito = new System.Windows.Forms.Label();
            this.btn_conferma = new System.Windows.Forms.Button();
            this.btn_mostraVoti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_studente1
            // 
            this.lbl_studente1.AutoSize = true;
            this.lbl_studente1.Location = new System.Drawing.Point(22, 34);
            this.lbl_studente1.Name = "lbl_studente1";
            this.lbl_studente1.Size = new System.Drawing.Size(75, 20);
            this.lbl_studente1.TabIndex = 0;
            this.lbl_studente1.Text = "Studente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voto";
            // 
            // btn_addVoto
            // 
            this.btn_addVoto.Location = new System.Drawing.Point(641, 49);
            this.btn_addVoto.Name = "btn_addVoto";
            this.btn_addVoto.Size = new System.Drawing.Size(89, 74);
            this.btn_addVoto.TabIndex = 3;
            this.btn_addVoto.Text = "Aggiungi Voto";
            this.btn_addVoto.UseVisualStyleBackColor = true;
            this.btn_addVoto.Click += new System.EventHandler(this.btn_addVoto_Click);
            // 
            // cbx_studenti1
            // 
            this.cbx_studenti1.FormattingEnabled = true;
            this.cbx_studenti1.Location = new System.Drawing.Point(26, 73);
            this.cbx_studenti1.Name = "cbx_studenti1";
            this.cbx_studenti1.Size = new System.Drawing.Size(165, 28);
            this.cbx_studenti1.TabIndex = 4;
            // 
            // cbx_materie
            // 
            this.cbx_materie.FormattingEnabled = true;
            this.cbx_materie.Location = new System.Drawing.Point(244, 73);
            this.cbx_materie.Name = "cbx_materie";
            this.cbx_materie.Size = new System.Drawing.Size(165, 28);
            this.cbx_materie.TabIndex = 5;
            // 
            // tbx_voto
            // 
            this.tbx_voto.Location = new System.Drawing.Point(467, 73);
            this.tbx_voto.Name = "tbx_voto";
            this.tbx_voto.Size = new System.Drawing.Size(100, 26);
            this.tbx_voto.TabIndex = 6;
            // 
            // lbl_studente2
            // 
            this.lbl_studente2.AutoSize = true;
            this.lbl_studente2.Location = new System.Drawing.Point(22, 166);
            this.lbl_studente2.Name = "lbl_studente2";
            this.lbl_studente2.Size = new System.Drawing.Size(75, 20);
            this.lbl_studente2.TabIndex = 7;
            this.lbl_studente2.Text = "Studente";
            // 
            // cbx_studenti2
            // 
            this.cbx_studenti2.FormattingEnabled = true;
            this.cbx_studenti2.Location = new System.Drawing.Point(26, 211);
            this.cbx_studenti2.Name = "cbx_studenti2";
            this.cbx_studenti2.Size = new System.Drawing.Size(165, 28);
            this.cbx_studenti2.TabIndex = 8;
            // 
            // btn_avg
            // 
            this.btn_avg.Location = new System.Drawing.Point(244, 205);
            this.btn_avg.Name = "btn_avg";
            this.btn_avg.Size = new System.Drawing.Size(133, 39);
            this.btn_avg.TabIndex = 9;
            this.btn_avg.Text = "Calcola Media";
            this.btn_avg.UseVisualStyleBackColor = true;
            this.btn_avg.Click += new System.EventHandler(this.btn_avg_Click);
            // 
            // lbl_avg
            // 
            this.lbl_avg.AutoSize = true;
            this.lbl_avg.Location = new System.Drawing.Point(431, 214);
            this.lbl_avg.Name = "lbl_avg";
            this.lbl_avg.Size = new System.Drawing.Size(56, 20);
            this.lbl_avg.TabIndex = 10;
            this.lbl_avg.Text = "Media:";
            // 
            // lbx_voti
            // 
            this.lbx_voti.FormattingEnabled = true;
            this.lbx_voti.ItemHeight = 20;
            this.lbx_voti.Location = new System.Drawing.Point(435, 260);
            this.lbx_voti.Name = "lbx_voti";
            this.lbx_voti.Size = new System.Drawing.Size(276, 104);
            this.lbx_voti.TabIndex = 12;
            // 
            // btn_maxVoto
            // 
            this.btn_maxVoto.Location = new System.Drawing.Point(244, 390);
            this.btn_maxVoto.Name = "btn_maxVoto";
            this.btn_maxVoto.Size = new System.Drawing.Size(133, 41);
            this.btn_maxVoto.TabIndex = 13;
            this.btn_maxVoto.Text = "Voto più alto";
            this.btn_maxVoto.UseVisualStyleBackColor = true;
            this.btn_maxVoto.Click += new System.EventHandler(this.btn_maxVoto_Click);
            // 
            // lbl_maxVoto
            // 
            this.lbl_maxVoto.AutoSize = true;
            this.lbl_maxVoto.Location = new System.Drawing.Point(436, 400);
            this.lbl_maxVoto.Name = "lbl_maxVoto";
            this.lbl_maxVoto.Size = new System.Drawing.Size(47, 20);
            this.lbl_maxVoto.TabIndex = 14;
            this.lbl_maxVoto.Text = "Voto:";
            // 
            // btn_checkPromosso
            // 
            this.btn_checkPromosso.Location = new System.Drawing.Point(121, 510);
            this.btn_checkPromosso.Name = "btn_checkPromosso";
            this.btn_checkPromosso.Size = new System.Drawing.Size(288, 57);
            this.btn_checkPromosso.TabIndex = 15;
            this.btn_checkPromosso.Text = "Controlla Promozione";
            this.btn_checkPromosso.UseVisualStyleBackColor = true;
            this.btn_checkPromosso.Click += new System.EventHandler(this.btn_checkPromosso_Click);
            // 
            // lbl_esito
            // 
            this.lbl_esito.AutoSize = true;
            this.lbl_esito.Location = new System.Drawing.Point(476, 528);
            this.lbl_esito.Name = "lbl_esito";
            this.lbl_esito.Size = new System.Drawing.Size(49, 20);
            this.lbl_esito.TabIndex = 16;
            this.lbl_esito.Text = "Esito:";
            // 
            // btn_conferma
            // 
            this.btn_conferma.Location = new System.Drawing.Point(26, 246);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(165, 30);
            this.btn_conferma.TabIndex = 17;
            this.btn_conferma.Text = "Conferma Studente";
            this.btn_conferma.UseVisualStyleBackColor = true;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // btn_mostraVoti
            // 
            this.btn_mostraVoti.Location = new System.Drawing.Point(244, 283);
            this.btn_mostraVoti.Name = "btn_mostraVoti";
            this.btn_mostraVoti.Size = new System.Drawing.Size(133, 40);
            this.btn_mostraVoti.TabIndex = 18;
            this.btn_mostraVoti.Text = "Mostra i voti";
            this.btn_mostraVoti.UseVisualStyleBackColor = true;
            this.btn_mostraVoti.Click += new System.EventHandler(this.btn_mostraVoti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.btn_mostraVoti);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.lbl_esito);
            this.Controls.Add(this.btn_checkPromosso);
            this.Controls.Add(this.lbl_maxVoto);
            this.Controls.Add(this.btn_maxVoto);
            this.Controls.Add(this.lbx_voti);
            this.Controls.Add(this.lbl_avg);
            this.Controls.Add(this.btn_avg);
            this.Controls.Add(this.cbx_studenti2);
            this.Controls.Add(this.lbl_studente2);
            this.Controls.Add(this.tbx_voto);
            this.Controls.Add(this.cbx_materie);
            this.Controls.Add(this.cbx_studenti1);
            this.Controls.Add(this.btn_addVoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_studente1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_studente1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addVoto;
        private System.Windows.Forms.ComboBox cbx_studenti1;
        private System.Windows.Forms.ComboBox cbx_materie;
        private System.Windows.Forms.TextBox tbx_voto;
        private System.Windows.Forms.Label lbl_studente2;
        private System.Windows.Forms.ComboBox cbx_studenti2;
        private System.Windows.Forms.Button btn_avg;
        private System.Windows.Forms.Label lbl_avg;
        private System.Windows.Forms.ListBox lbx_voti;
        private System.Windows.Forms.Button btn_maxVoto;
        private System.Windows.Forms.Label lbl_maxVoto;
        private System.Windows.Forms.Button btn_checkPromosso;
        private System.Windows.Forms.Label lbl_esito;
        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.Button btn_mostraVoti;
    }
}

