namespace FormFatorial
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxFatorial = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.buttonCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fatorial de:";
			// 
			// textBoxFatorial
			// 
			this.textBoxFatorial.Location = new System.Drawing.Point(123, 27);
			this.textBoxFatorial.Name = "textBoxFatorial";
			this.textBoxFatorial.Size = new System.Drawing.Size(100, 20);
			this.textBoxFatorial.TabIndex = 1;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(37, 77);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(55, 13);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Resultado";
			// 
			// buttonCalcular
			// 
			this.buttonCalcular.Location = new System.Drawing.Point(40, 133);
			this.buttonCalcular.Name = "buttonCalcular";
			this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
			this.buttonCalcular.TabIndex = 3;
			this.buttonCalcular.Text = "Calcular";
			this.buttonCalcular.UseVisualStyleBackColor = true;
			this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.buttonCalcular);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.textBoxFatorial);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxFatorial;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button buttonCalcular;
	}
}

