namespace YHDesign_project.View.Administrator.Finances
{
	partial class BusquedaAvanzada
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaAvanzada));
			button1 = new Button();
			txt_buscar_ced = new TextBox();
			dgv_facturas = new DataGridView();
			dgv_det_facturas = new DataGridView();
			label1 = new Label();
			label3 = new Label();
			button2 = new Button();
			lbl_cod_fac = new Label();
			txt_buscar_det_fac = new TextBox();
			button3 = new Button();
			label2 = new Label();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)dgv_facturas).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_det_facturas).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(331, 135);
			button1.Name = "button1";
			button1.Size = new Size(72, 22);
			button1.TabIndex = 0;
			button1.Text = "Buscar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// txt_buscar_ced
			// 
			txt_buscar_ced.Location = new Point(129, 134);
			txt_buscar_ced.Name = "txt_buscar_ced";
			txt_buscar_ced.Size = new Size(196, 23);
			txt_buscar_ced.TabIndex = 1;
			// 
			// dgv_facturas
			// 
			dgv_facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_facturas.Location = new Point(32, 174);
			dgv_facturas.Name = "dgv_facturas";
			dgv_facturas.Size = new Size(591, 425);
			dgv_facturas.TabIndex = 2;
			// 
			// dgv_det_facturas
			// 
			dgv_det_facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_det_facturas.Location = new Point(673, 174);
			dgv_det_facturas.Name = "dgv_det_facturas";
			dgv_det_facturas.Size = new Size(610, 423);
			dgv_det_facturas.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(37, 137);
			label1.Name = "label1";
			label1.Size = new Size(89, 15);
			label1.TabIndex = 4;
			label1.Text = "RNC / CEDULA:";
			label1.Click += label1_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(556, 19);
			label3.Name = "label3";
			label3.Size = new Size(191, 25);
			label3.TabIndex = 7;
			label3.Text = "Busqueda Avanzada";
			// 
			// button2
			// 
			button2.Location = new Point(1106, 615);
			button2.Name = "button2";
			button2.Size = new Size(156, 52);
			button2.TabIndex = 8;
			button2.Text = "Salir";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// lbl_cod_fac
			// 
			lbl_cod_fac.AutoSize = true;
			lbl_cod_fac.Location = new Point(673, 139);
			lbl_cod_fac.Name = "lbl_cod_fac";
			lbl_cod_fac.Size = new Size(49, 15);
			lbl_cod_fac.TabIndex = 10;
			lbl_cod_fac.Text = "Codigo:";
			// 
			// txt_buscar_det_fac
			// 
			txt_buscar_det_fac.Location = new Point(728, 135);
			txt_buscar_det_fac.Name = "txt_buscar_det_fac";
			txt_buscar_det_fac.Size = new Size(125, 23);
			txt_buscar_det_fac.TabIndex = 9;
			txt_buscar_det_fac.TextChanged += txt_buscar_det_fac_TextChanged;
			// 
			// button3
			// 
			button3.Location = new Point(859, 135);
			button3.Name = "button3";
			button3.Size = new Size(65, 23);
			button3.TabIndex = 11;
			button3.Text = "buscar";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click_1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(37, 88);
			label2.Name = "label2";
			label2.Size = new Size(149, 21);
			label2.TabIndex = 12;
			label2.Text = "Identificar Factura";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(673, 88);
			label4.Name = "label4";
			label4.Size = new Size(199, 21);
			label4.TabIndex = 13;
			label4.Text = "Identificar Los productos";
			// 
			// BusquedaAvanzada
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1314, 686);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(button3);
			Controls.Add(lbl_cod_fac);
			Controls.Add(txt_buscar_det_fac);
			Controls.Add(button2);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(dgv_det_facturas);
			Controls.Add(dgv_facturas);
			Controls.Add(txt_buscar_ced);
			Controls.Add(button1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "BusquedaAvanzada";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BusquedaAvanzada";
			Load += BusquedaAvanzada_Load;
			((System.ComponentModel.ISupportInitialize)dgv_facturas).EndInit();
			((System.ComponentModel.ISupportInitialize)dgv_det_facturas).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private TextBox txt_buscar_ced;
		private DataGridView dgv_facturas;
		private DataGridView dgv_det_facturas;
		private Label label1;
		private Label label3;
		private Button button2;
		private Label lbl_cod_fac;
		private TextBox txt_buscar_det_fac;
		private Button button3;
		private Label label2;
		private Label label4;
	}
}