namespace YHDesign_project.View.Administrator.Finances
{
	partial class AgregarFactura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarFactura));
			label1 = new Label();
			lbl_cod_factura = new Label();
			groupBox1 = new GroupBox();
			cmb_empleados = new ComboBox();
			label3 = new Label();
			groupBox2 = new GroupBox();
			lbl_RNC_CEDULA = new Label();
			cmb_clientes = new ComboBox();
			label7 = new Label();
			label6 = new Label();
			btn_pago_total = new Button();
			groupBox3 = new GroupBox();
			nud_subTotal = new NumericUpDown();
			nud_cantidad = new NumericUpDown();
			Limpiar = new Button();
			button3 = new Button();
			button1 = new Button();
			label12 = new Label();
			label9 = new Label();
			label10 = new Label();
			txt_articulo = new TextBox();
			dgv_detalle_factura = new DataGridView();
			button8 = new Button();
			btn_primer_pago = new Button();
			dtp_fecha_caducidad = new DateTimePicker();
			label20 = new Label();
			gb_cotizacion = new GroupBox();
			gb_deuda = new GroupBox();
			dtp_limite_pago = new DateTimePicker();
			label22 = new Label();
			rb_fatura = new RadioButton();
			rb_cotizacion = new RadioButton();
			rb_deuda = new RadioButton();
			pn_facturar = new Panel();
			btn_enviear_deuda = new Button();
			btn_enviar_cotizacion = new Button();
			button2 = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nud_subTotal).BeginInit();
			((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_detalle_factura).BeginInit();
			gb_cotizacion.SuspendLayout();
			gb_deuda.SuspendLayout();
			pn_facturar.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(27, 314);
			label1.Name = "label1";
			label1.Size = new Size(52, 15);
			label1.TabIndex = 0;
			label1.Text = "Codigo.:";
			label1.Click += label1_Click;
			// 
			// lbl_cod_factura
			// 
			lbl_cod_factura.AutoSize = true;
			lbl_cod_factura.Location = new Point(85, 314);
			lbl_cod_factura.Name = "lbl_cod_factura";
			lbl_cod_factura.Size = new Size(52, 15);
			lbl_cod_factura.TabIndex = 1;
			lbl_cod_factura.Text = "FAC0006";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(cmb_empleados);
			groupBox1.Controls.Add(label3);
			groupBox1.Location = new Point(13, 17);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(274, 128);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Datos del empleado";
			groupBox1.Enter += groupBox1_Enter;
			// 
			// cmb_empleados
			// 
			cmb_empleados.FormattingEnabled = true;
			cmb_empleados.Location = new Point(72, 41);
			cmb_empleados.Name = "cmb_empleados";
			cmb_empleados.Size = new Size(121, 23);
			cmb_empleados.TabIndex = 1;
			cmb_empleados.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(15, 44);
			label3.Name = "label3";
			label3.Size = new Size(54, 15);
			label3.TabIndex = 0;
			label3.Text = "Nombre:";
			label3.Click += label3_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(lbl_RNC_CEDULA);
			groupBox2.Controls.Add(cmb_clientes);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label6);
			groupBox2.Location = new Point(17, 173);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(270, 128);
			groupBox2.TabIndex = 3;
			groupBox2.TabStop = false;
			groupBox2.Text = "Datos del cliente";
			groupBox2.Enter += groupBox2_Enter;
			// 
			// lbl_RNC_CEDULA
			// 
			lbl_RNC_CEDULA.AutoSize = true;
			lbl_RNC_CEDULA.Location = new Point(115, 85);
			lbl_RNC_CEDULA.Name = "lbl_RNC_CEDULA";
			lbl_RNC_CEDULA.Size = new Size(51, 15);
			lbl_RNC_CEDULA.TabIndex = 6;
			lbl_RNC_CEDULA.Text = "CEDULA";
			// 
			// cmb_clientes
			// 
			cmb_clientes.FormattingEnabled = true;
			cmb_clientes.Location = new Point(81, 39);
			cmb_clientes.Name = "cmb_clientes";
			cmb_clientes.Size = new Size(121, 23);
			cmb_clientes.TabIndex = 5;
			cmb_clientes.SelectedIndexChanged += cmb_clientes_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(25, 85);
			label7.Name = "label7";
			label7.Size = new Size(89, 15);
			label7.TabIndex = 4;
			label7.Text = "RNC / CEDULA:";
			label7.Click += label7_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(25, 42);
			label6.Name = "label6";
			label6.Size = new Size(54, 15);
			label6.TabIndex = 4;
			label6.Text = "Nombre:";
			// 
			// btn_pago_total
			// 
			btn_pago_total.Location = new Point(122, 599);
			btn_pago_total.Name = "btn_pago_total";
			btn_pago_total.Size = new Size(164, 62);
			btn_pago_total.TabIndex = 6;
			btn_pago_total.Text = "Pago Total";
			btn_pago_total.UseVisualStyleBackColor = true;
			btn_pago_total.Click += button2_Click;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(nud_subTotal);
			groupBox3.Controls.Add(nud_cantidad);
			groupBox3.Controls.Add(Limpiar);
			groupBox3.Controls.Add(button3);
			groupBox3.Controls.Add(button1);
			groupBox3.Controls.Add(label12);
			groupBox3.Controls.Add(label9);
			groupBox3.Controls.Add(label10);
			groupBox3.Controls.Add(txt_articulo);
			groupBox3.Location = new Point(40, 32);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(307, 431);
			groupBox3.TabIndex = 11;
			groupBox3.TabStop = false;
			groupBox3.Text = "Detalles de facturas";
			groupBox3.Enter += groupBox3_Enter;
			// 
			// nud_subTotal
			// 
			nud_subTotal.Location = new Point(106, 164);
			nud_subTotal.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			nud_subTotal.Name = "nud_subTotal";
			nud_subTotal.Size = new Size(74, 23);
			nud_subTotal.TabIndex = 24;
			// 
			// nud_cantidad
			// 
			nud_cantidad.Location = new Point(106, 105);
			nud_cantidad.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			nud_cantidad.Name = "nud_cantidad";
			nud_cantidad.Size = new Size(74, 23);
			nud_cantidad.TabIndex = 23;
			// 
			// Limpiar
			// 
			Limpiar.Location = new Point(42, 344);
			Limpiar.Name = "Limpiar";
			Limpiar.Size = new Size(240, 66);
			Limpiar.TabIndex = 12;
			Limpiar.Text = "Limpiar";
			Limpiar.UseVisualStyleBackColor = true;
			Limpiar.Click += Limpiar_Click;
			// 
			// button3
			// 
			button3.Location = new Point(151, 266);
			button3.Name = "button3";
			button3.Size = new Size(133, 72);
			button3.TabIndex = 17;
			button3.Text = "actualizar";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.Location = new Point(39, 266);
			button1.Name = "button1";
			button1.Size = new Size(103, 72);
			button1.TabIndex = 12;
			button1.Text = "Agregar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(42, 164);
			label12.Name = "label12";
			label12.Size = new Size(53, 15);
			label12.TabIndex = 16;
			label12.Text = "SubTotal";
			label12.Click += label12_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(42, 113);
			label9.Name = "label9";
			label9.Size = new Size(58, 15);
			label9.TabIndex = 13;
			label9.Text = "Cantidad:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(42, 50);
			label10.Name = "label10";
			label10.Size = new Size(76, 15);
			label10.TabIndex = 14;
			label10.Text = "cod. articulo:";
			// 
			// txt_articulo
			// 
			txt_articulo.Location = new Point(125, 42);
			txt_articulo.Name = "txt_articulo";
			txt_articulo.Size = new Size(157, 23);
			txt_articulo.TabIndex = 0;
			txt_articulo.TextChanged += textBox1_TextChanged;
			// 
			// dgv_detalle_factura
			// 
			dgv_detalle_factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_detalle_factura.Location = new Point(365, 39);
			dgv_detalle_factura.Name = "dgv_detalle_factura";
			dgv_detalle_factura.Size = new Size(396, 519);
			dgv_detalle_factura.TabIndex = 15;
			// 
			// button8
			// 
			button8.Location = new Point(79, 687);
			button8.Name = "button8";
			button8.Size = new Size(171, 62);
			button8.TabIndex = 20;
			button8.Text = "Cancelar";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// btn_primer_pago
			// 
			btn_primer_pago.Location = new Point(27, 598);
			btn_primer_pago.Name = "btn_primer_pago";
			btn_primer_pago.Size = new Size(89, 63);
			btn_primer_pago.TabIndex = 21;
			btn_primer_pago.Text = "Primer pago";
			btn_primer_pago.UseVisualStyleBackColor = true;
			btn_primer_pago.Click += button9_Click;
			// 
			// dtp_fecha_caducidad
			// 
			dtp_fecha_caducidad.Format = DateTimePickerFormat.Short;
			dtp_fecha_caducidad.Location = new Point(126, 23);
			dtp_fecha_caducidad.Name = "dtp_fecha_caducidad";
			dtp_fecha_caducidad.Size = new Size(99, 23);
			dtp_fecha_caducidad.TabIndex = 24;
			dtp_fecha_caducidad.Value = new DateTime(2025, 3, 29, 0, 0, 0, 0);
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(21, 29);
			label20.Name = "label20";
			label20.Size = new Size(99, 15);
			label20.TabIndex = 23;
			label20.Text = "Fecha caducidad:";
			// 
			// gb_cotizacion
			// 
			gb_cotizacion.Controls.Add(label20);
			gb_cotizacion.Controls.Add(dtp_fecha_caducidad);
			gb_cotizacion.Location = new Point(17, 375);
			gb_cotizacion.Name = "gb_cotizacion";
			gb_cotizacion.Size = new Size(274, 68);
			gb_cotizacion.TabIndex = 26;
			gb_cotizacion.TabStop = false;
			gb_cotizacion.Text = "Cotizacion";
			// 
			// gb_deuda
			// 
			gb_deuda.Controls.Add(dtp_limite_pago);
			gb_deuda.Controls.Add(label22);
			gb_deuda.Location = new Point(17, 375);
			gb_deuda.Name = "gb_deuda";
			gb_deuda.Size = new Size(270, 90);
			gb_deuda.TabIndex = 27;
			gb_deuda.TabStop = false;
			gb_deuda.Text = "Deudas";
			// 
			// dtp_limite_pago
			// 
			dtp_limite_pago.Format = DateTimePickerFormat.Short;
			dtp_limite_pago.Location = new Point(136, 40);
			dtp_limite_pago.Name = "dtp_limite_pago";
			dtp_limite_pago.Size = new Size(116, 23);
			dtp_limite_pago.TabIndex = 13;
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new Point(19, 44);
			label22.Name = "label22";
			label22.Size = new Size(99, 15);
			label22.TabIndex = 12;
			label22.Text = "Fecha caducidad:";
			label22.Click += label22_Click;
			// 
			// rb_fatura
			// 
			rb_fatura.AutoSize = true;
			rb_fatura.Location = new Point(797, 48);
			rb_fatura.Name = "rb_fatura";
			rb_fatura.Size = new Size(64, 19);
			rb_fatura.TabIndex = 28;
			rb_fatura.TabStop = true;
			rb_fatura.Text = "Factura";
			rb_fatura.UseVisualStyleBackColor = true;
			rb_fatura.CheckedChanged += rb_fatura_CheckedChanged;
			// 
			// rb_cotizacion
			// 
			rb_cotizacion.AutoSize = true;
			rb_cotizacion.Location = new Point(797, 86);
			rb_cotizacion.Name = "rb_cotizacion";
			rb_cotizacion.Size = new Size(81, 19);
			rb_cotizacion.TabIndex = 29;
			rb_cotizacion.TabStop = true;
			rb_cotizacion.Text = "Cotizacion";
			rb_cotizacion.UseVisualStyleBackColor = true;
			rb_cotizacion.CheckedChanged += rb_cotizacion_CheckedChanged;
			// 
			// rb_deuda
			// 
			rb_deuda.AutoSize = true;
			rb_deuda.Location = new Point(797, 124);
			rb_deuda.Name = "rb_deuda";
			rb_deuda.Size = new Size(59, 19);
			rb_deuda.TabIndex = 30;
			rb_deuda.TabStop = true;
			rb_deuda.Text = "Deuda";
			rb_deuda.UseVisualStyleBackColor = true;
			rb_deuda.CheckedChanged += rb_deuda_CheckedChanged;
			// 
			// pn_facturar
			// 
			pn_facturar.Controls.Add(btn_enviear_deuda);
			pn_facturar.Controls.Add(groupBox1);
			pn_facturar.Controls.Add(gb_deuda);
			pn_facturar.Controls.Add(btn_enviar_cotizacion);
			pn_facturar.Controls.Add(label1);
			pn_facturar.Controls.Add(lbl_cod_factura);
			pn_facturar.Controls.Add(groupBox2);
			pn_facturar.Controls.Add(btn_pago_total);
			pn_facturar.Controls.Add(btn_primer_pago);
			pn_facturar.Controls.Add(gb_cotizacion);
			pn_facturar.Location = new Point(925, 48);
			pn_facturar.Name = "pn_facturar";
			pn_facturar.Size = new Size(308, 684);
			pn_facturar.TabIndex = 31;
			// 
			// btn_enviear_deuda
			// 
			btn_enviear_deuda.Location = new Point(31, 527);
			btn_enviear_deuda.Name = "btn_enviear_deuda";
			btn_enviear_deuda.Size = new Size(256, 62);
			btn_enviear_deuda.TabIndex = 33;
			btn_enviear_deuda.Text = "Deuda";
			btn_enviear_deuda.UseVisualStyleBackColor = true;
			btn_enviear_deuda.Click += btn_enviear_deuda_Click;
			// 
			// btn_enviar_cotizacion
			// 
			btn_enviar_cotizacion.Location = new Point(27, 527);
			btn_enviar_cotizacion.Name = "btn_enviar_cotizacion";
			btn_enviar_cotizacion.Size = new Size(260, 63);
			btn_enviar_cotizacion.TabIndex = 32;
			btn_enviar_cotizacion.Text = "Cotizacion";
			btn_enviar_cotizacion.UseVisualStyleBackColor = true;
			btn_enviar_cotizacion.Click += btn_enviar_cotizacion_Click;
			// 
			// button2
			// 
			button2.Location = new Point(638, 575);
			button2.Name = "button2";
			button2.Size = new Size(123, 34);
			button2.TabIndex = 32;
			button2.Text = "Actualizar tabla";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// AgregarFactura
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1304, 761);
			Controls.Add(button2);
			Controls.Add(pn_facturar);
			Controls.Add(rb_deuda);
			Controls.Add(rb_cotizacion);
			Controls.Add(rb_fatura);
			Controls.Add(button8);
			Controls.Add(dgv_detalle_factura);
			Controls.Add(groupBox3);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "AgregarFactura";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AgregarFactura";
			Load += AgregarFactura_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nud_subTotal).EndInit();
			((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
			((System.ComponentModel.ISupportInitialize)dgv_detalle_factura).EndInit();
			gb_cotizacion.ResumeLayout(false);
			gb_cotizacion.PerformLayout();
			gb_deuda.ResumeLayout(false);
			gb_deuda.PerformLayout();
			pn_facturar.ResumeLayout(false);
			pn_facturar.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private ComboBox cmb_empleados;
		private Label label3;
		private GroupBox groupBox2;
		private ComboBox comboBox3;
		private ComboBox cmb_clientes;
		private Label label7;
		private Label label6;
		private Button btn_pago_total;
		private GroupBox groupBox3;
		private TextBox txt_articulo;
		private Button Limpiar;
		private Button button3;
		private Button button1;
		private Label label12;
		private Label label9;
		private Label label10;
		private NumericUpDown nud_subTotal;
		private NumericUpDown nud_cantidad;
		private Label lbl_RNC_CEDULA;
		private Button button8;
		private Button btn_primer_pago;
		private DateTimePicker dtp_fecha_caducidad;
		private Label label20;
		private GroupBox gb_cotizacion;
		private GroupBox gb_deuda;
		private DateTimePicker dtp_limite_pago;
		private Label label22;
		private RadioButton rb_fatura;
		private RadioButton rb_cotizacion;
		private RadioButton rb_deuda;
		private Panel pn_facturar;
		private Button btn_enviar_cotizacion;
		private Button btn_enviear_deuda;
		public DataGridView dgv_detalle_factura;
		public Label lbl_cod_factura;
		private Button button2;
	}
}