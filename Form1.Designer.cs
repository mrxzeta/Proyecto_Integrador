namespace Proyecto_Integrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new Proyecto_Integrador.jbuton();
            this.btnRegistrarse = new Proyecto_Integrador.jbuton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 53);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIniciarSesion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIniciarSesion.BackgroundImage = global::Proyecto_Integrador.Properties.Resources.fondo_azul_purpura_claro_borroso_fondo_degradado_perla_abstracto_arte_desenfocado_desenfoque_lila_bokeh_113767_5717;
            this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarSesion.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.BorderRadius = 20;
            this.btnIniciarSesion.BorderSize = 1;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Location = new System.Drawing.Point(423, 276);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(244, 73);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Inicar Sesion";
            this.btnIniciarSesion.TextColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegistrarse.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegistrarse.BackgroundImage = global::Proyecto_Integrador.Properties.Resources.fondo_azul_purpura_claro_borroso_fondo_degradado_perla_abstracto_arte_desenfocado_desenfoque_lila_bokeh_113767_5717;
            this.btnRegistrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarse.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarse.BorderRadius = 20;
            this.btnRegistrarse.BorderSize = 1;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarse.Location = new System.Drawing.Point(423, 384);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(244, 73);
            this.btnRegistrarse.TabIndex = 4;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.TextColor = System.Drawing.Color.Black;
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proyecto_Integrador.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(299, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Integrador.Properties.Resources._3185942;
            this.ClientSize = new System.Drawing.Size(1033, 693);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private jbuton btnIniciarSesion;
        private jbuton btnRegistrarse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

