namespace Test.P12
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFechaEmision = new MetroFramework.Controls.MetroLabel();
            this.lblFechaVencimiento = new MetroFramework.Controls.MetroLabel();
            this.btnValidar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.TextBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(201, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Ubicación de la firma electrónica";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Contraseña de la firma";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(23, 154);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(114, 19);
            this.lblFechaEmision.TabIndex = 4;
            this.lblFechaEmision.Text = "Fecha de emisión:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(24, 173);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(139, 19);
            this.lblFechaVencimiento.TabIndex = 5;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(24, 196);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(292, 23);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseSelectable = true;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 246);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroLabel lblFechaEmision;
        private MetroFramework.Controls.MetroLabel lblFechaVencimiento;
        private MetroFramework.Controls.MetroButton btnValidar;
    }
}

