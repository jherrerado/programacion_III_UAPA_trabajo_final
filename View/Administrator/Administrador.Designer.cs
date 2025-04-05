namespace YHDesign_project.View.Admin
{
	partial class Administrador
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
			panel1 = new Panel();
			panel3 = new Panel();
			btn_pedidos = new Button();
			btn_finanzas = new Button();
			btn_salir = new Button();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			lbl_title = new Label();
			pn_container = new Panel();
			toolTip1 = new ToolTip(components);
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Black;
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(btn_salir);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(106, 761);
			panel1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(btn_pedidos);
			panel3.Controls.Add(btn_finanzas);
			panel3.Location = new Point(0, 116);
			panel3.Name = "panel3";
			panel3.Size = new Size(106, 460);
			panel3.TabIndex = 2;
			// 
			// btn_pedidos
			// 
			btn_pedidos.Dock = DockStyle.Top;
			btn_pedidos.FlatStyle = FlatStyle.Flat;
			btn_pedidos.Image = (Image)resources.GetObject("btn_pedidos.Image");
			btn_pedidos.Location = new Point(0, 74);
			btn_pedidos.Name = "btn_pedidos";
			btn_pedidos.Size = new Size(106, 78);
			btn_pedidos.TabIndex = 4;
			toolTip1.SetToolTip(btn_pedidos, "Pedidos");
			btn_pedidos.UseVisualStyleBackColor = true;
			btn_pedidos.Click += btn_pedidos_Click;
			// 
			// btn_finanzas
			// 
			btn_finanzas.Dock = DockStyle.Top;
			btn_finanzas.FlatStyle = FlatStyle.Flat;
			btn_finanzas.Image = (Image)resources.GetObject("btn_finanzas.Image");
			btn_finanzas.Location = new Point(0, 0);
			btn_finanzas.Name = "btn_finanzas";
			btn_finanzas.Size = new Size(106, 74);
			btn_finanzas.TabIndex = 3;
			toolTip1.SetToolTip(btn_finanzas, "Finanzas");
			btn_finanzas.UseVisualStyleBackColor = true;
			btn_finanzas.Click += button2_Click;
			// 
			// btn_salir
			// 
			btn_salir.Dock = DockStyle.Bottom;
			btn_salir.FlatStyle = FlatStyle.Flat;
			btn_salir.Image = (Image)resources.GetObject("btn_salir.Image");
			btn_salir.Location = new Point(0, 680);
			btn_salir.Name = "btn_salir";
			btn_salir.Size = new Size(106, 81);
			btn_salir.TabIndex = 2;
			toolTip1.SetToolTip(btn_salir, "Salir");
			btn_salir.UseVisualStyleBackColor = true;
			btn_salir.Click += btn_salir_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(6, 33);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(100, 50);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.Anchor = AnchorStyles.None;
			panel2.BackColor = Color.Red;
			panel2.Controls.Add(lbl_title);
			panel2.Location = new Point(106, 25);
			panel2.Name = "panel2";
			panel2.Size = new Size(1282, 85);
			panel2.TabIndex = 1;
			// 
			// lbl_title
			// 
			lbl_title.AutoSize = true;
			lbl_title.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_title.ForeColor = Color.White;
			lbl_title.Location = new Point(33, 25);
			lbl_title.Name = "lbl_title";
			lbl_title.Size = new Size(155, 30);
			lbl_title.TabIndex = 2;
			lbl_title.Text = "Administrador";
			// 
			// pn_container
			// 
			pn_container.Location = new Point(106, 109);
			pn_container.Name = "pn_container";
			pn_container.Size = new Size(1282, 652);
			pn_container.TabIndex = 2;
			// 
			// Administrador
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1384, 761);
			Controls.Add(pn_container);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Administrador";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Admin";
			panel1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Panel panel2;
		private Panel panel3;
		private Button btn_pedidos;
		private Button btn_finanzas;
		private Button btn_salir;
		private Label lbl_title;
		private Panel pn_container;
		private ToolTip toolTip1;
	}
}