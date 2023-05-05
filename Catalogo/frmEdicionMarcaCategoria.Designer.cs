namespace Catalogo
{
	partial class frmEdicionMarcaCategoria
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
            this.txtAddDescripcion = new System.Windows.Forms.TextBox();
            this.lblAddMarca_Descripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddDescripcion
            // 
            this.txtAddDescripcion.Location = new System.Drawing.Point(80, 32);
            this.txtAddDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddDescripcion.Name = "txtAddDescripcion";
            this.txtAddDescripcion.Size = new System.Drawing.Size(152, 20);
            this.txtAddDescripcion.TabIndex = 1;
            // 
            // lblAddMarca_Descripcion
            // 
            this.lblAddMarca_Descripcion.AutoSize = true;
            this.lblAddMarca_Descripcion.Location = new System.Drawing.Point(16, 37);
            this.lblAddMarca_Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddMarca_Descripcion.Name = "lblAddMarca_Descripcion";
            this.lblAddMarca_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lblAddMarca_Descripcion.TabIndex = 3;
            this.lblAddMarca_Descripcion.Text = "Descripcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.Location = new System.Drawing.Point(11, 86);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 37);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(154, 86);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEdicionMarcaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(248, 133);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAddMarca_Descripcion);
            this.Controls.Add(this.txtAddDescripcion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEdicionMarcaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtAddDescripcion;
		private System.Windows.Forms.Label lblAddMarca_Descripcion;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
	}
}