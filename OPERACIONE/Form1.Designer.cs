namespace OPERACIONE
{
    partial class Calculadora
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
            this.SUMA = new System.Windows.Forms.Button();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.RESTA = new System.Windows.Forms.Button();
            this.MULTIPLICACION = new System.Windows.Forms.Button();
            this.DIVISION = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SUMA
            // 
            this.SUMA.Location = new System.Drawing.Point(20, 82);
            this.SUMA.Name = "SUMA";
            this.SUMA.Size = new System.Drawing.Size(110, 43);
            this.SUMA.TabIndex = 0;
            this.SUMA.Text = "+";
            this.SUMA.UseVisualStyleBackColor = true;
            this.SUMA.Click += new System.EventHandler(this.SUMA_Click);
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(20, 21);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(103, 22);
            this.textBoxN1.TabIndex = 1;
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(170, 21);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(110, 22);
            this.textBoxN2.TabIndex = 2;
            // 
            // RESTA
            // 
            this.RESTA.Location = new System.Drawing.Point(170, 82);
            this.RESTA.Name = "RESTA";
            this.RESTA.Size = new System.Drawing.Size(110, 43);
            this.RESTA.TabIndex = 3;
            this.RESTA.Text = "-";
            this.RESTA.UseVisualStyleBackColor = true;
            this.RESTA.Click += new System.EventHandler(this.RESTA_Click);
            // 
            // MULTIPLICACION
            // 
            this.MULTIPLICACION.Location = new System.Drawing.Point(20, 152);
            this.MULTIPLICACION.Name = "MULTIPLICACION";
            this.MULTIPLICACION.Size = new System.Drawing.Size(110, 43);
            this.MULTIPLICACION.TabIndex = 4;
            this.MULTIPLICACION.Text = "*";
            this.MULTIPLICACION.UseVisualStyleBackColor = true;
            this.MULTIPLICACION.Click += new System.EventHandler(this.MULTIPLICACION_Click);
            // 
            // DIVISION
            // 
            this.DIVISION.Location = new System.Drawing.Point(170, 152);
            this.DIVISION.Name = "DIVISION";
            this.DIVISION.Size = new System.Drawing.Size(110, 43);
            this.DIVISION.TabIndex = 5;
            this.DIVISION.Text = "/";
            this.DIVISION.UseVisualStyleBackColor = true;
            this.DIVISION.Click += new System.EventHandler(this.DIVISION_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(20, 222);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(260, 22);
            this.textBoxR.TabIndex = 6;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 256);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.DIVISION);
            this.Controls.Add(this.MULTIPLICACION);
            this.Controls.Add(this.RESTA);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.textBoxN1);
            this.Controls.Add(this.SUMA);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SUMA;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.Button RESTA;
        private System.Windows.Forms.Button MULTIPLICACION;
        private System.Windows.Forms.Button DIVISION;
        private System.Windows.Forms.TextBox textBoxR;
    }
}

