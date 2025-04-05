namespace YHDesign_project.View.Administrator.Orders
{
	partial class BandejasPedidos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BandejasPedidos));
			label1 = new Label();
			dgv_facturas_pedidos = new DataGridView();
			dgv_det_fac_pedidos = new DataGridView();
			label2 = new Label();
			button1 = new Button();
			label4 = new Label();
			label5 = new Label();
			label8 = new Label();
			txt_codigo_pedidos = new TextBox();
			rb_progreso = new RadioButton();
			rb_hecho = new RadioButton();
			cb_usuario = new ComboBox();
			dgv_pedidos_activos = new DataGridView();
			label3 = new Label();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dgv_facturas_pedidos).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_det_fac_pedidos).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_pedidos_activos).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(37, 50);
			label1.Name = "label1";
			label1.Size = new Size(85, 25);
			label1.TabIndex = 0;
			label1.Text = "Facturas";
			// 
			// dgv_facturas_pedidos
			// 
			dgv_facturas_pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_facturas_pedidos.Location = new Point(34, 84);
			dgv_facturas_pedidos.Name = "dgv_facturas_pedidos";
			dgv_facturas_pedidos.Size = new Size(240, 573);
			dgv_facturas_pedidos.TabIndex = 1;
			// 
			// dgv_det_fac_pedidos
			// 
			dgv_det_fac_pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_det_fac_pedidos.Location = new Point(324, 84);
			dgv_det_fac_pedidos.Name = "dgv_det_fac_pedidos";
			dgv_det_fac_pedidos.Size = new Size(612, 198);
			dgv_det_fac_pedidos.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(326, 50);
			label2.Name = "label2";
			label2.Size = new Size(82, 25);
			label2.TabIndex = 3;
			label2.Text = "Pedidos";
			// 
			// button1
			// 
			button1.Location = new Point(969, 213);
			button1.Name = "button1";
			button1.Size = new Size(354, 69);
			button1.TabIndex = 4;
			button1.Text = "Enviar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(1146, 91);
			label4.Name = "label4";
			label4.Size = new Size(50, 15);
			label4.TabIndex = 6;
			label4.Text = "Usuario:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(988, 147);
			label5.Name = "label5";
			label5.Size = new Size(45, 15);
			label5.TabIndex = 7;
			label5.Text = "Estado:";
			label5.Click += label5_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(964, 87);
			label8.Name = "label8";
			label8.Size = new Size(78, 15);
			label8.TabIndex = 10;
			label8.Text = "cod. Pedidos:";
			// 
			// txt_codigo_pedidos
			// 
			txt_codigo_pedidos.Location = new Point(1051, 83);
			txt_codigo_pedidos.Name = "txt_codigo_pedidos";
			txt_codigo_pedidos.Size = new Size(71, 23);
			txt_codigo_pedidos.TabIndex = 13;
			// 
			// rb_progreso
			// 
			rb_progreso.AutoSize = true;
			rb_progreso.Location = new Point(1051, 145);
			rb_progreso.Name = "rb_progreso";
			rb_progreso.Size = new Size(72, 19);
			rb_progreso.TabIndex = 14;
			rb_progreso.TabStop = true;
			rb_progreso.Text = "Progreso";
			rb_progreso.UseVisualStyleBackColor = true;
			// 
			// rb_hecho
			// 
			rb_hecho.AutoSize = true;
			rb_hecho.Location = new Point(1146, 145);
			rb_hecho.Name = "rb_hecho";
			rb_hecho.Size = new Size(60, 19);
			rb_hecho.TabIndex = 15;
			rb_hecho.TabStop = true;
			rb_hecho.Text = "Hecho";
			rb_hecho.UseVisualStyleBackColor = true;
			// 
			// cb_usuario
			// 
			cb_usuario.FormattingEnabled = true;
			cb_usuario.Location = new Point(1202, 88);
			cb_usuario.Name = "cb_usuario";
			cb_usuario.Size = new Size(121, 23);
			cb_usuario.TabIndex = 17;
			// 
			// dgv_pedidos_activos
			// 
			dgv_pedidos_activos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_pedidos_activos.Location = new Point(324, 392);
			dgv_pedidos_activos.Name = "dgv_pedidos_activos";
			dgv_pedidos_activos.Size = new Size(612, 265);
			dgv_pedidos_activos.TabIndex = 18;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(324, 334);
			label3.Name = "label3";
			label3.Size = new Size(196, 25);
			label3.TabIndex = 19;
			label3.Text = "Pedidos En progreso";
			// 
			// button2
			// 
			button2.Location = new Point(969, 290);
			button2.Name = "button2";
			button2.Size = new Size(354, 69);
			button2.TabIndex = 20;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// BandejasPedidos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1384, 760);
			Controls.Add(button2);
			Controls.Add(label3);
			Controls.Add(dgv_pedidos_activos);
			Controls.Add(cb_usuario);
			Controls.Add(rb_hecho);
			Controls.Add(rb_progreso);
			Controls.Add(txt_codigo_pedidos);
			Controls.Add(label8);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(dgv_det_fac_pedidos);
			Controls.Add(dgv_facturas_pedidos);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "BandejasPedidos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BandejasPedidos";
			Load += BandejasPedidos_Load;
			((System.ComponentModel.ISupportInitialize)dgv_facturas_pedidos).EndInit();
			((System.ComponentModel.ISupportInitialize)dgv_det_fac_pedidos).EndInit();
			((System.ComponentModel.ISupportInitialize)dgv_pedidos_activos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private DataGridView dgv_facturas_pedidos;
		private DataGridView dgv_det_fac_pedidos;
		private Label label2;
		private Button button1;
		private Label label4;
		private Label label5;
		private Label label8;
		private TextBox txt_codigo_pedidos;
		private RadioButton rb_progreso;
		private RadioButton rb_hecho;
		private ComboBox cb_usuario;
		private DataGridView dgv_pedidos_activos;
		private Label label3;
		private Button button2;
	}
}