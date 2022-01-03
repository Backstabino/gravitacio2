namespace gravitacio2
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
			this.Startu = new System.Windows.Forms.Button();
			this.palya = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Tomeg = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.palya)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// Startu
			// 
			this.Startu.Location = new System.Drawing.Point(724, 12);
			this.Startu.Name = "Startu";
			this.Startu.Size = new System.Drawing.Size(61, 33);
			this.Startu.TabIndex = 0;
			this.Startu.Text = "Startu";
			this.Startu.UseVisualStyleBackColor = true;
			this.Startu.Click += new System.EventHandler(this.button1_Click);
			// 
			// palya
			// 
			this.palya.BackColor = System.Drawing.Color.Black;
			this.palya.Location = new System.Drawing.Point(12, 15);
			this.palya.Name = "palya";
			this.palya.Size = new System.Drawing.Size(706, 440);
			this.palya.TabIndex = 1;
			this.palya.TabStop = false;
			this.palya.Click += new System.EventHandler(this.palya_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(724, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(61, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "deletu";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(812, 87);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown1.TabIndex = 3;
			// 
			// Tomeg
			// 
			this.Tomeg.AutoSize = true;
			this.Tomeg.Location = new System.Drawing.Point(735, 94);
			this.Tomeg.Name = "Tomeg";
			this.Tomeg.Size = new System.Drawing.Size(46, 13);
			this.Tomeg.TabIndex = 4;
			this.Tomeg.Text = "Tomegu";
			this.Tomeg.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(727, 137);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(135, 315);
			this.panel1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(874, 467);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Tomeg);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.palya);
			this.Controls.Add(this.Startu);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.palya)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Startu;
		private System.Windows.Forms.PictureBox palya;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label Tomeg;
		private System.Windows.Forms.Panel panel1;
	}
}

