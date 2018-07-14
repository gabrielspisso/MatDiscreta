namespace TautologiaContingenciaContradiccion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Operar = new System.Windows.Forms.Button();
            this.cbOperacion1 = new System.Windows.Forms.ComboBox();
            this.cbOperacion2 = new System.Windows.Forms.ComboBox();
            this.cbP = new System.Windows.Forms.ComboBox();
            this.cbQ = new System.Windows.Forms.ComboBox();
            this.cbR = new System.Windows.Forms.ComboBox();
            this.lblP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb23 = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operar
            // 
            this.Operar.Location = new System.Drawing.Point(115, 216);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(75, 23);
            this.Operar.TabIndex = 0;
            this.Operar.Text = "Calcular";
            this.Operar.UseVisualStyleBackColor = true;
            this.Operar.Click += new System.EventHandler(this.Operar_Click);
            // 
            // cbOperacion1
            // 
            this.cbOperacion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperacion1.FormattingEnabled = true;
            this.cbOperacion1.Items.AddRange(new object[] {
            "^",
            "v",
            "Xv",
            "=>",
            "<=>"});
            this.cbOperacion1.Location = new System.Drawing.Point(79, 43);
            this.cbOperacion1.Name = "cbOperacion1";
            this.cbOperacion1.Size = new System.Drawing.Size(57, 21);
            this.cbOperacion1.TabIndex = 1;
            // 
            // cbOperacion2
            // 
            this.cbOperacion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperacion2.FormattingEnabled = true;
            this.cbOperacion2.Items.AddRange(new object[] {
            "^",
            "v",
            "Xv",
            "=>",
            "<=>"});
            this.cbOperacion2.Location = new System.Drawing.Point(189, 43);
            this.cbOperacion2.Name = "cbOperacion2";
            this.cbOperacion2.Size = new System.Drawing.Size(57, 21);
            this.cbOperacion2.TabIndex = 2;
            // 
            // cbP
            // 
            this.cbP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP.FormattingEnabled = true;
            this.cbP.Items.AddRange(new object[] {
            "V",
            "F"});
            this.cbP.Location = new System.Drawing.Point(56, 112);
            this.cbP.Name = "cbP";
            this.cbP.Size = new System.Drawing.Size(45, 21);
            this.cbP.TabIndex = 3;
            // 
            // cbQ
            // 
            this.cbQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQ.FormattingEnabled = true;
            this.cbQ.Items.AddRange(new object[] {
            "V",
            "F"});
            this.cbQ.Location = new System.Drawing.Point(56, 139);
            this.cbQ.Name = "cbQ";
            this.cbQ.Size = new System.Drawing.Size(45, 21);
            this.cbQ.TabIndex = 3;
            // 
            // cbR
            // 
            this.cbR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbR.FormattingEnabled = true;
            this.cbR.Items.AddRange(new object[] {
            "V",
            "F"});
            this.cbR.Location = new System.Drawing.Point(56, 166);
            this.cbR.Name = "cbR";
            this.cbR.Size = new System.Drawing.Size(45, 21);
            this.cbR.TabIndex = 4;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(60, 46);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(13, 13);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "p";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(158, 46);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(13, 13);
            this.lblQ.TabIndex = 6;
            this.lblQ.Text = "q";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(252, 46);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(10, 13);
            this.lblR.TabIndex = 7;
            this.lblR.Text = "r";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "p";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "r";
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.Location = new System.Drawing.Point(223, 114);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(173, 17);
            this.rb12.TabIndex = 11;
            this.rb12.Text = "Parentesis en 1er y 2do termino";
            this.rb12.UseVisualStyleBackColor = true;
            this.rb12.CheckedChanged += new System.EventHandler(this.rb12_CheckedChanged);
            // 
            // rb23
            // 
            this.rb23.AutoSize = true;
            this.rb23.Location = new System.Drawing.Point(223, 142);
            this.rb23.Name = "rb23";
            this.rb23.Size = new System.Drawing.Size(173, 17);
            this.rb23.TabIndex = 12;
            this.rb23.Text = "Parentesis en 2do y 3er termino";
            this.rb23.UseVisualStyleBackColor = true;
            this.rb23.CheckedChanged += new System.EventHandler(this.rb23_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(223, 165);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(91, 17);
            this.rbNo.TabIndex = 13;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Sin parentesis";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(115, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Negado";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(115, 143);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Negado";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(115, 169);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Negado";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(44, 46);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(10, 13);
            this.lbl11.TabIndex = 17;
            this.lbl11.Text = "(";
            this.lbl11.Visible = false;
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.Location = new System.Drawing.Point(142, 46);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(10, 13);
            this.lbl21.TabIndex = 18;
            this.lbl21.Text = "(";
            this.lbl21.Visible = false;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(179, 46);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(10, 13);
            this.lbl12.TabIndex = 19;
            this.lbl12.Text = ")";
            this.lbl12.Visible = false;
            // 
            // lbl22
            // 
            this.lbl22.AutoSize = true;
            this.lbl22.Location = new System.Drawing.Point(268, 46);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(10, 13);
            this.lbl22.TabIndex = 20;
            this.lbl22.Text = ")";
            this.lbl22.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 261);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rb23);
            this.Controls.Add(this.rb12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.cbR);
            this.Controls.Add(this.cbQ);
            this.Controls.Add(this.cbP);
            this.Controls.Add(this.cbOperacion2);
            this.Controls.Add(this.cbOperacion1);
            this.Controls.Add(this.Operar);
            this.Name = "Form1";
            this.Text = "Compuertas Lógicas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.ComboBox cbOperacion1;
        private System.Windows.Forms.ComboBox cbOperacion2;
        private System.Windows.Forms.ComboBox cbP;
        private System.Windows.Forms.ComboBox cbQ;
        private System.Windows.Forms.ComboBox cbR;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb23;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl22;
    }
}

