namespace ParserForQRCode {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.labelInput = new System.Windows.Forms.Label();
			this.labelOutput = new System.Windows.Forms.Label();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.buttonParse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(12, 47);
			this.textBoxInput.Multiline = true;
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(258, 219);
			this.textBoxInput.TabIndex = 0;
			// 
			// labelInput
			// 
			this.labelInput.AutoSize = true;
			this.labelInput.Location = new System.Drawing.Point(77, 18);
			this.labelInput.Name = "labelInput";
			this.labelInput.Size = new System.Drawing.Size(31, 13);
			this.labelInput.TabIndex = 1;
			this.labelInput.Text = "Input";
			// 
			// labelOutput
			// 
			this.labelOutput.AutoSize = true;
			this.labelOutput.Location = new System.Drawing.Point(542, 18);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(39, 13);
			this.labelOutput.TabIndex = 2;
			this.labelOutput.Text = "Output";
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Location = new System.Drawing.Point(453, 47);
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.Size = new System.Drawing.Size(295, 219);
			this.textBoxOutput.TabIndex = 3;
			// 
			// buttonParse
			// 
			this.buttonParse.Location = new System.Drawing.Point(328, 99);
			this.buttonParse.Name = "buttonParse";
			this.buttonParse.Size = new System.Drawing.Size(75, 23);
			this.buttonParse.TabIndex = 4;
			this.buttonParse.Text = "->";
			this.buttonParse.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 359);
			this.Controls.Add(this.buttonParse);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.labelInput);
			this.Controls.Add(this.textBoxInput);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Label labelInput;
		private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Button buttonParse;
	}
}

