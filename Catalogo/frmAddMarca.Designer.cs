namespace Catalogo
{
	partial class frmAddMarca
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
			this.txtAddDescripcion.Location = new System.Drawing.Point(106, 39);
			this.txtAddDescripcion.Name = "txtAddDescripcion";
			this.txtAddDescripcion.Size = new System.Drawing.Size(201, 22);
			this.txtAddDescripcion.TabIndex = 1;
			// 
			// lblAddMarca_Descripcion
			// 
			this.lblAddMarca_Descripcion.AutoSize = true;
			this.lblAddMarca_Descripcion.Location = new System.Drawing.Point(21, 46);
			this.lblAddMarca_Descripcion.Name = "lblAddMarca_Descripcion";
			this.lblAddMarca_Descripcion.Size = new System.Drawing.Size(79, 16);
			this.lblAddMarca_Descripcion.TabIndex = 3;
			this.lblAddMarca_Descripcion.Text = "Descripcion";
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAceptar.Location = new System.Drawing.Point(15, 106);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(101, 46);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(206, 106);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(101, 46);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// frmAddMarca
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(331, 164);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblAddMarca_Descripcion);
			this.Controls.Add(this.txtAddDescripcion);
			this.Name = "frmAddMarca";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Marca";
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