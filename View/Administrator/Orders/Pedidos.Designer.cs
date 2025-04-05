namespace YHDesign_project.View.Administrator.Orders
{
	partial class Pedidos
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
			dgv_pedidos = new DataGridView();
			pictureBox1 = new PictureBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dgv_pedidos).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// dgv_pedidos
			// 
			dgv_pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_pedidos.Location = new Point(36, 116);
			dgv_pedidos.Name = "dgv_pedidos";
			dgv_pedidos.Size = new Size(1172, 453);
			dgv_pedidos.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(-22, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1304, 688);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.Location = new Point(36, 60);
			button1.Name = "button1";
			button1.Size = new Size(143, 39);
			button1.TabIndex = 7;
			button1.Text = "Control de pedidos";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Pedidos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(button1);
			Controls.Add(dgv_pedidos);
			Controls.Add(pictureBox1);
			Name = "Pedidos";
			Size = new Size(1282, 652);
			Load += Pedidos_Load;
			((System.ComponentModel.ISupportInitialize)dgv_pedidos).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private PictureBox pictureBox1;
		private Button button1;
		public DataGridView dgv_pedidos;
	}
}
