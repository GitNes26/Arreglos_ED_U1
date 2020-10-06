namespace ProyectoFinalU1_ArregloLetras
{
    partial class ListadoLetras
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 394);
            this.listBox1.TabIndex = 0;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Regresar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Regresar.Font = new System.Drawing.Font("Arial Nova Cond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Location = new System.Drawing.Point(13, 422);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(170, 64);
            this.Btn_Regresar.TabIndex = 1;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.UseVisualStyleBackColor = false;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // ListadoLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 498);
            this.Controls.Add(this.Btn_Regresar);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoLetras";
            this.Text = "ListadoLetras";
            this.Load += new System.EventHandler(this.ListadoLetras_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Btn_Regresar;
    }
}