﻿namespace Catalogo
{
    partial class frmPrincipal
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
			this.dgvArticulos = new System.Windows.Forms.DataGridView();
			this.btAgregar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.lbFiltro = new System.Windows.Forms.Label();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.btnAdministrarMyC = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtDetallesDescripcion = new System.Windows.Forms.TextBox();
			this.txtDetalleCategoria = new System.Windows.Forms.TextBox();
			this.txtDetalleMarca = new System.Windows.Forms.TextBox();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.labelDetalle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvArticulos
			// 
			this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvArticulos.ColumnHeadersHeight = 29;
			this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvArticulos.Location = new System.Drawing.Point(16, 91);
			this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvArticulos.MultiSelect = false;
			this.dgvArticulos.Name = "dgvArticulos";
			this.dgvArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvArticulos.Size = new System.Drawing.Size(404, 353);
			this.dgvArticulos.TabIndex = 0;
			this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.imagenLoad);
			// 
			// btAgregar
			// 
			this.btAgregar.Location = new System.Drawing.Point(16, 478);
			this.btAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.btAgregar.Name = "btAgregar";
			this.btAgregar.Size = new System.Drawing.Size(100, 62);
			this.btAgregar.TabIndex = 1;
			this.btAgregar.Text = "Agregar";
			this.btAgregar.UseVisualStyleBackColor = true;
			this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(124, 478);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(100, 62);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
			this.btnEliminar.Location = new System.Drawing.Point(231, 478);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(189, 62);
			this.btnEliminar.TabIndex = 4;
			this.btnEliminar.Text = "Eliminar Artículo";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// lbFiltro
			// 
			this.lbFiltro.AutoSize = true;
			this.lbFiltro.Location = new System.Drawing.Point(12, 35);
			this.lbFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbFiltro.Name = "lbFiltro";
			this.lbFiltro.Size = new System.Drawing.Size(52, 16);
			this.lbFiltro.TabIndex = 7;
			this.lbFiltro.Text = "Buscar:";
			// 
			// txtFiltro
			// 
			this.txtFiltro.Location = new System.Drawing.Point(72, 32);
			this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(348, 22);
			this.txtFiltro.TabIndex = 8;
			this.txtFiltro.TextChanged += new System.EventHandler(this.btFiltro_Click);
			// 
			// btnAdministrarMyC
			// 
			this.btnAdministrarMyC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAdministrarMyC.Location = new System.Drawing.Point(459, 493);
			this.btnAdministrarMyC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdministrarMyC.Name = "btnAdministrarMyC";
			this.btnAdministrarMyC.Size = new System.Drawing.Size(229, 33);
			this.btnAdministrarMyC.TabIndex = 9;
			this.btnAdministrarMyC.Text = "Administrar Marcas y Categorias";
			this.btnAdministrarMyC.UseVisualStyleBackColor = false;
			this.btnAdministrarMyC.Click += new System.EventHandler(this.btnAdministrarMyC_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Location = new System.Drawing.Point(488, 91);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(164, 191);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(433, 181);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(47, 31);
			this.button1.TabIndex = 11;
			this.button1.Text = "<-";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Previous_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(660, 181);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(47, 31);
			this.button2.TabIndex = 12;
			this.button2.Text = "->";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Next_Click);
			// 
			// txtDetallesDescripcion
			// 
			this.txtDetallesDescripcion.Location = new System.Drawing.Point(488, 404);
			this.txtDetallesDescripcion.Multiline = true;
			this.txtDetallesDescripcion.Name = "txtDetallesDescripcion";
			this.txtDetallesDescripcion.ReadOnly = true;
			this.txtDetallesDescripcion.Size = new System.Drawing.Size(164, 40);
			this.txtDetallesDescripcion.TabIndex = 13;
			// 
			// txtDetalleCategoria
			// 
			this.txtDetalleCategoria.Location = new System.Drawing.Point(488, 355);
			this.txtDetalleCategoria.Name = "txtDetalleCategoria";
			this.txtDetalleCategoria.ReadOnly = true;
			this.txtDetalleCategoria.Size = new System.Drawing.Size(164, 22);
			this.txtDetalleCategoria.TabIndex = 14;
			// 
			// txtDetalleMarca
			// 
			this.txtDetalleMarca.Location = new System.Drawing.Point(488, 311);
			this.txtDetalleMarca.Name = "txtDetalleMarca";
			this.txtDetalleMarca.ReadOnly = true;
			this.txtDetalleMarca.Size = new System.Drawing.Size(164, 22);
			this.txtDetalleMarca.TabIndex = 15;
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(485, 291);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(45, 16);
			this.lblMarca.TabIndex = 16;
			this.lblMarca.Text = "Marca";
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(485, 336);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(66, 16);
			this.lblCategoria.TabIndex = 17;
			this.lblCategoria.Text = "Categoria";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(488, 372);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 18;
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Location = new System.Drawing.Point(485, 385);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
			this.lblDescripcion.TabIndex = 19;
			this.lblDescripcion.Text = "Descripcion";
			// 
			// labelDetalle
			// 
			this.labelDetalle.AutoSize = true;
			this.labelDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDetalle.Location = new System.Drawing.Point(530, 67);
			this.labelDetalle.Name = "labelDetalle";
			this.labelDetalle.Size = new System.Drawing.Size(71, 20);
			this.labelDetalle.TabIndex = 20;
			this.labelDetalle.Text = "Detalles";
			this.labelDetalle.Click += new System.EventHandler(this.label2_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(726, 551);
			this.Controls.Add(this.labelDetalle);
			this.Controls.Add(this.lblDescripcion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.txtDetalleMarca);
			this.Controls.Add(this.txtDetalleCategoria);
			this.Controls.Add(this.txtDetallesDescripcion);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnAdministrarMyC);
			this.Controls.Add(this.txtFiltro);
			this.Controls.Add(this.lbFiltro);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btAgregar);
			this.Controls.Add(this.dgvArticulos);
			this.Location = new System.Drawing.Point(15, 15);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Catálogo PRG 3";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.DataGridView dgvArticulos;


        #endregion

        private System.Windows.Forms.Button btAgregar;
				private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.Button btnAdministrarMyC;
		private System.Windows.Forms.TextBox txtDetallesDescripcion;
		private System.Windows.Forms.TextBox txtDetalleCategoria;
		private System.Windows.Forms.TextBox txtDetalleMarca;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.Label labelDetalle;
	}
}