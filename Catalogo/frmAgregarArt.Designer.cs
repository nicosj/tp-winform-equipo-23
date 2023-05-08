﻿namespace Catalogo
{
    partial class frmAgregarArt
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
            this.lbAgrCod = new System.Windows.Forms.Label();
            this.lbAgrNom = new System.Windows.Forms.Label();
            this.lbAgrDescripcion = new System.Windows.Forms.Label();
            this.lbAgrMarca = new System.Windows.Forms.Label();
            this.lbAgrCategoria = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAgrPrecio = new System.Windows.Forms.Label();
            this.txtAgrCodigo = new System.Windows.Forms.TextBox();
            this.txtAgrNombre = new System.Windows.Forms.TextBox();
            this.txtAgrDescripcion = new System.Windows.Forms.TextBox();
            this.txtAgrImagen = new System.Windows.Forms.TextBox();
            this.txtAgrPrecio = new System.Windows.Forms.TextBox();
            this.lbAgrArt = new System.Windows.Forms.Label();
            this.cbxAgrMarca = new System.Windows.Forms.ComboBox();
            this.cbxAgrCategoria = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtAgrId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAgrCod
            // 
            this.lbAgrCod.AutoSize = true;
            this.lbAgrCod.Location = new System.Drawing.Point(43, 59);
            this.lbAgrCod.Name = "lbAgrCod";
            this.lbAgrCod.Size = new System.Drawing.Size(43, 13);
            this.lbAgrCod.TabIndex = 0;
            this.lbAgrCod.Text = "Código:";
            // 
            // lbAgrNom
            // 
            this.lbAgrNom.AutoSize = true;
            this.lbAgrNom.Location = new System.Drawing.Point(39, 92);
            this.lbAgrNom.Name = "lbAgrNom";
            this.lbAgrNom.Size = new System.Drawing.Size(47, 13);
            this.lbAgrNom.TabIndex = 1;
            this.lbAgrNom.Text = "Nombre:";
            // 
            // lbAgrDescripcion
            // 
            this.lbAgrDescripcion.AutoSize = true;
            this.lbAgrDescripcion.Location = new System.Drawing.Point(20, 133);
            this.lbAgrDescripcion.Name = "lbAgrDescripcion";
            this.lbAgrDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbAgrDescripcion.TabIndex = 2;
            this.lbAgrDescripcion.Text = "Descripcion:";
            // 
            // lbAgrMarca
            // 
            this.lbAgrMarca.AutoSize = true;
            this.lbAgrMarca.Location = new System.Drawing.Point(46, 174);
            this.lbAgrMarca.Name = "lbAgrMarca";
            this.lbAgrMarca.Size = new System.Drawing.Size(40, 13);
            this.lbAgrMarca.TabIndex = 3;
            this.lbAgrMarca.Text = "Marca:";
            // 
            // lbAgrCategoria
            // 
            this.lbAgrCategoria.AutoSize = true;
            this.lbAgrCategoria.Location = new System.Drawing.Point(31, 213);
            this.lbAgrCategoria.Name = "lbAgrCategoria";
            this.lbAgrCategoria.Size = new System.Drawing.Size(55, 13);
            this.lbAgrCategoria.TabIndex = 4;
            this.lbAgrCategoria.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Imagen:";
            // 
            // lbAgrPrecio
            // 
            this.lbAgrPrecio.AutoSize = true;
            this.lbAgrPrecio.Location = new System.Drawing.Point(46, 291);
            this.lbAgrPrecio.Name = "lbAgrPrecio";
            this.lbAgrPrecio.Size = new System.Drawing.Size(40, 13);
            this.lbAgrPrecio.TabIndex = 6;
            this.lbAgrPrecio.Text = "Precio:";
            // 
            // txtAgrCodigo
            // 
            this.txtAgrCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgrCodigo.Location = new System.Drawing.Point(92, 56);
            this.txtAgrCodigo.Name = "txtAgrCodigo";
            this.txtAgrCodigo.Size = new System.Drawing.Size(85, 20);
            this.txtAgrCodigo.TabIndex = 7;
            // 
            // txtAgrNombre
            // 
            this.txtAgrNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgrNombre.Location = new System.Drawing.Point(92, 89);
            this.txtAgrNombre.Name = "txtAgrNombre";
            this.txtAgrNombre.Size = new System.Drawing.Size(150, 20);
            this.txtAgrNombre.TabIndex = 8;
            // 
            // txtAgrDescripcion
            // 
            this.txtAgrDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgrDescripcion.Location = new System.Drawing.Point(92, 130);
            this.txtAgrDescripcion.Name = "txtAgrDescripcion";
            this.txtAgrDescripcion.Size = new System.Drawing.Size(181, 20);
            this.txtAgrDescripcion.TabIndex = 9;
            // 
            // txtAgrImagen
            // 
            this.txtAgrImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgrImagen.Location = new System.Drawing.Point(92, 251);
            this.txtAgrImagen.Name = "txtAgrImagen";
            this.txtAgrImagen.Size = new System.Drawing.Size(181, 20);
            this.txtAgrImagen.TabIndex = 12;
            // 
            // txtAgrPrecio
            // 
            this.txtAgrPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgrPrecio.Location = new System.Drawing.Point(92, 288);
            this.txtAgrPrecio.Name = "txtAgrPrecio";
            this.txtAgrPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtAgrPrecio.TabIndex = 13;
            // 
            // lbAgrArt
            // 
            this.lbAgrArt.AutoSize = true;
            this.lbAgrArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbAgrArt.Location = new System.Drawing.Point(12, 9);
            this.lbAgrArt.Name = "lbAgrArt";
            this.lbAgrArt.Size = new System.Drawing.Size(113, 31);
            this.lbAgrArt.TabIndex = 14;
            this.lbAgrArt.Text = "Artículo:";
            // 
            // cbxAgrMarca
            // 
            this.cbxAgrMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAgrMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAgrMarca.FormattingEnabled = true;
            this.cbxAgrMarca.Location = new System.Drawing.Point(92, 171);
            this.cbxAgrMarca.Name = "cbxAgrMarca";
            this.cbxAgrMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxAgrMarca.TabIndex = 15;
            // 
            // cbxAgrCategoria
            // 
            this.cbxAgrCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAgrCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAgrCategoria.FormattingEnabled = true;
            this.cbxAgrCategoria.Location = new System.Drawing.Point(92, 210);
            this.cbxAgrCategoria.Name = "cbxAgrCategoria";
            this.cbxAgrCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxAgrCategoria.TabIndex = 16;
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.Location = new System.Drawing.Point(138, 361);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 17;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptarArt_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(231, 361);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 18;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtAgrId
            // 
            this.txtAgrId.Location = new System.Drawing.Point(3, 368);
            this.txtAgrId.Name = "txtAgrId";
            this.txtAgrId.Size = new System.Drawing.Size(44, 20);
            this.txtAgrId.TabIndex = 19;
            this.txtAgrId.Visible = false;
            // 
            // frmAgregarArt
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(338, 400);
            this.Controls.Add(this.txtAgrId);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbxAgrCategoria);
            this.Controls.Add(this.cbxAgrMarca);
            this.Controls.Add(this.lbAgrArt);
            this.Controls.Add(this.txtAgrPrecio);
            this.Controls.Add(this.txtAgrImagen);
            this.Controls.Add(this.txtAgrDescripcion);
            this.Controls.Add(this.txtAgrNombre);
            this.Controls.Add(this.txtAgrCodigo);
            this.Controls.Add(this.lbAgrPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbAgrCategoria);
            this.Controls.Add(this.lbAgrMarca);
            this.Controls.Add(this.lbAgrDescripcion);
            this.Controls.Add(this.lbAgrNom);
            this.Controls.Add(this.lbAgrCod);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(753, 439);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(354, 439);
            this.Name = "frmAgregarArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarArt";
            this.Load += new System.EventHandler(this.frmAgregarArt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAgrId;

        #endregion

        private System.Windows.Forms.Label lbAgrCod;
        private System.Windows.Forms.Label lbAgrNom;
        private System.Windows.Forms.Label lbAgrDescripcion;
        private System.Windows.Forms.Label lbAgrMarca;
        private System.Windows.Forms.Label lbAgrCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAgrPrecio;
        private System.Windows.Forms.TextBox txtAgrCodigo;
        private System.Windows.Forms.TextBox txtAgrNombre;
        private System.Windows.Forms.TextBox txtAgrDescripcion;
        private System.Windows.Forms.TextBox txtAgrImagen;
        private System.Windows.Forms.TextBox txtAgrPrecio;
        private System.Windows.Forms.Label lbAgrArt;
        private System.Windows.Forms.ComboBox cbxAgrMarca;
        private System.Windows.Forms.ComboBox cbxAgrCategoria;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
    }
}