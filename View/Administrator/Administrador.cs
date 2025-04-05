using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YHDesign_project.View.Admin.Finances;
using YHDesign_project.View.Login;
using YHDesign_project.View.Administrator.Orders;
using System.Runtime.InteropServices;

namespace YHDesign_project.View.Admin
{
	public partial class Administrador : Form
	{
		public Administrador()
		{
			InitializeComponent();
			FillUserControl(new Finanzas());
		}


		// --------------------------------------------------------------------
		public void FillUserControl(UserControl userControl)
		{
			pn_container.Controls.Clear();
			pn_container.Controls.Add(userControl);
			pn_container.Tag = userControl;
			userControl.Dock = DockStyle.Fill;
			userControl.BringToFront();
			userControl.Show();
		}

		// --------------------------------------------------------------------

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

		private void button2_Click(object sender, EventArgs e)
		{
			FillUserControl(new Finanzas());
		}

		private void btn_salir_Click(object sender, EventArgs e)
		{
			this.Hide();
			IniciarSesion login = new IniciarSesion();
			login.Show();
		}

		private void btn_pedidos_Click(object sender, EventArgs e)
		{
			FillUserControl(new Pedidos());
		}
	}
}
