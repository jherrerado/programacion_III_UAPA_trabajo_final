namespace YHDesign_project.View.Administrator.Finances
{
	partial class EliminarFacturas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarFacturas));
			button2 = new Button();
			button1 = new Button();
			dgv_eliminar_facturas = new DataGridView();
			label1 = new Label();
			txt_eliminar = new TextBox();
			((System.ComponentModel.ISupportInitialize)dgv_eliminar_facturas).BeginInit();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(795, 616);
			button2.Name = "button2";
			button2.Size = new Size(240, 72);
			button2.TabIndex = 29;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(1041, 616);
			button1.Name = "button1";
			button1.Size = new Size(240, 72);
			button1.TabIndex = 28;
			button1.Text = "Elminar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dgv_eliminar_facturas
			// 
			dgv_eliminar_facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_eliminar_facturas.Location = new Point(68, 130);
			dgv_eliminar_facturas.Name = "dgv_eliminar_facturas";
			dgv_eliminar_facturas.Size = new Size(1165, 458);
			dgv_eliminar_facturas.TabIndex = 25;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(68, 90);
			label1.Name = "label1";
			label1.Size = new Size(49, 15);
			label1.TabIndex = 20;
			label1.Text = "Codigo:";
			// 
			// txt_eliminar
			// 
			txt_eliminar.Location = new Point(121, 87);
			txt_eliminar.Name = "txt_eliminar";
			txt_eliminar.Size = new Size(167, 23);
			txt_eliminar.TabIndex = 22;
			txt_eliminar.TextChanged += txt_eliminar_TextChanged;
			// 
			// EliminarFacturas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1342, 700);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dgv_eliminar_facturas);
			Controls.Add(label1);
			Controls.Add(txt_eliminar);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "EliminarFacturas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EliminarFacturas";
			((System.ComponentModel.ISupportInitialize)dgv_eliminar_facturas).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button button1;
		private DataGridView dgv_eliminar_facturas;
		private Label label1;
		private TextBox txt_eliminar;
	}
}