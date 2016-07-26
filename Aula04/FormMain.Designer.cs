namespace Aula04
{
    partial class FormMain
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
            this.btnTestaHeranca = new System.Windows.Forms.Button();
            this.btnTesteAbstracao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestaHeranca
            // 
            this.btnTestaHeranca.Location = new System.Drawing.Point(12, 12);
            this.btnTestaHeranca.Name = "btnTestaHeranca";
            this.btnTestaHeranca.Size = new System.Drawing.Size(147, 23);
            this.btnTestaHeranca.TabIndex = 0;
            this.btnTestaHeranca.Text = "Testar Herança";
            this.btnTestaHeranca.UseVisualStyleBackColor = true;
            this.btnTestaHeranca.Click += new System.EventHandler(this.btnTestaHeranca_Click);
            // 
            // btnTesteAbstracao
            // 
            this.btnTesteAbstracao.Location = new System.Drawing.Point(165, 12);
            this.btnTesteAbstracao.Name = "btnTesteAbstracao";
            this.btnTesteAbstracao.Size = new System.Drawing.Size(196, 23);
            this.btnTesteAbstracao.TabIndex = 1;
            this.btnTesteAbstracao.Text = "Testa abstração";
            this.btnTesteAbstracao.UseVisualStyleBackColor = true;
            this.btnTesteAbstracao.Click += new System.EventHandler(this.btnTesteAbstracao_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Testa abstração 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTesteAbstracao);
            this.Controls.Add(this.btnTestaHeranca);
            this.Name = "FormMain";
            this.Text = "Form Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestaHeranca;
        private System.Windows.Forms.Button btnTesteAbstracao;
        private System.Windows.Forms.Button button1;
    }
}

