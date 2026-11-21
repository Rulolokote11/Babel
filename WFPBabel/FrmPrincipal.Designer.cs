namespace WFPBabel
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.sptPrincipal = new System.Windows.Forms.SplitContainer();
            this.picHH = new System.Windows.Forms.PictureBox();
            this.picBabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sptPrincipal)).BeginInit();
            this.sptPrincipal.Panel1.SuspendLayout();
            this.sptPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBabel)).BeginInit();
            this.SuspendLayout();
            // 
            // sptPrincipal
            // 
            this.sptPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptPrincipal.Location = new System.Drawing.Point(0, 0);
            this.sptPrincipal.Name = "sptPrincipal";
            this.sptPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptPrincipal.Panel1
            // 
            this.sptPrincipal.Panel1.BackColor = System.Drawing.Color.Black;
            this.sptPrincipal.Panel1.Controls.Add(this.picBabel);
            this.sptPrincipal.Panel1.Controls.Add(this.picHH);
            // 
            // sptPrincipal.Panel2
            // 
            this.sptPrincipal.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(226)))), ((int)(((byte)(5)))));
            this.sptPrincipal.Size = new System.Drawing.Size(884, 511);
            this.sptPrincipal.SplitterDistance = 89;
            this.sptPrincipal.TabIndex = 0;
            // 
            // picHH
            // 
            this.picHH.Image = ((System.Drawing.Image)(resources.GetObject("picHH.Image")));
            this.picHH.Location = new System.Drawing.Point(-1, 0);
            this.picHH.Name = "picHH";
            this.picHH.Size = new System.Drawing.Size(90, 90);
            this.picHH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHH.TabIndex = 0;
            this.picHH.TabStop = false;
            // 
            // picBabel
            // 
            this.picBabel.Image = ((System.Drawing.Image)(resources.GetObject("picBabel.Image")));
            this.picBabel.Location = new System.Drawing.Point(793, 0);
            this.picBabel.Name = "picBabel";
            this.picBabel.Size = new System.Drawing.Size(90, 90);
            this.picBabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBabel.TabIndex = 1;
            this.picBabel.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.sptPrincipal);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sptPrincipal.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptPrincipal)).EndInit();
            this.sptPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptPrincipal;
        private System.Windows.Forms.PictureBox picBabel;
        private System.Windows.Forms.PictureBox picHH;
    }
}

