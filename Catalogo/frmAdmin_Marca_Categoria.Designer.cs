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
			this.dgvMarcas.ColumnHeadersHeight = 29;
			this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvMarcas.Location = new System.Drawing.Point(15, 31);
			this.dgvMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMarcas.Name = "dgvMarcas";
			this.dgvMarcas.RowHeadersWidth = 51;
			this.dgvMarcas.RowTemplate.Height = 24;
			this.dgvMarcas.RowTemplate.ReadOnly = true;
			this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMarcas.Size = new System.Drawing.Size(343, 512);
			this.dgvMarcas.TabIndex = 0;
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.lblMarca.Location = new System.Drawing.Point(12, 4);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(197, 25);
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
			this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvCategorias.Location = new System.Drawing.Point(363, 31);
			this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvCategorias.Name = "dgvCategorias";
			this.dgvCategorias.RowHeadersWidth = 51;
			this.dgvCategorias.RowTemplate.Height = 24;
			this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCategorias.Size = new System.Drawing.Size(343, 512);
			this.dgvCategorias.TabIndex = 2;
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.lblCategoria.Location = new System.Drawing.Point(357, 4);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(230, 25);
			this.lblCategoria.TabIndex = 3;
			this.lblCategoria.Text = "Administrar Categorias";
			// 
			// btnAddCategoria
			// 
			this.btnAddCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnAddCategoria.Location = new System.Drawing.Point(363, 548);
			this.btnAddCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAddCategoria.Name = "btnAddCategoria";
			this.btnAddCategoria.Size = new System.Drawing.Size(93, 37);
			this.btnAddCategoria.TabIndex = 7;
			this.btnAddCategoria.Text = "Agregar";
			this.btnAddCategoria.UseVisualStyleBackColor = false;
			this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
			// 
			// btnModCategoria
			// 
			this.btnModCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnModCategoria.Location = new System.Drawing.Point(461, 548);
			this.btnModCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnModCategoria.Name = "btnModCategoria";
			this.btnModCategoria.Size = new System.Drawing.Size(89, 37);
			this.btnModCategoria.TabIndex = 8;
			this.btnModCategoria.Text = "Modificar";
			this.btnModCategoria.UseVisualStyleBackColor = false;
			this.btnModCategoria.Click += new System.EventHandler(this.btnModCategoria_Click);
			// 
			// btnDelCategoria
			// 
			this.btnDelCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnDelCategoria.Location = new System.Drawing.Point(556, 548);
			this.btnDelCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelCategoria.Name = "btnDelCategoria";
			this.btnDelCategoria.Size = new System.Drawing.Size(84, 37);
			this.btnDelCategoria.TabIndex = 9;
			this.btnDelCategoria.Text = "Eliminar";
			this.btnDelCategoria.UseVisualStyleBackColor = false;
			this.btnDelCategoria.Click += new System.EventHandler(this.btnDelCategoria_Click_1);
			// 
			// btnDelMarca
			// 
			this.btnDelMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnDelMarca.Location = new System.Drawing.Point(191, 548);
			this.btnDelMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelMarca.Name = "btnDelMarca";
			this.btnDelMarca.Size = new System.Drawing.Size(84, 37);
			this.btnDelMarca.TabIndex = 12;
			this.btnDelMarca.Text = "Eliminar";
			this.btnDelMarca.UseVisualStyleBackColor = false;
			this.btnDelMarca.Click += new System.EventHandler(this.btnDelMarca_Click);
			// 
			// btnModMarca
			// 
			this.btnModMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnModMarca.Location = new System.Drawing.Point(104, 548);
			this.btnModMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnModMarca.Name = "btnModMarca";
			this.btnModMarca.Size = new System.Drawing.Size(81, 37);
			this.btnModMarca.TabIndex = 11;
			this.btnModMarca.Text = "Modificar";
			this.btnModMarca.UseVisualStyleBackColor = false;
			this.btnModMarca.Click += new System.EventHandler(this.btnModMarca_Click);
			// 
			// btnAddMarca
			// 
			this.btnAddMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnAddMarca.Location = new System.Drawing.Point(16, 548);
			this.btnAddMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAddMarca.Name = "btnAddMarca";
			this.btnAddMarca.Size = new System.Drawing.Size(83, 37);
			this.btnAddMarca.TabIndex = 10;
			this.btnAddMarca.Text = "Agregar";
			this.btnAddMarca.UseVisualStyleBackColor = false;
			this.btnAddMarca.Click += new System.EventHandler(this.btnAddMarca_Click);
			// 
			// frmAdmin_Marca_Categoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 598);
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
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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