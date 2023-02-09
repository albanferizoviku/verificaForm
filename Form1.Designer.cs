namespace Verifica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttoninserisci = new System.Windows.Forms.Button();
            this.buttonmodifica = new System.Windows.Forms.Button();
            this.buttonelimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "cognome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttoninserisci
            // 
            this.buttoninserisci.Location = new System.Drawing.Point(90, 128);
            this.buttoninserisci.Name = "buttoninserisci";
            this.buttoninserisci.Size = new System.Drawing.Size(75, 23);
            this.buttoninserisci.TabIndex = 4;
            this.buttoninserisci.Text = "inserisci";
            this.buttoninserisci.UseVisualStyleBackColor = true;
            this.buttoninserisci.Click += new System.EventHandler(this.buttoninserisci_Click);
            // 
            // buttonmodifica
            // 
            this.buttonmodifica.Location = new System.Drawing.Point(171, 128);
            this.buttonmodifica.Name = "buttonmodifica";
            this.buttonmodifica.Size = new System.Drawing.Size(75, 23);
            this.buttonmodifica.TabIndex = 5;
            this.buttonmodifica.Text = "modifica";
            this.buttonmodifica.UseVisualStyleBackColor = true;
            this.buttonmodifica.Click += new System.EventHandler(this.buttonmodifica_Click);
            // 
            // buttonelimina
            // 
            this.buttonelimina.Location = new System.Drawing.Point(261, 128);
            this.buttonelimina.Name = "buttonelimina";
            this.buttonelimina.Size = new System.Drawing.Size(75, 23);
            this.buttonelimina.TabIndex = 6;
            this.buttonelimina.Text = "elimina";
            this.buttonelimina.UseVisualStyleBackColor = true;
            this.buttonelimina.Click += new System.EventHandler(this.buttonelimina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 198);
            this.Controls.Add(this.buttonelimina);
            this.Controls.Add(this.buttonmodifica);
            this.Controls.Add(this.buttoninserisci);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formanagrafica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttoninserisci;
        private Button buttonmodifica;
        private Button buttonelimina;
    }
}