namespace YHDesign_project.View.Administrator.Finances
{
	partial class ActulizarDetalesFacturasAgregar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActulizarDetalesFacturasAgregar));
			nud_subTotal = new NumericUpDown();
			nud_cantidad = new NumericUpDown();
			label12 = new Label();
			label9 = new Label();
			label10 = new Label();
			txt_articulo = new TextBox();
			label1 = new Label();
			txt_codigo_det_fac = new TextBox();
			btn_actualizar = new Button();
			((System.ComponentModel.ISupportInitialize)nud_subTotal).BeginInit();
			((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
			SuspendLayout();
			// 
			// nud_subTotal
			// 
			nud_subTotal.Location = new Point(117, 173);
			nud_subTotal.Name = "nud_subTotal";
			nud_subTotal.Size = new Size(74, 23);
			nud_subTotal.TabIndex = 30;
			// 
			// nud_cantidad
			// 
			nud_cantidad.Location = new Point(117, 127);
			nud_cantidad.Name = "nud_cantidad";
			nud_cantidad.Size = new Size(74, 23);
			nud_cantidad.TabIndex = 29;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(53, 173);
			label12.Name = "label12";
			label12.Size = new Size(53, 15);
			label12.TabIndex = 28;
			label12.Text = "SubTotal";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(53, 135);
			label9.Name = "label9";
			label9.Size = new Size(58, 15);
			label9.TabIndex = 26;
			label9.Text = "Cantidad:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(53, 88);
			label10.Name = "label10";
			label10.Size = new Size(76, 15);
			label10.TabIndex = 27;
			label10.Text = "cod. articulo:";
			// 
			// txt_articulo
			// 
			txt_articulo.Location = new Point(136, 84);
			txt_articulo.Name = "txt_articulo";
			txt_articulo.Size = new Size(84, 23);
			txt_articulo.TabIndex = 25;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(53, 38);
			label1.Name = "label1";
			label1.Size = new Size(104, 15);
			label1.TabIndex = 32;
			label1.Text = "cod. Det. Facturas:";
			// 
			// txt_codigo_det_fac
			// 
			txt_codigo_det_fac.Location = new Point(161, 34);
			txt_codigo_det_fac.Name = "txt_codigo_det_fac";
			txt_codigo_det_fac.Size = new Size(84, 23);
			txt_codigo_det_fac.TabIndex = 31;
			txt_codigo_det_fac.TextChanged += textBox1_TextChanged;
			// 
			// btn_actualizar
			// 
			btn_actualizar.Location = new Point(117, 236);
			btn_actualizar.Name = "btn_actualizar";
			btn_actualizar.Size = new Size(75, 23);
			btn_actualizar.TabIndex = 33;
			btn_actualizar.Text = "Actualizar";
			btn_actualizar.UseVisualStyleBackColor = true;
			btn_actualizar.Click += btn_actualizar_Click;
			// 
			// ActulizarDetalesFacturasAgregar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(348, 324);
			Controls.Add(btn_actualizar);
			Controls.Add(label1);
			Controls.Add(txt_codigo_det_fac);
			Controls.Add(nud_subTotal);
			Controls.Add(nud_cantidad);
			Controls.Add(label12);
			Controls.Add(label9);
			Controls.Add(label10);
			Controls.Add(txt_articulo);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "ActulizarDetalesFacturasAgregar";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ActulizarDetalesFacturasAgregar";
			((System.ComponentModel.ISupportInitialize)nud_subTotal).EndInit();
			((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown nud_subTotal;
		private NumericUpDown nud_cantidad;
		private Label label12;
		private Label label9;
		private Label label10;
		private TextBox txt_articulo;
		private Label label1;
		private TextBox txt_codigo_det_fac;
		private Button btn_actualizar;
	}
}