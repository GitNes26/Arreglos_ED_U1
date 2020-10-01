namespace ProyectoFinalU1_ArregloLetras
{
    partial class Inicio
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
            this.Btn_Iniciar = new System.Windows.Forms.Button();
            this.Creditos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.Location = new System.Drawing.Point(73, 200);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.Size = new System.Drawing.Size(188, 43);
            this.Btn_Iniciar.TabIndex = 0;
            this.Btn_Iniciar.Text = "button1";
            this.Btn_Iniciar.UseVisualStyleBackColor = true;
            // 
            // Creditos
            // 
            this.Creditos.Location = new System.Drawing.Point(73, 279);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(188, 43);
            this.Creditos.TabIndex = 1;
            this.Creditos.Text = "Créditos";
            this.Creditos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(73, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 133);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Creditos);
            this.Controls.Add(this.Btn_Iniciar);
            this.Name = "Inicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Iniciar;
        private System.Windows.Forms.Button Creditos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

