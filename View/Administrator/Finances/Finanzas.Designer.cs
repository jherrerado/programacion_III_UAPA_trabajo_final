namespace YHDesign_project.View.Admin.Finances
{
	partial class Finanzas
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finanzas));
			pictureBox1 = new PictureBox();
			btn_facturacion = new Button();
			button1 = new Button();
			button4 = new Button();
			lbl_finanzas_title = new Label();
			dgv_finanzas_data = new DataGridView();
			button6 = new Button();
			button3 = new Button();
			button5 = new Button();
			button7 = new Button();
			toolTip1 = new ToolTip(components);
			dtp_entre_primer_valor = new DateTimePicker();
			dtp_entre_segundo_valor = new DateTimePicker();
			label1 = new Label();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_finanzas_data).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(39, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1243, 652);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// btn_facturacion
			// 
			btn_facturacion.BackColor = Color.Black;
			btn_facturacion.FlatStyle = FlatStyle.Popup;
			btn_facturacion.Image = (Image)resources.GetObject("btn_facturacion.Image");
			btn_facturacion.Location = new Point(39, 74);
			btn_facturacion.Name = "btn_facturacion";
			btn_facturacion.Size = new Size(105, 70);
			btn_facturacion.TabIndex = 0;
			toolTip1.SetToolTip(btn_facturacion, "Facturas");
			btn_facturacion.UseVisualStyleBackColor = false;
			btn_facturacion.Click += btn_facturacion_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.Black;
			button1.FlatStyle = FlatStyle.Popup;
			button1.Image = (Image)resources.GetObject("button1.Image");
			button1.Location = new Point(39, 157);
			button1.Name = "button1";
			button1.Size = new Size(105, 70);
			button1.TabIndex = 1;
			toolTip1.SetToolTip(button1, "Cotizacion");
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button4
			// 
			button4.BackColor = Color.Black;
			button4.FlatStyle = FlatStyle.Popup;
			button4.Image = (Image)resources.GetObject("button4.Image");
			button4.Location = new Point(39, 242);
			button4.Name = "button4";
			button4.Size = new Size(105, 70);
			button4.TabIndex = 4;
			toolTip1.SetToolTip(button4, "Deudas");
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click_2;
			// 
			// lbl_finanzas_title
			// 
			lbl_finanzas_title.AutoSize = true;
			lbl_finanzas_title.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_finanzas_title.Location = new Point(161, 31);
			lbl_finanzas_title.Name = "lbl_finanzas_title";
			lbl_finanzas_title.Size = new Size(158, 30);
			lbl_finanzas_title.TabIndex = 0;
			lbl_finanzas_title.Text = "Filtrar factura: ";
			lbl_finanzas_title.Click += lbl_finanzas_title_Click;
			// 
			// dgv_finanzas_data
			// 
			dgv_finanzas_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_finanzas_data.Location = new Point(161, 74);
			dgv_finanzas_data.Name = "dgv_finanzas_data";
			dgv_finanzas_data.Size = new Size(952, 474);
			dgv_finanzas_data.TabIndex = 0;
			// 
			// button6
			// 
			button6.BackColor = Color.Red;
			button6.FlatStyle = FlatStyle.Flat;
			button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button6.ForeColor = Color.White;
			button6.Location = new Point(1138, 74);
			button6.Name = "button6";
			button6.Size = new Size(118, 56);
			button6.TabIndex = 6;
			button6.Text = "Buscar";
			button6.UseVisualStyleBackColor = false;
			button6.Click += button6_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Red;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = Color.White;
			button3.Location = new Point(1138, 155);
			button3.Name = "button3";
			button3.Size = new Size(118, 56);
			button3.TabIndex = 7;
			button3.Text = "Agregar";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button5
			// 
			button5.BackColor = Color.Red;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button5.ForeColor = Color.White;
			button5.Location = new Point(1138, 237);
			button5.Name = "button5";
			button5.Size = new Size(118, 56);
			button5.TabIndex = 8;
			button5.Text = "Editar";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// button7
			// 
			button7.BackColor = Color.Red;
			button7.FlatStyle = FlatStyle.Flat;
			button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button7.ForeColor = Color.White;
			button7.Location = new Point(1138, 322);
			button7.Name = "button7";
			button7.Size = new Size(118, 56);
			button7.TabIndex = 9;
			button7.Text = "Eliminar";
			button7.UseVisualStyleBackColor = false;
			button7.Click += button7_Click_1;
			// 
			// dtp_entre_primer_valor
			// 
			dtp_entre_primer_valor.Format = DateTimePickerFormat.Short;
			dtp_entre_primer_valor.Location = new Point(828, 37);
			dtp_entre_primer_valor.Name = "dtp_entre_primer_valor";
			dtp_entre_primer_valor.Size = new Size(81, 23);
			dtp_entre_primer_valor.TabIndex = 10;
			// 
			// dtp_entre_segundo_valor
			// 
			dtp_entre_segundo_valor.CustomFormat = " ";
			dtp_entre_segundo_valor.Format = DateTimePickerFormat.Short;
			dtp_entre_segundo_valor.Location = new Point(968, 37);
			dtp_entre_segundo_valor.Name = "dtp_entre_segundo_valor";
			dtp_entre_segundo_valor.Size = new Size(81, 23);
			dtp_entre_segundo_valor.TabIndex = 11;
			dtp_entre_segundo_valor.ValueChanged += dtp_entre_segundo_valor_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(921, 41);
			label1.Name = "label1";
			label1.Size = new Size(34, 15);
			label1.TabIndex = 12;
			label1.Text = "entre";
			// 
			// button2
			// 
			button2.BackColor = Color.Red;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.White;
			button2.Location = new Point(1055, 35);
			button2.Name = "button2";
			button2.Size = new Size(51, 27);
			button2.TabIndex = 13;
			button2.Text = "filtrar";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click_1;
			// 
			// Finanzas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(button2);
			Controls.Add(label1);
			Controls.Add(dtp_entre_segundo_valor);
			Controls.Add(dtp_entre_primer_valor);
			Controls.Add(button7);
			Controls.Add(button5);
			Controls.Add(button3);
			Controls.Add(button6);
			Controls.Add(dgv_finanzas_data);
			Controls.Add(lbl_finanzas_title);
			Controls.Add(button4);
			Controls.Add(button1);
			Controls.Add(btn_facturacion);
			Controls.Add(pictureBox1);
			Name = "Finanzas";
			Size = new Size(1282, 652);
			Load += Finanzas_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dgv_finanzas_data).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Button btn_facturacion;
		private Button button1;
		private Button button4;
		private Label lbl_finanzas_title;
		private DataGridView dgv_finanzas_data;
		private Button button6;
		private Button button3;
		private Button button5;
		private Button button7;
		private ToolTip toolTip1;
		private DateTimePicker dtp_entre_primer_valor;
		private DateTimePicker dtp_entre_segundo_valor;
		private Label label1;
		private Button button2;
	}
}
