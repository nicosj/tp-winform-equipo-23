using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using ConexionDB;
using negocio;
//push test
namespace Catalogo
{
		public partial class frmAgregarArt : Form
		{
				private Articulo articulo = null;
				private int borderSize = 2;
				private Size formSize;
				public frmAgregarArt()
				{

						InitializeComponent();
						Text = "Agregar Articulo";

				}

				//constructor sobrecargado para usar la misma ventana para agregar y modificar//
				public frmAgregarArt(Articulo articulo)
				{
						InitializeComponent();
						this.articulo = articulo;
						Text = "Modificar Articulo";
				}

				private void btCancelar_Click(object sender, EventArgs e)
				{
						Close();
				}

				private void btAceptarArt_Click(object sender, EventArgs e)
				{
						//Articulo articulo = new Articulo();
						DB dB = new DB();
						try
						{
								if(articulo == null)
								{
										articulo = new Articulo();
								}
								articulo.Codigo = txtAgrCodigo.Text;
								articulo.Nombre = txtAgrNombre.Text;
								articulo.Descripcion = txtAgrDescripcion.Text;
								articulo.IdMarca = (int)cbxAgrMarca.SelectedValue;
								articulo.IdCategoria = (int)cbxAgrCategoria.SelectedValue;
								//Imagen aux = new Imagen();
								//aux.ImagenUrl = (string)lector["UrlImagen"];
								articulo.Precio = decimal.Parse(txtAgrPrecio.Text);

								//TODO: Pasar MODIF Y AGR esto a funciones y ponerle try y catchsss
								if (articulo.Id != 0)
								{//MODIFICAR
										dB.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @idMarca, IdCategoria = @idCategoria , Precio = @precio WHERE Id = @id");
										dB.setearParametro("@codigo", articulo.Codigo);
										dB.setearParametro("@nombre", articulo.Nombre);
										dB.setearParametro("@desc", articulo.Descripcion);
										dB.setearParametro("@idMarca", articulo.IdMarca);
										dB.setearParametro("@idCategoria", articulo.IdCategoria);
										dB.setearParametro("@precio", articulo.Precio);
										dB.setearParametro("@id", articulo.Id);

										dB.ejecutarLectura();


										MessageBox.Show("Articulo modificado con exito");

								}
								else
								{//AGREGAR
										dB.setearConsulta("INSERT into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) values ('" + articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Descripcion + "'," + articulo.IdMarca + "," + articulo.IdCategoria + "," + articulo.Precio + ")");
										dB.ejecutarLectura();
										MessageBox.Show("Articulo agregado con exito");
								}

						}
						catch (Exception ex)
						{

								MessageBox.Show(ex.ToString());
						}
				}

				private void frmAgregarArt_Load(object sender, EventArgs e)
				{
						NegocioMarca negocioMarca = new NegocioMarca();
						NegocioCategoria negocioCategoria = new NegocioCategoria();
						try
						{
								cbxAgrMarca.DataSource = negocioMarca.listar();
								cbxAgrMarca.ValueMember = "Id";
								cbxAgrMarca.DisplayMember	= "Descripcion";
								cbxAgrCategoria.DataSource = negocioCategoria.listar();
								cbxAgrCategoria.ValueMember = "Id";
								cbxAgrCategoria.DisplayMember	= "Descripcion";

								if(articulo != null)
								{
										txtAgrCodigo.Text = articulo.Codigo;
										txtAgrNombre.Text = articulo.Nombre;
										txtAgrDescripcion.Text = articulo.Descripcion;
										cbxAgrMarca.SelectedValue = articulo.IdMarca;
										cbxAgrCategoria.SelectedValue = articulo.IdCategoria;												
										txtAgrPrecio.Text = articulo.Precio.ToString();
								}
						}
						catch (Exception ex)
						{

								MessageBox.Show(ex.ToString());
						}
				}
				
				protected override void WndProc(ref Message m)
    {
        const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
        const int WM_SYSCOMMAND = 0x0112; 
        const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
        const int SC_RESTORE = 0xF120; //Restore form (Before)
        const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
        const int resizeAreaSize = 10;

        #region Form Resize
        // Resize/WM_NCHITTEST values
        const int HTCLIENT = 1; //Represents the client area of the window
        const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
        const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
        const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
        const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
        const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
        const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
        const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
        const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

        ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

        if (m.Msg == WM_NCHITTEST)
        { //If the windows m is WM_NCHITTEST
            base.WndProc(ref m);
            if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
            {
                if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                {
                    Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                    Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                    if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                    {
                        if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                            m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                        else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                            m.Result = (IntPtr)HTTOP; //Resize vertically up
                        else //Resize diagonally to the right
                            m.Result = (IntPtr)HTTOPRIGHT;
                    }
                    else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                    {
                        if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                            m.Result = (IntPtr)HTLEFT;
                        else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                            m.Result = (IntPtr)HTRIGHT;
                    }
                    else
                    {
                        if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                            m.Result = (IntPtr)HTBOTTOM;
                        else //Resize diagonally to the right
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                    }
                }
            }
            return;
        }
        #endregion

        //Remove border and keep snap window
        if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        {
            return;
        }

        //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
        if (m.Msg == WM_SYSCOMMAND)
        {
            /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
            /// Quote:
            /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
            /// are used internally by the system.To obtain the correct result when testing 
            /// the value of wParam, an application must combine the value 0xFFF0 with the 
            /// wParam value by using the bitwise AND operator.
            int wParam = (m.WParam.ToInt32() & 0xFFF0);               

            if (wParam == SC_MINIMIZE)  //Before
                formSize = this.ClientSize;
            if (wParam == SC_RESTORE)// Restored form(Before)
                this.Size = formSize;
        }
        base.WndProc(ref m);
    }
				
				
		}
		
}