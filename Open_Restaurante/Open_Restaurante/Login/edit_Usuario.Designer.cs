namespace Open_Restaurante
{
    partial class edit_Usuario
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
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.lbcon = new System.Windows.Forms.Label();
            this.lbladdproducto = new System.Windows.Forms.Label();
            this.BASE = new System.Windows.Forms.Panel();
            this.IMG = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dvgusers = new System.Windows.Forms.DataGridView();
            this.FORM = new System.Windows.Forms.Panel();
            this.gbform = new System.Windows.Forms.GroupBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnseleccionarimg = new System.Windows.Forms.Button();
            this.lbuser = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.pbimagen = new System.Windows.Forms.PictureBox();
            this.lblnameproduct = new System.Windows.Forms.Label();
            this.lbldescrproduct = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paneltitulo.SuspendLayout();
            this.BASE.SuspendLayout();
            this.IMG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgusers)).BeginInit();
            this.FORM.SuspendLayout();
            this.gbform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitulo
            // 
            this.paneltitulo.Controls.Add(this.lbcon);
            this.paneltitulo.Controls.Add(this.lbladdproducto);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(1114, 88);
            this.paneltitulo.TabIndex = 4;
            // 
            // lbcon
            // 
            this.lbcon.AutoSize = true;
            this.lbcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbcon.ForeColor = System.Drawing.Color.Red;
            this.lbcon.Location = new System.Drawing.Point(368, 47);
            this.lbcon.Name = "lbcon";
            this.lbcon.Size = new System.Drawing.Size(271, 25);
            this.lbcon.TabIndex = 61;
            this.lbcon.Text = "Las contraseñas no coinciden";
            this.lbcon.Visible = false;
            // 
            // lbladdproducto
            // 
            this.lbladdproducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbladdproducto.Font = new System.Drawing.Font("Montserrat", 16F);
            this.lbladdproducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbladdproducto.Location = new System.Drawing.Point(0, 0);
            this.lbladdproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdproducto.Name = "lbladdproducto";
            this.lbladdproducto.Padding = new System.Windows.Forms.Padding(15, 25, 0, 0);
            this.lbladdproducto.Size = new System.Drawing.Size(349, 88);
            this.lbladdproducto.TabIndex = 2;
            this.lbladdproducto.Text = "Administrar Usuarios";
            this.lbladdproducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BASE
            // 
            this.BASE.AutoScroll = true;
            this.BASE.Controls.Add(this.IMG);
            this.BASE.Controls.Add(this.FORM);
            this.BASE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BASE.Location = new System.Drawing.Point(0, 88);
            this.BASE.Name = "BASE";
            this.BASE.Size = new System.Drawing.Size(1114, 523);
            this.BASE.TabIndex = 5;
            // 
            // IMG
            // 
            this.IMG.AutoScroll = true;
            this.IMG.Controls.Add(this.pictureBox1);
            this.IMG.Controls.Add(this.txtbuscar);
            this.IMG.Controls.Add(this.dvgusers);
            this.IMG.Dock = System.Windows.Forms.DockStyle.Left;
            this.IMG.Location = new System.Drawing.Point(670, 0);
            this.IMG.Name = "IMG";
            this.IMG.Size = new System.Drawing.Size(442, 523);
            this.IMG.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Open_Restaurante.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(392, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbuscar.Location = new System.Drawing.Point(29, 26);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(344, 30);
            this.txtbuscar.TabIndex = 8;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dvgusers
            // 
            this.dvgusers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dvgusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgusers.Location = new System.Drawing.Point(29, 75);
            this.dvgusers.Name = "dvgusers";
            this.dvgusers.RowHeadersWidth = 51;
            this.dvgusers.RowTemplate.Height = 24;
            this.dvgusers.Size = new System.Drawing.Size(388, 436);
            this.dvgusers.TabIndex = 7;
            this.dvgusers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgusers_CellClick);
            // 
            // FORM
            // 
            this.FORM.AutoScroll = true;
            this.FORM.Controls.Add(this.gbform);
            this.FORM.Dock = System.Windows.Forms.DockStyle.Left;
            this.FORM.Location = new System.Drawing.Point(0, 0);
            this.FORM.Name = "FORM";
            this.FORM.Size = new System.Drawing.Size(670, 523);
            this.FORM.TabIndex = 0;
            // 
            // gbform
            // 
            this.gbform.Controls.Add(this.btnactualizar);
            this.gbform.Controls.Add(this.btnseleccionarimg);
            this.gbform.Controls.Add(this.lbuser);
            this.gbform.Controls.Add(this.btneliminar);
            this.gbform.Controls.Add(this.lbtelefono);
            this.gbform.Controls.Add(this.lbemail);
            this.gbform.Controls.Add(this.lbfecha);
            this.gbform.Controls.Add(this.pbimagen);
            this.gbform.Controls.Add(this.lblnameproduct);
            this.gbform.Controls.Add(this.lbldescrproduct);
            this.gbform.Controls.Add(this.lbnombre);
            this.gbform.Controls.Add(this.label1);
            this.gbform.Controls.Add(this.label2);
            this.gbform.Location = new System.Drawing.Point(12, 3);
            this.gbform.Name = "gbform";
            this.gbform.Size = new System.Drawing.Size(652, 517);
            this.gbform.TabIndex = 60;
            this.gbform.TabStop = false;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnactualizar.Location = new System.Drawing.Point(261, 434);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(167, 34);
            this.btnactualizar.TabIndex = 70;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnseleccionarimg
            // 
            this.btnseleccionarimg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnseleccionarimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnseleccionarimg.Location = new System.Drawing.Point(444, 324);
            this.btnseleccionarimg.Name = "btnseleccionarimg";
            this.btnseleccionarimg.Size = new System.Drawing.Size(167, 34);
            this.btnseleccionarimg.TabIndex = 69;
            this.btnseleccionarimg.Text = "Cambiar Imagen";
            this.btnseleccionarimg.UseVisualStyleBackColor = true;
            this.btnseleccionarimg.Click += new System.EventHandler(this.btnseleccionarimg_Click);
            // 
            // lbuser
            // 
            this.lbuser.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lbuser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbuser.Location = new System.Drawing.Point(414, 45);
            this.lbuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(231, 27);
            this.lbuser.TabIndex = 68;
            this.lbuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btneliminar.Location = new System.Drawing.Point(444, 434);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(167, 34);
            this.btneliminar.TabIndex = 66;
            this.btneliminar.Text = "Eliminar Usuario";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lbtelefono
            // 
            this.lbtelefono.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lbtelefono.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbtelefono.Location = new System.Drawing.Point(142, 211);
            this.lbtelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(264, 33);
            this.lbtelefono.TabIndex = 65;
            // 
            // lbemail
            // 
            this.lbemail.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lbemail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbemail.Location = new System.Drawing.Point(112, 127);
            this.lbemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(294, 59);
            this.lbemail.TabIndex = 64;
            // 
            // lbfecha
            // 
            this.lbfecha.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lbfecha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbfecha.Location = new System.Drawing.Point(32, 324);
            this.lbfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(231, 27);
            this.lbfecha.TabIndex = 63;
            this.lbfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbimagen
            // 
            this.pbimagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbimagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbimagen.Image = global::Open_Restaurante.Properties.Resources.productimg;
            this.pbimagen.Location = new System.Drawing.Point(427, 112);
            this.pbimagen.Name = "pbimagen";
            this.pbimagen.Size = new System.Drawing.Size(200, 200);
            this.pbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagen.TabIndex = 0;
            this.pbimagen.TabStop = false;
            // 
            // lblnameproduct
            // 
            this.lblnameproduct.AutoSize = true;
            this.lblnameproduct.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblnameproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblnameproduct.Location = new System.Drawing.Point(32, 45);
            this.lblnameproduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnameproduct.Name = "lblnameproduct";
            this.lblnameproduct.Size = new System.Drawing.Size(110, 27);
            this.lblnameproduct.TabIndex = 39;
            this.lblnameproduct.Text = "Nombres:";
            // 
            // lbldescrproduct
            // 
            this.lbldescrproduct.AutoSize = true;
            this.lbldescrproduct.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lbldescrproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbldescrproduct.Location = new System.Drawing.Point(32, 285);
            this.lbldescrproduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescrproduct.Name = "lbldescrproduct";
            this.lbldescrproduct.Size = new System.Drawing.Size(231, 27);
            this.lbldescrproduct.TabIndex = 41;
            this.lbldescrproduct.Text = "Fecha de Nacimiento:";
            // 
            // lbnombre
            // 
            this.lbnombre.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lbnombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbnombre.Location = new System.Drawing.Point(150, 45);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(256, 52);
            this.lbnombre.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(32, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(32, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 47;
            this.label2.Text = "Telefono:";
            // 
            // edit_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1114, 611);
            this.Controls.Add(this.BASE);
            this.Controls.Add(this.paneltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "edit_Usuario";
            this.Text = "New Usuario";
            this.Load += new System.EventHandler(this.NewUsuario_Load);
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.BASE.ResumeLayout(false);
            this.IMG.ResumeLayout(false);
            this.IMG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgusers)).EndInit();
            this.FORM.ResumeLayout(false);
            this.gbform.ResumeLayout(false);
            this.gbform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label lbladdproducto;
        private System.Windows.Forms.Panel BASE;
        private System.Windows.Forms.Panel IMG;
        private System.Windows.Forms.Panel FORM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnameproduct;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbldescrproduct;
        private System.Windows.Forms.PictureBox pbimagen;
        private System.Windows.Forms.GroupBox gbform;
        private System.Windows.Forms.Label lbcon;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dvgusers;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Button btnseleccionarimg;
        private System.Windows.Forms.Button btnactualizar;
    }
}