namespace EserciziWindowsFormsApp
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
            this.btn_inserisci = new System.Windows.Forms.Button();
            this.lbl_cognome = new System.Windows.Forms.Label();
            this.tbx_cognome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_consumo = new System.Windows.Forms.Label();
            this.lbl_unitamisura = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_consumo = new System.Windows.Forms.TextBox();
            this.tbx_unitamisura = new System.Windows.Forms.TextBox();
            this.tbx_data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_inserisci
            // 
            this.btn_inserisci.Location = new System.Drawing.Point(574, 163);
            this.btn_inserisci.Name = "btn_inserisci";
            this.btn_inserisci.Size = new System.Drawing.Size(198, 88);
            this.btn_inserisci.TabIndex = 0;
            this.btn_inserisci.Text = "Inserisci";
            this.btn_inserisci.UseVisualStyleBackColor = true;
            this.btn_inserisci.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_cognome
            // 
            this.lbl_cognome.AutoSize = true;
            this.lbl_cognome.Location = new System.Drawing.Point(60, 62);
            this.lbl_cognome.Name = "lbl_cognome";
            this.lbl_cognome.Size = new System.Drawing.Size(78, 20);
            this.lbl_cognome.TabIndex = 1;
            this.lbl_cognome.Text = "Cognome";
            // 
            // tbx_cognome
            // 
            this.tbx_cognome.Location = new System.Drawing.Point(224, 62);
            this.tbx_cognome.Name = "tbx_cognome";
            this.tbx_cognome.Size = new System.Drawing.Size(279, 26);
            this.tbx_cognome.TabIndex = 2;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(60, 129);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(51, 20);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_consumo
            // 
            this.lbl_consumo.AutoSize = true;
            this.lbl_consumo.Location = new System.Drawing.Point(60, 194);
            this.lbl_consumo.Name = "lbl_consumo";
            this.lbl_consumo.Size = new System.Drawing.Size(77, 20);
            this.lbl_consumo.TabIndex = 4;
            this.lbl_consumo.Text = "Consumo";
            // 
            // lbl_unitamisura
            // 
            this.lbl_unitamisura.AutoSize = true;
            this.lbl_unitamisura.Location = new System.Drawing.Point(60, 257);
            this.lbl_unitamisura.Name = "lbl_unitamisura";
            this.lbl_unitamisura.Size = new System.Drawing.Size(114, 20);
            this.lbl_unitamisura.TabIndex = 5;
            this.lbl_unitamisura.Text = "Unità di Misura";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(60, 321);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(44, 20);
            this.lbl_data.TabIndex = 6;
            this.lbl_data.Text = "Data";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(224, 129);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(279, 26);
            this.tbx_nome.TabIndex = 7;
            // 
            // tbx_consumo
            // 
            this.tbx_consumo.Location = new System.Drawing.Point(224, 194);
            this.tbx_consumo.Name = "tbx_consumo";
            this.tbx_consumo.Size = new System.Drawing.Size(279, 26);
            this.tbx_consumo.TabIndex = 8;
            // 
            // tbx_unitamisura
            // 
            this.tbx_unitamisura.Location = new System.Drawing.Point(224, 257);
            this.tbx_unitamisura.Name = "tbx_unitamisura";
            this.tbx_unitamisura.Size = new System.Drawing.Size(279, 26);
            this.tbx_unitamisura.TabIndex = 9;
            // 
            // tbx_data
            // 
            this.tbx_data.Location = new System.Drawing.Point(224, 321);
            this.tbx_data.Name = "tbx_data";
            this.tbx_data.Size = new System.Drawing.Size(279, 26);
            this.tbx_data.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_data);
            this.Controls.Add(this.tbx_unitamisura);
            this.Controls.Add(this.tbx_consumo);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_unitamisura);
            this.Controls.Add(this.lbl_consumo);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.tbx_cognome);
            this.Controls.Add(this.lbl_cognome);
            this.Controls.Add(this.btn_inserisci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inserisci;
        private System.Windows.Forms.Label lbl_cognome;
        private System.Windows.Forms.TextBox tbx_cognome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_consumo;
        private System.Windows.Forms.Label lbl_unitamisura;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox tbx_consumo;
        private System.Windows.Forms.TextBox tbx_unitamisura;
        private System.Windows.Forms.TextBox tbx_data;
    }
}

