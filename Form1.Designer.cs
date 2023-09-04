namespace PryKaplanCarpetas
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
            this.ventanaCarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGrabarArchivo = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.btnAbrirCarpeta = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnGrabarArchivo
            // 
            this.btnGrabarArchivo.Location = new System.Drawing.Point(34, 252);
            this.btnGrabarArchivo.Name = "btnGrabarArchivo";
            this.btnGrabarArchivo.Size = new System.Drawing.Size(143, 53);
            this.btnGrabarArchivo.TabIndex = 0;
            this.btnGrabarArchivo.Text = "Grabar Archivo";
            this.btnGrabarArchivo.UseVisualStyleBackColor = true;
            this.btnGrabarArchivo.Click += new System.EventHandler(this.btnGrabarArchivo_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(12, 215);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(134, 20);
            this.txtNombreArchivo.TabIndex = 1;
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplo.Location = new System.Drawing.Point(16, 106);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(111, 31);
            this.lblEjemplo.TabIndex = 2;
            this.lblEjemplo.Text = "Ejemplo";
            // 
            // btnAbrirCarpeta
            // 
            this.btnAbrirCarpeta.Location = new System.Drawing.Point(22, 29);
            this.btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            this.btnAbrirCarpeta.Size = new System.Drawing.Size(184, 43);
            this.btnAbrirCarpeta.TabIndex = 3;
            this.btnAbrirCarpeta.Text = "Abrir Navegador Carpeta";
            this.btnAbrirCarpeta.UseVisualStyleBackColor = true;
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.btnAbrirCarpeta_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(254, 95);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(117, 120);
            this.treeView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 346);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnAbrirCarpeta);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnGrabarArchivo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Carpetas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog ventanaCarpetas;
        private System.Windows.Forms.Button btnGrabarArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.Button btnAbrirCarpeta;
        private System.Windows.Forms.TreeView treeView1;
    }
}

