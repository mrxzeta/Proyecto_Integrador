namespace Proyecto_Integrador
{
    partial class Registro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRegistar = new Proyecto_Integrador.jbuton();
            this.txtTelefono = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtContrasenaRegistro = new CustomControls.RJControls.RJTextBox();
            this.txtCorreoRegistro = new CustomControls.RJControls.RJTextBox();
            this.txtNombreRegistro = new CustomControls.RJControls.RJTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnRegistar);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FechaNacimiento);
            this.panel1.Controls.Add(this.txtContrasenaRegistro);
            this.panel1.Controls.Add(this.txtCorreoRegistro);
            this.panel1.Controls.Add(this.txtNombreRegistro);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 510);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(472, 477);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Tienes Cuenta? Inicia Sesión";
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistar.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistar.BorderRadius = 20;
            this.btnRegistar.BorderSize = 0;
            this.btnRegistar.FlatAppearance.BorderSize = 0;
            this.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistar.Location = new System.Drawing.Point(432, 412);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(245, 51);
            this.btnRegistar.TabIndex = 11;
            this.btnRegistar.Text = "Registrarse";
            this.btnRegistar.TextColor = System.Drawing.Color.Black;
            this.btnRegistar.UseVisualStyleBackColor = false;
            this.btnRegistar.Click += new System.EventHandler(this.jbuton1_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTelefono.BorderRadius = 0;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(339, 357);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(424, 35);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.Texts = "Telefono";
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha Nacimiento";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimiento.Location = new System.Drawing.Point(543, 213);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.FechaNacimiento.TabIndex = 8;
            // 
            // txtContrasenaRegistro
            // 
            this.txtContrasenaRegistro.BackColor = System.Drawing.SystemColors.Window;
            this.txtContrasenaRegistro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtContrasenaRegistro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtContrasenaRegistro.BorderRadius = 0;
            this.txtContrasenaRegistro.BorderSize = 2;
            this.txtContrasenaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaRegistro.ForeColor = System.Drawing.Color.DimGray;
            this.txtContrasenaRegistro.Location = new System.Drawing.Point(339, 304);
            this.txtContrasenaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenaRegistro.Multiline = false;
            this.txtContrasenaRegistro.Name = "txtContrasenaRegistro";
            this.txtContrasenaRegistro.Padding = new System.Windows.Forms.Padding(7);
            this.txtContrasenaRegistro.PasswordChar = false;
            this.txtContrasenaRegistro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContrasenaRegistro.PlaceholderText = "";
            this.txtContrasenaRegistro.Size = new System.Drawing.Size(424, 35);
            this.txtContrasenaRegistro.TabIndex = 6;
            this.txtContrasenaRegistro.Texts = "Contraseña";
            this.txtContrasenaRegistro.UnderlinedStyle = false;
            // 
            // txtCorreoRegistro
            // 
            this.txtCorreoRegistro.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreoRegistro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCorreoRegistro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCorreoRegistro.BorderRadius = 0;
            this.txtCorreoRegistro.BorderSize = 2;
            this.txtCorreoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoRegistro.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreoRegistro.Location = new System.Drawing.Point(339, 252);
            this.txtCorreoRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoRegistro.Multiline = false;
            this.txtCorreoRegistro.Name = "txtCorreoRegistro";
            this.txtCorreoRegistro.Padding = new System.Windows.Forms.Padding(7);
            this.txtCorreoRegistro.PasswordChar = false;
            this.txtCorreoRegistro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCorreoRegistro.PlaceholderText = "";
            this.txtCorreoRegistro.Size = new System.Drawing.Size(424, 35);
            this.txtCorreoRegistro.TabIndex = 5;
            this.txtCorreoRegistro.Texts = "Correo Electronico";
            this.txtCorreoRegistro.UnderlinedStyle = false;
            // 
            // txtNombreRegistro
            // 
            this.txtNombreRegistro.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreRegistro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreRegistro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreRegistro.BorderRadius = 0;
            this.txtNombreRegistro.BorderSize = 2;
            this.txtNombreRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRegistro.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreRegistro.Location = new System.Drawing.Point(339, 149);
            this.txtNombreRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreRegistro.Multiline = false;
            this.txtNombreRegistro.Name = "txtNombreRegistro";
            this.txtNombreRegistro.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombreRegistro.PasswordChar = false;
            this.txtNombreRegistro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreRegistro.PlaceholderText = "";
            this.txtNombreRegistro.Size = new System.Drawing.Size(424, 35);
            this.txtNombreRegistro.TabIndex = 2;
            this.txtNombreRegistro.Texts = "Nombre";
            this.txtNombreRegistro.UnderlinedStyle = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Integrador.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(389, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Integrador.Properties.Resources.sesion3;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 510);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private jbuton btnRegistar;
        private CustomControls.RJControls.RJTextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaNacimiento;
        private CustomControls.RJControls.RJTextBox txtContrasenaRegistro;
        private CustomControls.RJControls.RJTextBox txtCorreoRegistro;
        private CustomControls.RJControls.RJTextBox txtNombreRegistro;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}