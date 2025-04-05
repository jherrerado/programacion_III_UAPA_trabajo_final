namespace YHDesign_project.View.Login
{
	partial class IniciarSesion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
			panel1 = new Panel();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			label2 = new Label();
			label3 = new Label();
			txt_user = new TextBox();
			txt_password = new TextBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			button1 = new Button();
			button2 = new Button();
			pictureBox4 = new PictureBox();
			pictureBox5 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(label1);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(464, 227);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(152, 162);
			label1.Name = "label1";
			label1.Size = new Size(141, 30);
			label1.TabIndex = 1;
			label1.Text = "Iniciar sesión";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(163, 52);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(119, 81);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(109, 266);
			label2.Name = "label2";
			label2.Size = new Size(69, 21);
			label2.TabIndex = 1;
			label2.Text = "Usuario";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(97, 364);
			label3.Name = "label3";
			label3.Size = new Size(96, 21);
			label3.TabIndex = 2;
			label3.Text = "Contraseña";
			// 
			// txt_user
			// 
			txt_user.BackColor = SystemColors.Control;
			txt_user.BorderStyle = BorderStyle.None;
			txt_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txt_user.Location = new Point(63, 293);
			txt_user.Name = "txt_user";
			txt_user.Size = new Size(326, 22);
			txt_user.TabIndex = 3;
			// 
			// txt_password
			// 
			txt_password.BackColor = SystemColors.Control;
			txt_password.BorderStyle = BorderStyle.None;
			txt_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txt_password.Location = new Point(63, 395);
			txt_password.Name = "txt_password";
			txt_password.Size = new Size(326, 22);
			txt_password.TabIndex = 4;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(63, 247);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(40, 40);
			pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox2.TabIndex = 5;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(63, 355);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(30, 30);
			pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox3.TabIndex = 6;
			pictureBox3.TabStop = false;
			// 
			// button1
			// 
			button1.BackColor = Color.Red;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(63, 463);
			button1.Name = "button1";
			button1.Size = new Size(326, 50);
			button1.TabIndex = 7;
			button1.Text = "Entrar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.FlatAppearance.BorderColor = Color.Red;
			button2.FlatAppearance.BorderSize = 2;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.Red;
			button2.Location = new Point(63, 519);
			button2.Name = "button2";
			button2.Size = new Size(326, 42);
			button2.TabIndex = 8;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(63, 321);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(326, 1);
			pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox4.TabIndex = 9;
			pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(63, 428);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(326, 1);
			pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox5.TabIndex = 10;
			pictureBox5.TabStop = false;
			// 
			// IniciarSesion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(464, 611);
			Controls.Add(pictureBox5);
			Controls.Add(pictureBox4);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(txt_password);
			Controls.Add(txt_user);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "IniciarSesion";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txt_user;
		private TextBox txt_password;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Button button1;
		private Button button2;
		private PictureBox pictureBox4;
		private PictureBox pictureBox5;
	}
}