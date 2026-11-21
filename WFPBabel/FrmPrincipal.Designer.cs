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
            this.picBabel = new System.Windows.Forms.PictureBox();
            this.picHH = new System.Windows.Forms.PictureBox();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sptPrincipal)).BeginInit();
            this.sptPrincipal.Panel1.SuspendLayout();
            this.sptPrincipal.Panel2.SuspendLayout();
            this.sptPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHH)).BeginInit();
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
            this.sptPrincipal.Panel2.Controls.Add(this.btnProbarConexion);
            this.sptPrincipal.Size = new System.Drawing.Size(1234, 711);
            this.sptPrincipal.SplitterDistance = 118;
            this.sptPrincipal.TabIndex = 0;
            // 
            // picBabel
            // 
            this.picBabel.Image = ((System.Drawing.Image)(resources.GetObject("picBabel.Image")));
            this.picBabel.Location = new System.Drawing.Point(1085, 0);
            this.picBabel.Name = "picBabel";
            this.picBabel.Size = new System.Drawing.Size(150, 120);
            this.picBabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBabel.TabIndex = 1;
            this.picBabel.TabStop = false;
            // 
            // picHH
            // 
            this.picHH.Image = ((System.Drawing.Image)(resources.GetObject("picHH.Image")));
            this.picHH.Location = new System.Drawing.Point(0, -14);
            this.picHH.Name = "picHH";
            this.picHH.Size = new System.Drawing.Size(150, 150);
            this.picHH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHH.TabIndex = 0;
            this.picHH.TabStop = false;
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(211, 167);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(75, 23);
            this.btnProbarConexion.TabIndex = 0;
            this.btnProbarConexion.Text = "button1";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.sptPrincipal);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sptPrincipal.Panel1.ResumeLayout(false);
            this.sptPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptPrincipal)).EndInit();
            this.sptPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptPrincipal;
        private System.Windows.Forms.PictureBox picBabel;
        private System.Windows.Forms.PictureBox picHH;
        private System.Windows.Forms.Button btnProbarConexion;
    }
}

