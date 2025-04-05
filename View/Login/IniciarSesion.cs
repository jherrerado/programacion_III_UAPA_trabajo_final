using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YHDesign_project.Controller;
using YHDesign_project.View.Admin;
using YHDesign_project.View.Administrator.Finances;
using YHDesign_project.View.Administrator.Orders;

namespace YHDesign_project.View.Login
{
	public partial class IniciarSesion : Form
	{
		public IniciarSesion()
		{
			InitializeComponent();
			txt_password.PasswordChar = '*';
		}
		// -------------------------------------------------------------------------------
		private void validateUser()
		{
			FindControllers userController = new FindControllers();
			DataTable dt = userController.GetFromDB("CALL Mostrar_Usuarios();");
			if (dt != null)
			{
				foreach (DataRow row in dt.Rows)
				{
					switch (row["NOM_USU"].ToString())
					{
						case "prog":
							if (txt_user.Text == row["NOM_USU"].ToString() && txt_password.Text == row["PAS_USU"].ToString())
							{
								Administrador admin = new Administrador();
								admin.Show();

								this.Hide();
								return;
							}
							break;
						case "design":
							if (txt_user.Text == row["NOM_USU"].ToString() && txt_password.Text == row["PAS_USU"].ToString())
							{

								Diseñador diseñador = new Diseñador();
								diseñador.Show();

								this.Hide();
								return;
							}
							break;
						case "admin":
							if (txt_user.Text == row["NOM_USU"].ToString() && txt_password.Text == row["PAS_USU"].ToString())
							{
								Administrador admin = new Administrador();
								admin.Show();
								this.Hide();
								return;
							}
							break;
						case "finanzas":
							if (txt_user.Text == row["NOM_USU"].ToString() && txt_password.Text == row["PAS_USU"].ToString())
							{
								Caja caja = new Caja();
								caja.Show();
								this.Hide();
								return;
							}
							break;
					}
				}
				MessageBox.Show("Usuario o contraseña incorrecta");
			}
		}
		// -------------------------------------------------------------------------------
		[DllImport("dwmapi.dll")]
		private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		private struct MARGINS
		{
			public int leftWidth;
			public int rightWidth;
			public int topHeight;
			public int bottomHeight;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			ApplyShadow();
		}

		private void ApplyShadow()
		{
			int val = 2; // Habilita la sombra
			DwmSetWindowAttribute(this.Handle, 2, ref val, sizeof(int));

			MARGINS margins = new MARGINS() { leftWidth = 1, rightWidth = 1, topHeight = 1, bottomHeight = 1 };
			DwmExtendFrameIntoClientArea(this.Handle, ref margins);
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			validateUser();
		}
	}
}
