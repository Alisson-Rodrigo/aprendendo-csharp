using System;
using System.Windows.Forms;

namespace MeuApp
{
    public class Program : Form
    {
        private Label lblPergunta;
        private TextBox txtNome;
        private Button btnSubmit;

        public Program()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblPergunta = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblPergunta
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(12, 9);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(147, 13);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "Por favor, digite seu nome:";

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(12, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 1;

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(12, 57);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Enviar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // Program
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 93);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPergunta);
            this.Name = "Program";
            this.Text = "Meu Aplicativo Windows Forms";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nome
