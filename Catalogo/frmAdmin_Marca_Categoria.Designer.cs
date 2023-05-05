namespace Catalogo
{
	partial class frmAdmin_Marca_Categoria
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.lblMarca = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.btnModCategoria = new System.Windows.Forms.Button();
            this.btnDelCategoria = new System.Windows.Forms.Button();
            this.btnDelMarca = new System.Windows.Forms.Button();
            this.btnModMarca = new System.Windows.Forms.Button();
            this.btnAddMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(11, 25);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(257, 416);
            this.dgvMarcas.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMarca.Location = new System.Drawing.Point(9, 3);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(156, 20);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Administrar Marcas";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToOrderColumns = true;
            this.dgvCategorias.AllowUserToResizeColumns = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(272, 25);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(257, 416);
            this.dgvCategorias.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCategoria.Location = new System.Drawing.Point(268, 3);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(181, 20);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Administrar Categorias";
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddCategoria.Location = new System.Drawing.Point(272, 445);
            this.btnAddCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(70, 30);
            this.btnAddCategoria.TabIndex = 7;
            this.btnAddCategoria.Text = "Agregar";
            this.btnAddCategoria.UseVisualStyleBackColor = false;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // btnModCategoria
            // 
            this.btnModCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModCategoria.Location = new System.Drawing.Point(346, 445);
            this.btnModCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnModCategoria.Name = "btnModCategoria";
            this.btnModCategoria.Size = new System.Drawing.Size(67, 30);
            this.btnModCategoria.TabIndex = 8;
            this.btnModCategoria.Text = "Modificar";
            this.btnModCategoria.UseVisualStyleBackColor = false;
            this.btnModCategoria.Click += new System.EventHandler(this.btnModCategoria_Click);
            // 
            // btnDelCategoria
            // 
            this.btnDelCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelCategoria.Location = new System.Drawing.Point(417, 445);
            this.btnDelCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelCategoria.Name = "btnDelCategoria";
            this.btnDelCategoria.Size = new System.Drawing.Size(63, 30);
            this.btnDelCategoria.TabIndex = 9;
            this.btnDelCategoria.Text = "Eliminar";
            this.btnDelCategoria.UseVisualStyleBackColor = false;
            this.btnDelCategoria.Click += new System.EventHandler(this.btnDelCategoria_Click_1);
            // 
            // btnDelMarca
            // 
            this.btnDelMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelMarca.Location = new System.Drawing.Point(143, 445);
            this.btnDelMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelMarca.Name = "btnDelMarca";
            this.btnDelMarca.Size = new System.Drawing.Size(63, 30);
            this.btnDelMarca.TabIndex = 12;
            this.btnDelMarca.Text = "Eliminar";
            this.btnDelMarca.UseVisualStyleBackColor = false;
            this.btnDelMarca.Click += new System.EventHandler(this.btnDelMarca_Click);
            // 
            // btnModMarca
            // 
            this.btnModMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModMarca.Location = new System.Drawing.Point(78, 445);
            this.btnModMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnModMarca.Name = "btnModMarca";
            this.btnModMarca.Size = new System.Drawing.Size(61, 30);
            this.btnModMarca.TabIndex = 11;
            this.btnModMarca.Text = "Modificar";
            this.btnModMarca.UseVisualStyleBackColor = false;
            // 
            // btnAddMarca
            // 
            this.btnAddMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddMarca.Location = new System.Drawing.Point(12, 445);
            this.btnAddMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMarca.Name = "btnAddMarca";
            this.btnAddMarca.Size = new System.Drawing.Size(62, 30);
            this.btnAddMarca.TabIndex = 10;
            this.btnAddMarca.Text = "Agregar";
            this.btnAddMarca.UseVisualStyleBackColor = false;
            this.btnAddMarca.Click += new System.EventHandler(this.btnAddMarca_Click);
            // 
            // frmAdmin_Marca_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 486);
            this.Controls.Add(this.btnDelMarca);
            this.Controls.Add(this.btnModMarca);
            this.Controls.Add(this.btnAddMarca);
            this.Controls.Add(this.btnDelCategoria);
            this.Controls.Add(this.btnModCategoria);
            this.Controls.Add(this.btnAddCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmin_Marca_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas y Categorias";
            this.Load += new System.EventHandler(this.frmAdmin_Marca_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvMarcas;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.DataGridView dgvCategorias;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.Button btnAddCategoria;
		private System.Windows.Forms.Button btnModCategoria;
		private System.Windows.Forms.Button btnDelCategoria;
		private System.Windows.Forms.Button btnDelMarca;
		private System.Windows.Forms.Button btnModMarca;
		private System.Windows.Forms.Button btnAddMarca;
	}
}