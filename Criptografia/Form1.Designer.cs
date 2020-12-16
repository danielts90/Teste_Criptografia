
namespace Criptografia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_chave = new System.Windows.Forms.TextBox();
            this.txt_TextoLimpo = new System.Windows.Forms.RichTextBox();
            this.txt_cripto = new System.Windows.Forms.RichTextBox();
            this.txt_decripto = new System.Windows.Forms.RichTextBox();
            this.btn_Encriptar = new System.Windows.Forms.Button();
            this.btn_Decriptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_chaveAleatoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chave";
            // 
            // txt_chave
            // 
            this.txt_chave.Location = new System.Drawing.Point(53, 6);
            this.txt_chave.Name = "txt_chave";
            this.txt_chave.Size = new System.Drawing.Size(182, 20);
            this.txt_chave.TabIndex = 1;
            // 
            // txt_TextoLimpo
            // 
            this.txt_TextoLimpo.Location = new System.Drawing.Point(12, 42);
            this.txt_TextoLimpo.Name = "txt_TextoLimpo";
            this.txt_TextoLimpo.Size = new System.Drawing.Size(776, 96);
            this.txt_TextoLimpo.TabIndex = 2;
            this.txt_TextoLimpo.Text = "";
            // 
            // txt_cripto
            // 
            this.txt_cripto.Location = new System.Drawing.Point(12, 174);
            this.txt_cripto.Name = "txt_cripto";
            this.txt_cripto.Size = new System.Drawing.Size(776, 96);
            this.txt_cripto.TabIndex = 3;
            this.txt_cripto.Text = "";
            // 
            // txt_decripto
            // 
            this.txt_decripto.Location = new System.Drawing.Point(12, 316);
            this.txt_decripto.Name = "txt_decripto";
            this.txt_decripto.Size = new System.Drawing.Size(776, 96);
            this.txt_decripto.TabIndex = 4;
            this.txt_decripto.Text = "";
            // 
            // btn_Encriptar
            // 
            this.btn_Encriptar.Location = new System.Drawing.Point(309, 145);
            this.btn_Encriptar.Name = "btn_Encriptar";
            this.btn_Encriptar.Size = new System.Drawing.Size(174, 23);
            this.btn_Encriptar.TabIndex = 5;
            this.btn_Encriptar.Text = "Encriptar";
            this.btn_Encriptar.UseVisualStyleBackColor = true;
            this.btn_Encriptar.Click += new System.EventHandler(this.btn_Encriptar_Click);
            // 
            // btn_Decriptar
            // 
            this.btn_Decriptar.Location = new System.Drawing.Point(309, 287);
            this.btn_Decriptar.Name = "btn_Decriptar";
            this.btn_Decriptar.Size = new System.Drawing.Size(174, 23);
            this.btn_Decriptar.TabIndex = 6;
            this.btn_Decriptar.Text = "Decriptar";
            this.btn_Decriptar.UseVisualStyleBackColor = true;
            this.btn_Decriptar.Click += new System.EventHandler(this.btn_Decriptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // btn_chaveAleatoria
            // 
            this.btn_chaveAleatoria.Location = new System.Drawing.Point(241, 4);
            this.btn_chaveAleatoria.Name = "btn_chaveAleatoria";
            this.btn_chaveAleatoria.Size = new System.Drawing.Size(100, 23);
            this.btn_chaveAleatoria.TabIndex = 9;
            this.btn_chaveAleatoria.Text = "Chave Aleatória";
            this.btn_chaveAleatoria.UseVisualStyleBackColor = true;
            this.btn_chaveAleatoria.Click += new System.EventHandler(this.btn_chaveAleatoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.btn_chaveAleatoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Decriptar);
            this.Controls.Add(this.btn_Encriptar);
            this.Controls.Add(this.txt_decripto);
            this.Controls.Add(this.txt_cripto);
            this.Controls.Add(this.txt_TextoLimpo);
            this.Controls.Add(this.txt_chave);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "POC Criptografia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_chave;
        private System.Windows.Forms.RichTextBox txt_TextoLimpo;
        private System.Windows.Forms.RichTextBox txt_cripto;
        private System.Windows.Forms.RichTextBox txt_decripto;
        private System.Windows.Forms.Button btn_Encriptar;
        private System.Windows.Forms.Button btn_Decriptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_chaveAleatoria;
    }
}

