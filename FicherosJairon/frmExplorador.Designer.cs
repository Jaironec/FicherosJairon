namespace FicherosJairon
{
    partial class frmExplorador
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.textCarpeta = new System.Windows.Forms.TextBox();
            this.listaDeArchivos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carpeta";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(478, 83);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // textCarpeta
            // 
            this.textCarpeta.Location = new System.Drawing.Point(159, 86);
            this.textCarpeta.Name = "textCarpeta";
            this.textCarpeta.Size = new System.Drawing.Size(295, 20);
            this.textCarpeta.TabIndex = 2;
            // 
            // listaDeArchivos
            // 
            this.listaDeArchivos.FormattingEnabled = true;
            this.listaDeArchivos.Location = new System.Drawing.Point(159, 155);
            this.listaDeArchivos.Name = "listaDeArchivos";
            this.listaDeArchivos.Size = new System.Drawing.Size(316, 238);
            this.listaDeArchivos.TabIndex = 3;
            // 
            // frmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaDeArchivos);
            this.Controls.Add(this.textCarpeta);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.Name = "frmExplorador";
            this.Text = "frmExplorador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox textCarpeta;
        private System.Windows.Forms.ListBox listaDeArchivos;
    }
}