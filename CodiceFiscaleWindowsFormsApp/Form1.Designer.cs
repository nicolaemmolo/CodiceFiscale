namespace CodiceFiscaleWindowsFormsApp
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
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cognome = new System.Windows.Forms.Label();
            this.lbl_sesso = new System.Windows.Forms.Label();
            this.lbl_dataNascita = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_cognome = new System.Windows.Forms.TextBox();
            this.dtp_dataNascita = new System.Windows.Forms.DateTimePicker();
            this.cbx_comuneNascita = new System.Windows.Forms.ComboBox();
            this.rbn_maschio = new System.Windows.Forms.RadioButton();
            this.rbn_femmina = new System.Windows.Forms.RadioButton();
            this.lbl_comuneNascita = new System.Windows.Forms.Label();
            this.btn_generaCF = new System.Windows.Forms.Button();
            this.lbl_cf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Location = new System.Drawing.Point(329, 22);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(143, 20);
            this.lbl_titolo.TabIndex = 0;
            this.lbl_titolo.Text = "CODICE FISCALE";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(142, 90);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(51, 20);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_cognome
            // 
            this.lbl_cognome.AutoSize = true;
            this.lbl_cognome.Location = new System.Drawing.Point(142, 147);
            this.lbl_cognome.Name = "lbl_cognome";
            this.lbl_cognome.Size = new System.Drawing.Size(78, 20);
            this.lbl_cognome.TabIndex = 2;
            this.lbl_cognome.Text = "Cognome";
            // 
            // lbl_sesso
            // 
            this.lbl_sesso.AutoSize = true;
            this.lbl_sesso.Location = new System.Drawing.Point(142, 199);
            this.lbl_sesso.Name = "lbl_sesso";
            this.lbl_sesso.Size = new System.Drawing.Size(54, 20);
            this.lbl_sesso.TabIndex = 3;
            this.lbl_sesso.Text = "Sesso";
            // 
            // lbl_dataNascita
            // 
            this.lbl_dataNascita.AutoSize = true;
            this.lbl_dataNascita.Location = new System.Drawing.Point(142, 251);
            this.lbl_dataNascita.Name = "lbl_dataNascita";
            this.lbl_dataNascita.Size = new System.Drawing.Size(115, 20);
            this.lbl_dataNascita.TabIndex = 4;
            this.lbl_dataNascita.Text = "Data di nascita";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(322, 90);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(294, 26);
            this.tbx_nome.TabIndex = 5;
            // 
            // tbx_cognome
            // 
            this.tbx_cognome.Location = new System.Drawing.Point(322, 147);
            this.tbx_cognome.Name = "tbx_cognome";
            this.tbx_cognome.Size = new System.Drawing.Size(294, 26);
            this.tbx_cognome.TabIndex = 6;
            // 
            // dtp_dataNascita
            // 
            this.dtp_dataNascita.Location = new System.Drawing.Point(322, 251);
            this.dtp_dataNascita.Name = "dtp_dataNascita";
            this.dtp_dataNascita.Size = new System.Drawing.Size(294, 26);
            this.dtp_dataNascita.TabIndex = 7;
            // 
            // cbx_comuneNascita
            // 
            this.cbx_comuneNascita.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_comuneNascita.FormattingEnabled = true;
            this.cbx_comuneNascita.Location = new System.Drawing.Point(322, 303);
            this.cbx_comuneNascita.Name = "cbx_comuneNascita";
            this.cbx_comuneNascita.Size = new System.Drawing.Size(294, 28);
            this.cbx_comuneNascita.TabIndex = 8;
            // 
            // rbn_maschio
            // 
            this.rbn_maschio.AutoSize = true;
            this.rbn_maschio.Location = new System.Drawing.Point(322, 199);
            this.rbn_maschio.Name = "rbn_maschio";
            this.rbn_maschio.Size = new System.Drawing.Size(93, 24);
            this.rbn_maschio.TabIndex = 9;
            this.rbn_maschio.TabStop = true;
            this.rbn_maschio.Text = "Maschio";
            this.rbn_maschio.UseVisualStyleBackColor = true;
            // 
            // rbn_femmina
            // 
            this.rbn_femmina.AutoSize = true;
            this.rbn_femmina.Location = new System.Drawing.Point(490, 199);
            this.rbn_femmina.Name = "rbn_femmina";
            this.rbn_femmina.Size = new System.Drawing.Size(100, 24);
            this.rbn_femmina.TabIndex = 10;
            this.rbn_femmina.TabStop = true;
            this.rbn_femmina.Text = "Femmina";
            this.rbn_femmina.UseVisualStyleBackColor = true;
            // 
            // lbl_comuneNascita
            // 
            this.lbl_comuneNascita.AutoSize = true;
            this.lbl_comuneNascita.Location = new System.Drawing.Point(142, 303);
            this.lbl_comuneNascita.Name = "lbl_comuneNascita";
            this.lbl_comuneNascita.Size = new System.Drawing.Size(140, 20);
            this.lbl_comuneNascita.TabIndex = 11;
            this.lbl_comuneNascita.Text = "Comune di nascita";
            // 
            // btn_generaCF
            // 
            this.btn_generaCF.Location = new System.Drawing.Point(69, 379);
            this.btn_generaCF.Name = "btn_generaCF";
            this.btn_generaCF.Size = new System.Drawing.Size(155, 45);
            this.btn_generaCF.TabIndex = 12;
            this.btn_generaCF.Text = "Genera CF";
            this.btn_generaCF.UseVisualStyleBackColor = true;
            this.btn_generaCF.Click += new System.EventHandler(this.btn_generaCF_Click);
            // 
            // lbl_cf
            // 
            this.lbl_cf.AutoSize = true;
            this.lbl_cf.Location = new System.Drawing.Point(296, 391);
            this.lbl_cf.Name = "lbl_cf";
            this.lbl_cf.Size = new System.Drawing.Size(38, 20);
            this.lbl_cf.TabIndex = 13;
            this.lbl_cf.Text = "CF: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_cf);
            this.Controls.Add(this.btn_generaCF);
            this.Controls.Add(this.lbl_comuneNascita);
            this.Controls.Add(this.rbn_femmina);
            this.Controls.Add(this.rbn_maschio);
            this.Controls.Add(this.cbx_comuneNascita);
            this.Controls.Add(this.dtp_dataNascita);
            this.Controls.Add(this.tbx_cognome);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.lbl_dataNascita);
            this.Controls.Add(this.lbl_sesso);
            this.Controls.Add(this.lbl_cognome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cognome;
        private System.Windows.Forms.Label lbl_sesso;
        private System.Windows.Forms.Label lbl_dataNascita;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox tbx_cognome;
        private System.Windows.Forms.DateTimePicker dtp_dataNascita;
        private System.Windows.Forms.ComboBox cbx_comuneNascita;
        private System.Windows.Forms.RadioButton rbn_maschio;
        private System.Windows.Forms.RadioButton rbn_femmina;
        private System.Windows.Forms.Label lbl_comuneNascita;
        private System.Windows.Forms.Button btn_generaCF;
        private System.Windows.Forms.Label lbl_cf;
    }
}

