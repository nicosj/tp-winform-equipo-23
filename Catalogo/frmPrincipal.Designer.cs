namespace Catalogo
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
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbVistaPrevia = new System.Windows.Forms.Label();
            this.btFiltro = new System.Windows.Forms.Button();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 74);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(632, 287);
            this.dgvArticulos.TabIndex = 0;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(12, 388);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 50);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 388);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 50);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(420, 388);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(61, 50);
            this.pbxArticulo.TabIndex = 3;
            this.pbxArticulo.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(173, 388);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 50);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Artículo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbVistaPrevia
            // 
            this.lbVistaPrevia.AutoSize = true;
            this.lbVistaPrevia.Location = new System.Drawing.Point(349, 407);
            this.lbVistaPrevia.Name = "lbVistaPrevia";
            this.lbVistaPrevia.Size = new System.Drawing.Size(66, 13);
            this.lbVistaPrevia.TabIndex = 5;
            this.lbVistaPrevia.Text = "Vista Previa:";
            // 
            // btFiltro
            // 
            this.btFiltro.Location = new System.Drawing.Point(153, 41);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(44, 23);
            this.btFiltro.TabIndex = 6;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(9, 46);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(32, 13);
            this.lbFiltro.TabIndex = 7;
            this.lbFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(47, 43);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 8;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(656, 451);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.lbVistaPrevia);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo PRG 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvArticulos;


        #endregion

        private System.Windows.Forms.Button btAgregar;
				private System.Windows.Forms.Button btnModificar;
				private System.Windows.Forms.PictureBox pbxArticulo;
		private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbVistaPrevia;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}