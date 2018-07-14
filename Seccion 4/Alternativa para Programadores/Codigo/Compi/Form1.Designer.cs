namespace Compi
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
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.btn_Compilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Texto
            // 
            this.txt_Texto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Texto.Location = new System.Drawing.Point(12, 32);
            this.txt_Texto.Multiline = true;
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Texto.Size = new System.Drawing.Size(260, 259);
            this.txt_Texto.TabIndex = 0;
            // 
            // btn_Compilar
            // 
            this.btn_Compilar.Location = new System.Drawing.Point(199, 297);
            this.btn_Compilar.Name = "btn_Compilar";
            this.btn_Compilar.Size = new System.Drawing.Size(73, 38);
            this.btn_Compilar.TabIndex = 1;
            this.btn_Compilar.Text = "COMPILAR";
            this.btn_Compilar.UseVisualStyleBackColor = true;
            this.btn_Compilar.Click += new System.EventHandler(this.btn_Compilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 347);
            this.Controls.Add(this.btn_Compilar);
            this.Controls.Add(this.txt_Texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Reconocedor Sintactico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Button btn_Compilar;
    }
}

