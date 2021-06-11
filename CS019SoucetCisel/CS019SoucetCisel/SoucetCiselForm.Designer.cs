namespace CS019SoucetCisel
{
	partial class SoucetCiselForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cislaTextBox = new System.Windows.Forms.TextBox();
			this.soucetLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cislaTextBox
			// 
			this.cislaTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cislaTextBox.Location = new System.Drawing.Point(140, 119);
			this.cislaTextBox.Name = "cislaTextBox";
			this.cislaTextBox.Size = new System.Drawing.Size(627, 43);
			this.cislaTextBox.TabIndex = 0;
			this.cislaTextBox.TextChanged += new System.EventHandler(this.cislaTextBox_TextChanged);
			// 
			// soucetLabel
			// 
			this.soucetLabel.AutoSize = true;
			this.soucetLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.soucetLabel.Location = new System.Drawing.Point(151, 226);
			this.soucetLabel.Name = "soucetLabel";
			this.soucetLabel.Size = new System.Drawing.Size(160, 47);
			this.soucetLabel.TabIndex = 1;
			this.soucetLabel.Text = "Součet: ?";
			// 
			// SoucetCiselForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 450);
			this.Controls.Add(this.soucetLabel);
			this.Controls.Add(this.cislaTextBox);
			this.Name = "SoucetCiselForm";
			this.Text = "CS019 Součet Čísel - Oldřich Baudyš";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox cislaTextBox;
		private System.Windows.Forms.Label soucetLabel;
	}
}

