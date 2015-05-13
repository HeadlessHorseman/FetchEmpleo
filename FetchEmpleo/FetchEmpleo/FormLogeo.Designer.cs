namespace FetchEmpleo
{
    partial class FormPrincipalLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linklblEmpresas = new System.Windows.Forms.LinkLabel();
            this.linklblOlvidado = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnRegistrase = new System.Windows.Forms.Button();
            this.tbxContrasenya = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.lblNombrePrincipal = new System.Windows.Forms.Label();
            this.checkBoxUsuario = new System.Windows.Forms.RadioButton();
            this.checkBoxEmpresa = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linklblEmpresas);
            this.panel1.Controls.Add(this.linklblOlvidado);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.btnRegistrase);
            this.panel1.Controls.Add(this.tbxContrasenya);
            this.panel1.Controls.Add(this.tbxUsuario);
            this.panel1.Location = new System.Drawing.Point(94, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 245);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // linklblEmpresas
            // 
            this.linklblEmpresas.AutoSize = true;
            this.linklblEmpresas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.linklblEmpresas.Location = new System.Drawing.Point(23, 147);
            this.linklblEmpresas.Name = "linklblEmpresas";
            this.linklblEmpresas.Size = new System.Drawing.Size(217, 17);
            this.linklblEmpresas.TabIndex = 5;
            this.linklblEmpresas.TabStop = true;
            this.linklblEmpresas.Text = "¿Eres una empresa? Regístrate aquí";
            // 
            // linklblOlvidado
            // 
            this.linklblOlvidado.AutoSize = true;
            this.linklblOlvidado.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.linklblOlvidado.Location = new System.Drawing.Point(23, 105);
            this.linklblOlvidado.Name = "linklblOlvidado";
            this.linklblOlvidado.Size = new System.Drawing.Size(183, 17);
            this.linklblOlvidado.TabIndex = 4;
            this.linklblOlvidado.TabStop = true;
            this.linklblOlvidado.Text = "¿Has olvidado tu contraseña?";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(250, 31);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(107, 35);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnRegistrase
            // 
            this.btnRegistrase.BackColor = System.Drawing.Color.Red;
            this.btnRegistrase.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrase.Location = new System.Drawing.Point(67, 182);
            this.btnRegistrase.Name = "btnRegistrase";
            this.btnRegistrase.Size = new System.Drawing.Size(231, 44);
            this.btnRegistrase.TabIndex = 2;
            this.btnRegistrase.Text = "Regístrate";
            this.btnRegistrase.UseVisualStyleBackColor = false;
            // 
            // tbxContrasenya
            // 
            this.tbxContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContrasenya.ForeColor = System.Drawing.Color.Black;
            this.tbxContrasenya.Location = new System.Drawing.Point(126, 60);
            this.tbxContrasenya.Name = "tbxContrasenya";
            this.tbxContrasenya.PasswordChar = '*';
            this.tbxContrasenya.Size = new System.Drawing.Size(100, 24);
            this.tbxContrasenya.TabIndex = 1;
            this.tbxContrasenya.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbxContrasenya_MouseDoubleClick);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario.ForeColor = System.Drawing.Color.Black;
            this.tbxUsuario.Location = new System.Drawing.Point(126, 17);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(100, 24);
            this.tbxUsuario.TabIndex = 0;
            this.tbxUsuario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbxUsuario_MouseDoubleClick);
            // 
            // lblNombrePrincipal
            // 
            this.lblNombrePrincipal.AutoSize = true;
            this.lblNombrePrincipal.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePrincipal.Location = new System.Drawing.Point(192, 19);
            this.lblNombrePrincipal.Name = "lblNombrePrincipal";
            this.lblNombrePrincipal.Size = new System.Drawing.Size(179, 34);
            this.lblNombrePrincipal.TabIndex = 1;
            this.lblNombrePrincipal.Text = "FetchEmpleo";
            // 
            // checkBoxUsuario
            // 
            this.checkBoxUsuario.AutoSize = true;
            this.checkBoxUsuario.Checked = true;
            this.checkBoxUsuario.Location = new System.Drawing.Point(97, 71);
            this.checkBoxUsuario.Name = "checkBoxUsuario";
            this.checkBoxUsuario.Size = new System.Drawing.Size(86, 17);
            this.checkBoxUsuario.TabIndex = 2;
            this.checkBoxUsuario.TabStop = true;
            this.checkBoxUsuario.Text = "Demandante";
            this.checkBoxUsuario.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmpresa
            // 
            this.checkBoxEmpresa.AutoSize = true;
            this.checkBoxEmpresa.Location = new System.Drawing.Point(189, 71);
            this.checkBoxEmpresa.Name = "checkBoxEmpresa";
            this.checkBoxEmpresa.Size = new System.Drawing.Size(66, 17);
            this.checkBoxEmpresa.TabIndex = 3;
            this.checkBoxEmpresa.TabStop = true;
            this.checkBoxEmpresa.Text = "Empresa";
            this.checkBoxEmpresa.UseVisualStyleBackColor = true;
            // 
            // FormPrincipalLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(595, 412);
            this.Controls.Add(this.checkBoxEmpresa);
            this.Controls.Add(this.checkBoxUsuario);
            this.Controls.Add(this.lblNombrePrincipal);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormPrincipalLogin";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnRegistrase;
        private System.Windows.Forms.TextBox tbxContrasenya;
        private System.Windows.Forms.LinkLabel linklblEmpresas;
        private System.Windows.Forms.LinkLabel linklblOlvidado;
        private System.Windows.Forms.Label lblNombrePrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton checkBoxUsuario;
        private System.Windows.Forms.RadioButton checkBoxEmpresa;

    }
}

