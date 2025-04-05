namespace YHDesign_project.View.Administrator.Finances
{
	partial class EditarFacturas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFacturas));
			lbl_codigo_ediatar_factura = new Label();
			txt_facturas = new TextBox();
			dgv_facturas = new DataGridView();
			dgv_detalles_facturas = new DataGridView();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			txt_detalles_facturas_delete = new TextBox();
			label17 = new Label();
			groupBox4 = new GroupBox();
			button4 = new Button();
			button5 = new Button();
			((System.ComponentModel.ISupportInitialize)dgv_facturas).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_detalles_facturas).BeginInit();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// lbl_codigo_ediatar_factura
			// 
			lbl_codigo_ediatar_factura.AutoSize = true;
			lbl_codigo_ediatar_factura.Location = new Point(31, 62);
			lbl_codigo_ediatar_factura.Name = "lbl_codigo_ediatar_factura";
			lbl_codigo_ediatar_factura.Size = new Size(47, 15);
			lbl_codigo_ediatar_factura.TabIndex = 0;
			lbl_codigo_ediatar_factura.Text = "codigo:";
			// 
			// txt_facturas
			// 
			txt_facturas.Location = new Point(79, 59);
			txt_facturas.Name = "txt_facturas";
			txt_facturas.Size = new Size(167, 23);
			txt_facturas.TabIndex = 1;
			txt_facturas.TextChanged += textBox1_TextChanged;
			// 
			// dgv_facturas
			// 
			dgv_facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_facturas.Location = new Point(282, 59);
			dgv_facturas.Name = "dgv_facturas";
			dgv_facturas.Size = new Size(619, 127);
			dgv_facturas.TabIndex = 4;
			dgv_facturas.CellContentClick += dataGridView1_CellContentClick;
			// 
			// dgv_detalles_facturas
			// 
			dgv_detalles_facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_detalles_facturas.Location = new Point(282, 192);
			dgv_detalles_facturas.Name = "dgv_detalles_facturas";
			dgv_detalles_facturas.Size = new Size(619, 329);
			dgv_detalles_facturas.TabIndex = 5;
			// 
			// button1
			// 
			button1.Location = new Point(1052, 583);
			button1.Name = "button1";
			button1.Size = new Size(240, 72);
			button1.TabIndex = 18;
			button1.Text = "actualizar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(792, 583);
			button2.Name = "button2";
			button2.Size = new Size(240, 72);
			button2.TabIndex = 19;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(38, 361);
			button3.Name = "button3";
			button3.Size = new Size(244, 72);
			button3.TabIndex = 17;
			button3.Text = "Eliminar";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// txt_detalles_facturas_delete
			// 
			txt_detalles_facturas_delete.Location = new Point(115, 34);
			txt_detalles_facturas_delete.Name = "txt_detalles_facturas_delete";
			txt_detalles_facturas_delete.Size = new Size(167, 23);
			txt_detalles_facturas_delete.TabIndex = 24;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(38, 37);
			label17.Name = "label17";
			label17.Size = new Size(71, 15);
			label17.TabIndex = 23;
			label17.Text = "cod. detalle:";
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(label17);
			groupBox4.Controls.Add(txt_detalles_facturas_delete);
			groupBox4.Controls.Add(button3);
			groupBox4.Location = new Point(937, 71);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(307, 450);
			groupBox4.TabIndex = 12;
			groupBox4.TabStop = false;
			groupBox4.Text = "Detalles de facturas";
			// 
			// button4
			// 
			button4.Location = new Point(31, 108);
			button4.Name = "button4";
			button4.Size = new Size(106, 72);
			button4.TabIndex = 20;
			button4.Text = "Primer pago";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(31, 192);
			button5.Name = "button5";
			button5.Size = new Size(106, 72);
			button5.TabIndex = 21;
			button5.Text = "Pago total";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// EditarFacturas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1331, 667);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(groupBox4);
			Controls.Add(dgv_detalles_facturas);
			Controls.Add(dgv_facturas);
			Controls.Add(lbl_codigo_ediatar_factura);
			Controls.Add(txt_facturas);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "EditarFacturas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EditarFacturas";
			((System.ComponentModel.ISupportInitialize)dgv_facturas).EndInit();
			((System.ComponentModel.ISupportInitialize)dgv_detalles_facturas).EndInit();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbl_codigo_ediatar_factura;
		private TextBox txt_facturas;
		private DataGridView dgv_facturas;
		private DataGridView dgv_detalles_facturas;
		private Button button1;
		private Button button2;
		private Button button3;
		private TextBox txt_detalles_facturas_delete;
		private Label label17;
		private GroupBox groupBox4;
		private Button button4;
		private Button button5;
	}
}