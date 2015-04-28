namespace  FetchEmpleo
{
    partial class FormPublicarOferta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPublicarOferta));
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblPiePágina = new System.Windows.Forms.Label();
            this.pnlNombreEmpresa = new System.Windows.Forms.Panel();
            this.pbxLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.gbxPlazas = new System.Windows.Forms.GroupBox();
            this.nudNumPlazas = new System.Windows.Forms.NumericUpDown();
            this.gbxDiscapacitados = new System.Windows.Forms.GroupBox();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxRequisitos = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblInsertado = new System.Windows.Forms.Label();
            this.pnlNombreEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxPlazas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPlazas)).BeginInit();
            this.gbxDiscapacitados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(0, 0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(1084, 50);
            this.lblInfo1.TabIndex = 6;
            this.lblInfo1.Text = "Publicar Oferta";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPiePágina
            // 
            this.lblPiePágina.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPiePágina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPiePágina.Location = new System.Drawing.Point(0, 626);
            this.lblPiePágina.Name = "lblPiePágina";
            this.lblPiePágina.Size = new System.Drawing.Size(1084, 36);
            this.lblPiePágina.TabIndex = 15;
            // 
            // pnlNombreEmpresa
            // 
            this.pnlNombreEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNombreEmpresa.Controls.Add(this.pbxLogoEmpresa);
            this.pnlNombreEmpresa.Controls.Add(this.lblNombreEmpresa);
            this.pnlNombreEmpresa.Location = new System.Drawing.Point(-6, 47);
            this.pnlNombreEmpresa.Name = "pnlNombreEmpresa";
            this.pnlNombreEmpresa.Size = new System.Drawing.Size(1098, 111);
            this.pnlNombreEmpresa.TabIndex = 16;
            // 
            // pbxLogoEmpresa
            // 
            this.pbxLogoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoEmpresa.Image")));
            this.pbxLogoEmpresa.Location = new System.Drawing.Point(825, 3);
            this.pbxLogoEmpresa.Name = "pbxLogoEmpresa";
            this.pbxLogoEmpresa.Size = new System.Drawing.Size(100, 101);
            this.pbxLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoEmpresa.TabIndex = 2;
            this.pbxLogoEmpresa.TabStop = false;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(10, 10);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(757, 99);
            this.lblNombreEmpresa.TabIndex = 1;
            this.lblNombreEmpresa.Text = "MacDonalds";
            this.lblNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pbxAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1020, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Size = new System.Drawing.Size(52, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.Location = new System.Drawing.Point(942, 637);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(130, 16);
            this.lblCopyRight.TabIndex = 19;
            this.lblCopyRight.Text = "© FetchEmpleo 2015";
            // 
            // gbxPlazas
            // 
            this.gbxPlazas.Controls.Add(this.nudNumPlazas);
            this.gbxPlazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPlazas.Location = new System.Drawing.Point(853, 187);
            this.gbxPlazas.Name = "gbxPlazas";
            this.gbxPlazas.Size = new System.Drawing.Size(158, 100);
            this.gbxPlazas.TabIndex = 34;
            this.gbxPlazas.TabStop = false;
            this.gbxPlazas.Text = "Nº de plazas";
            // 
            // nudNumPlazas
            // 
            this.nudNumPlazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumPlazas.Location = new System.Drawing.Point(55, 42);
            this.nudNumPlazas.Name = "nudNumPlazas";
            this.nudNumPlazas.Size = new System.Drawing.Size(44, 31);
            this.nudNumPlazas.TabIndex = 0;
            // 
            // gbxDiscapacitados
            // 
            this.gbxDiscapacitados.Controls.Add(this.rbtnNo);
            this.gbxDiscapacitados.Controls.Add(this.rbtnSi);
            this.gbxDiscapacitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDiscapacitados.Location = new System.Drawing.Point(620, 187);
            this.gbxDiscapacitados.Name = "gbxDiscapacitados";
            this.gbxDiscapacitados.Size = new System.Drawing.Size(200, 100);
            this.gbxDiscapacitados.TabIndex = 33;
            this.gbxDiscapacitados.TabStop = false;
            this.gbxDiscapacitados.Text = "Discapacitados";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Checked = true;
            this.rbtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNo.Location = new System.Drawing.Point(108, 46);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(47, 24);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSi.Location = new System.Drawing.Point(22, 49);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(41, 24);
            this.rbtnSi.TabIndex = 0;
            this.rbtnSi.Text = "Sí";
            this.rbtnSi.UseVisualStyleBackColor = true;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(425, 340);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescripcion.Size = new System.Drawing.Size(640, 269);
            this.tbxDescripcion.TabIndex = 32;
            // 
            // tbxRequisitos
            // 
            this.tbxRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRequisitos.Location = new System.Drawing.Point(18, 340);
            this.tbxRequisitos.Multiline = true;
            this.tbxRequisitos.Name = "tbxRequisitos";
            this.tbxRequisitos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRequisitos.Size = new System.Drawing.Size(361, 269);
            this.tbxRequisitos.TabIndex = 31;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(420, 298);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(136, 25);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitos.Location = new System.Drawing.Point(65, 298);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(123, 25);
            this.lblRequisitos.TabIndex = 29;
            this.lblRequisitos.Text = "Requisitos";
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitulo.Location = new System.Drawing.Point(70, 229);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(431, 29);
            this.tbxTitulo.TabIndex = 28;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(65, 187);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 25);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Titulo";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(40, 628);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(226, 34);
            this.btnAplicar.TabIndex = 35;
            this.btnAplicar.Text = "Publicar oferta";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lblInsertado
            // 
            this.lblInsertado.AutoSize = true;
            this.lblInsertado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblInsertado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertado.Location = new System.Drawing.Point(374, 633);
            this.lblInsertado.Name = "lblInsertado";
            this.lblInsertado.Size = new System.Drawing.Size(0, 24);
            this.lblInsertado.TabIndex = 36;
            // 
            // FormPublicarOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.Controls.Add(this.lblInsertado);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.gbxPlazas);
            this.Controls.Add(this.gbxDiscapacitados);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxRequisitos);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblRequisitos);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlNombreEmpresa);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblPiePágina);
            this.Controls.Add(this.lblInfo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPublicarOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPublicarOferta";
            this.pnlNombreEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxPlazas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPlazas)).EndInit();
            this.gbxDiscapacitados.ResumeLayout(false);
            this.gbxDiscapacitados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblPiePágina;
        private System.Windows.Forms.Panel pnlNombreEmpresa;
        private System.Windows.Forms.PictureBox pbxLogoEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.GroupBox gbxPlazas;
        private System.Windows.Forms.NumericUpDown nudNumPlazas;
        private System.Windows.Forms.GroupBox gbxDiscapacitados;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxRequisitos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnSi;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label lblInsertado;
    }
}