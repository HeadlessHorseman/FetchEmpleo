namespace FetchEmpleo
{
    partial class FormRegistroDemandante
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxContraseña = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.tbxFNac = new System.Windows.Forms.TextBox();
            this.tbxDomicilio = new System.Windows.Forms.TextBox();
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPaginaWeb = new System.Windows.Forms.TextBox();
            this.tbxTLF = new System.Windows.Forms.TextBox();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblpasswd = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFNac = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPagWeb = new System.Windows.Forms.Label();
            this.lblTlf = new System.Windows.Forms.Label();
            this.cbxDiscapacitado = new System.Windows.Forms.CheckBox();
            this.rbtHombre = new System.Windows.Forms.RadioButton();
            this.rbtMujer = new System.Windows.Forms.RadioButton();
            this.pnlSexo = new System.Windows.Forms.Panel();
            this.lblSexo = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxConfirmarPw = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.pnlData2 = new System.Windows.Forms.Panel();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.pnlSexo.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlData2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(274, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(572, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de demandantes de empleo";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(74, 8);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(283, 20);
            this.tbxUsuario.TabIndex = 1;
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.Location = new System.Drawing.Point(74, 54);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.PasswordChar = '*';
            this.tbxContraseña.Size = new System.Drawing.Size(283, 20);
            this.tbxContraseña.TabIndex = 2;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(74, 146);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(283, 20);
            this.tbxNombre.TabIndex = 4;
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.Location = new System.Drawing.Point(74, 192);
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(283, 20);
            this.tbxApellidos.TabIndex = 5;
            this.tbxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // tbxFNac
            // 
            this.tbxFNac.Location = new System.Drawing.Point(74, 284);
            this.tbxFNac.Name = "tbxFNac";
            this.tbxFNac.Size = new System.Drawing.Size(283, 20);
            this.tbxFNac.TabIndex = 7;
            this.tbxFNac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFNac_KeyPress);
            // 
            // tbxDomicilio
            // 
            this.tbxDomicilio.Location = new System.Drawing.Point(74, 20);
            this.tbxDomicilio.Name = "tbxDomicilio";
            this.tbxDomicilio.Size = new System.Drawing.Size(283, 20);
            this.tbxDomicilio.TabIndex = 8;
            // 
            // tbxDNI
            // 
            this.tbxDNI.Location = new System.Drawing.Point(74, 238);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(283, 20);
            this.tbxDNI.TabIndex = 6;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(74, 330);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(283, 20);
            this.tbxEmail.TabIndex = 9;
            // 
            // tbxPaginaWeb
            // 
            this.tbxPaginaWeb.Location = new System.Drawing.Point(74, 66);
            this.tbxPaginaWeb.Name = "tbxPaginaWeb";
            this.tbxPaginaWeb.Size = new System.Drawing.Size(283, 20);
            this.tbxPaginaWeb.TabIndex = 10;
            // 
            // tbxTLF
            // 
            this.tbxTLF.Location = new System.Drawing.Point(74, 112);
            this.tbxTLF.Name = "tbxTLF";
            this.tbxTLF.Size = new System.Drawing.Size(283, 20);
            this.tbxTLF.TabIndex = 11;
            this.tbxTLF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTLF_KeyPress);
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDatos.Location = new System.Drawing.Point(812, 516);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(231, 43);
            this.btnIngresarDatos.TabIndex = 17;
            this.btnIngresarDatos.Text = "Registrar";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(812, 330);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(231, 43);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(812, 424);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(231, 43);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(41, 125);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 24);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuario*";
            // 
            // lblpasswd
            // 
            this.lblpasswd.AutoSize = true;
            this.lblpasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasswd.Location = new System.Drawing.Point(41, 171);
            this.lblpasswd.Name = "lblpasswd";
            this.lblpasswd.Size = new System.Drawing.Size(113, 24);
            this.lblpasswd.TabIndex = 19;
            this.lblpasswd.Text = "Contraseña*";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(41, 263);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 24);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre*";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(41, 309);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(95, 24);
            this.lblApellidos.TabIndex = 22;
            this.lblApellidos.Text = "Apellidos*";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(41, 355);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(48, 24);
            this.lblDNI.TabIndex = 23;
            this.lblDNI.Text = "DNI*";
            // 
            // lblFNac
            // 
            this.lblFNac.AutoSize = true;
            this.lblFNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNac.Location = new System.Drawing.Point(41, 401);
            this.lblFNac.Name = "lblFNac";
            this.lblFNac.Size = new System.Drawing.Size(195, 24);
            this.lblFNac.TabIndex = 24;
            this.lblFNac.Text = "Fecha de nacimiento*";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(41, 493);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(87, 24);
            this.lblDomicilio.TabIndex = 25;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(41, 447);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 24);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email*";
            // 
            // lblPagWeb
            // 
            this.lblPagWeb.AutoSize = true;
            this.lblPagWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagWeb.Location = new System.Drawing.Point(41, 539);
            this.lblPagWeb.Name = "lblPagWeb";
            this.lblPagWeb.Size = new System.Drawing.Size(113, 24);
            this.lblPagWeb.TabIndex = 27;
            this.lblPagWeb.Text = "Página Web";
            // 
            // lblTlf
            // 
            this.lblTlf.AutoSize = true;
            this.lblTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlf.Location = new System.Drawing.Point(41, 585);
            this.lblTlf.Name = "lblTlf";
            this.lblTlf.Size = new System.Drawing.Size(85, 24);
            this.lblTlf.TabIndex = 28;
            this.lblTlf.Text = "Teléfono";
            // 
            // cbxDiscapacitado
            // 
            this.cbxDiscapacitado.AutoSize = true;
            this.cbxDiscapacitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDiscapacitado.Location = new System.Drawing.Point(812, 117);
            this.cbxDiscapacitado.Name = "cbxDiscapacitado";
            this.cbxDiscapacitado.Size = new System.Drawing.Size(161, 28);
            this.cbxDiscapacitado.TabIndex = 12;
            this.cbxDiscapacitado.Text = "Discapacitado/a";
            this.cbxDiscapacitado.UseVisualStyleBackColor = true;
            // 
            // rbtHombre
            // 
            this.rbtHombre.AutoSize = true;
            this.rbtHombre.Location = new System.Drawing.Point(0, 7);
            this.rbtHombre.Name = "rbtHombre";
            this.rbtHombre.Size = new System.Drawing.Size(62, 17);
            this.rbtHombre.TabIndex = 13;
            this.rbtHombre.TabStop = true;
            this.rbtHombre.Text = "Hombre";
            this.rbtHombre.UseVisualStyleBackColor = true;
            // 
            // rbtMujer
            // 
            this.rbtMujer.AutoSize = true;
            this.rbtMujer.Location = new System.Drawing.Point(110, 7);
            this.rbtMujer.Name = "rbtMujer";
            this.rbtMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtMujer.TabIndex = 14;
            this.rbtMujer.TabStop = true;
            this.rbtMujer.Text = "Mujer";
            this.rbtMujer.UseVisualStyleBackColor = true;
            // 
            // pnlSexo
            // 
            this.pnlSexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSexo.Controls.Add(this.rbtHombre);
            this.pnlSexo.Controls.Add(this.rbtMujer);
            this.pnlSexo.Location = new System.Drawing.Point(812, 217);
            this.pnlSexo.Name = "pnlSexo";
            this.pnlSexo.Size = new System.Drawing.Size(188, 34);
            this.pnlSexo.TabIndex = 30;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(812, 198);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 28;
            this.lblSexo.Text = "Sexo";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.tbxConfirmarPw);
            this.pnlData.Controls.Add(this.tbxUsuario);
            this.pnlData.Controls.Add(this.tbxContraseña);
            this.pnlData.Controls.Add(this.tbxNombre);
            this.pnlData.Controls.Add(this.tbxApellidos);
            this.pnlData.Controls.Add(this.tbxFNac);
            this.pnlData.Controls.Add(this.tbxDNI);
            this.pnlData.Controls.Add(this.tbxEmail);
            this.pnlData.Location = new System.Drawing.Point(235, 117);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(571, 363);
            this.pnlData.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "(Formato de fecha: dd/mm/aaaa)";
            // 
            // tbxConfirmarPw
            // 
            this.tbxConfirmarPw.Location = new System.Drawing.Point(74, 100);
            this.tbxConfirmarPw.Name = "tbxConfirmarPw";
            this.tbxConfirmarPw.PasswordChar = '*';
            this.tbxConfirmarPw.Size = new System.Drawing.Size(283, 20);
            this.tbxConfirmarPw.TabIndex = 3;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(41, 217);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(196, 24);
            this.lblConfirmar.TabIndex = 20;
            this.lblConfirmar.Text = "Confirmar contraseña*";
            // 
            // pnlData2
            // 
            this.pnlData2.Controls.Add(this.tbxDomicilio);
            this.pnlData2.Controls.Add(this.tbxTLF);
            this.pnlData2.Controls.Add(this.tbxPaginaWeb);
            this.pnlData2.Location = new System.Drawing.Point(235, 473);
            this.pnlData2.Name = "pnlData2";
            this.pnlData2.Size = new System.Drawing.Size(440, 153);
            this.pnlData2.TabIndex = 31;
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(42, 640);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(232, 13);
            this.lblCamposObligatorios.TabIndex = 32;
            this.lblCamposObligatorios.Text = "Los campos marcados con ( * ) son obligatorios.";
            // 
            // FormRegistroDemandante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.pnlData2);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.pnlSexo);
            this.Controls.Add(this.cbxDiscapacitado);
            this.Controls.Add(this.lblTlf);
            this.Controls.Add(this.lblPagWeb);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblFNac);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblpasswd);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormRegistroDemandante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistroDemandante";
            this.pnlSexo.ResumeLayout(false);
            this.pnlSexo.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlData2.ResumeLayout(false);
            this.pnlData2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxContraseña;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.TextBox tbxFNac;
        private System.Windows.Forms.TextBox tbxDomicilio;
        private System.Windows.Forms.TextBox tbxDNI;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPaginaWeb;
        private System.Windows.Forms.TextBox tbxTLF;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblpasswd;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblFNac;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPagWeb;
        private System.Windows.Forms.Label lblTlf;
        private System.Windows.Forms.CheckBox cbxDiscapacitado;
        private System.Windows.Forms.RadioButton rbtHombre;
        private System.Windows.Forms.RadioButton rbtMujer;
        private System.Windows.Forms.Panel pnlSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.TextBox tbxConfirmarPw;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Panel pnlData2;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label label1;
    }
}