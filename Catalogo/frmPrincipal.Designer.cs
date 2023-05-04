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
						this.dataGridView1 = new System.Windows.Forms.DataGridView();
						this.btAgregar = new System.Windows.Forms.Button();
						this.btnModificar = new System.Windows.Forms.Button();
						this.pbxArticulo = new System.Windows.Forms.PictureBox();
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
						((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
						this.SuspendLayout();
						// 
						// dataGridView1
						// 
						this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
						this.dataGridView1.Location = new System.Drawing.Point(16, 13);
						this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
						this.dataGridView1.Name = "dataGridView1";
						this.dataGridView1.RowHeadersWidth = 51;
						this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
						this.dataGridView1.Size = new System.Drawing.Size(845, 256);
						this.dataGridView1.TabIndex = 0;
						// 
						// btAgregar
						// 
						this.btAgregar.Location = new System.Drawing.Point(16, 511);
						this.btAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
						this.btAgregar.Name = "btAgregar";
						this.btAgregar.Size = new System.Drawing.Size(100, 28);
						this.btAgregar.TabIndex = 1;
						this.btAgregar.Text = "Agregar";
						this.btAgregar.UseVisualStyleBackColor = true;
						this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
						// 
						// btnModificar
						// 
						this.btnModificar.Location = new System.Drawing.Point(124, 511);
						this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
						this.btnModificar.Name = "btnModificar";
						this.btnModificar.Size = new System.Drawing.Size(100, 28);
						this.btnModificar.TabIndex = 2;
						this.btnModificar.Text = "Modificar";
						this.btnModificar.UseVisualStyleBackColor = true;
						this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
						// 
						// pbxArticulo
						// 
						this.pbxArticulo.Location = new System.Drawing.Point(578, 276);
						this.pbxArticulo.Name = "pbxArticulo";
						this.pbxArticulo.Size = new System.Drawing.Size(283, 239);
						this.pbxArticulo.TabIndex = 3;
						this.pbxArticulo.TabStop = false;
						// 
						// frmPrincipal
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.SystemColors.ControlLight;
						this.ClientSize = new System.Drawing.Size(874, 555);
						this.Controls.Add(this.pbxArticulo);
						this.Controls.Add(this.btnModificar);
						this.Controls.Add(this.btAgregar);
						this.Controls.Add(this.dataGridView1);
						this.Location = new System.Drawing.Point(15, 15);
						this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
						this.Name = "frmPrincipal";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "Catálogo PRG 3";
						this.Load += new System.EventHandler(this.Form1_Load);
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
						this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView1;


        #endregion

        private System.Windows.Forms.Button btAgregar;
				private System.Windows.Forms.Button btnModificar;
				private System.Windows.Forms.PictureBox pbxArticulo;
		}
}