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
			this.textBoxInputUrl = new System.Windows.Forms.TextBox();
			this.labelInputUrl = new System.Windows.Forms.Label();
			this.labelOutput = new System.Windows.Forms.Label();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.buttonParse = new System.Windows.Forms.Button();
			this.textBoxInputTableId = new System.Windows.Forms.TextBox();
			this.labelDivId = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxInputUrl
			// 
			this.textBoxInputUrl.Location = new System.Drawing.Point(12, 47);
			this.textBoxInputUrl.Name = "textBoxInputUrl";
			this.textBoxInputUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxInputUrl.Size = new System.Drawing.Size(258, 20);
			this.textBoxInputUrl.TabIndex = 0;
			this.textBoxInputUrl.Text = "http://www.thonky.com/qr-code-tutorial/alignment-pattern-locations";
			// 
			// labelInputUrl
			// 
			this.labelInputUrl.AutoSize = true;
			this.labelInputUrl.Location = new System.Drawing.Point(77, 18);
			this.labelInputUrl.Name = "labelInputUrl";
			this.labelInputUrl.Size = new System.Drawing.Size(44, 13);
			this.labelInputUrl.TabIndex = 1;
			this.labelInputUrl.Text = "InputUrl";
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
			this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
			this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
			// 
			// textBoxInputTableId
			// 
			this.textBoxInputTableId.Location = new System.Drawing.Point(32, 117);
			this.textBoxInputTableId.Name = "textBoxInputTableId";
			this.textBoxInputTableId.Size = new System.Drawing.Size(100, 20);
			this.textBoxInputTableId.TabIndex = 5;
			this.textBoxInputTableId.Text = "body-text";
			// 
			// labelDivId
			// 
			this.labelDivId.AutoSize = true;
			this.labelDivId.Location = new System.Drawing.Point(40, 99);
			this.labelDivId.Name = "labelDivId";
			this.labelDivId.Size = new System.Drawing.Size(32, 13);
			this.labelDivId.TabIndex = 6;
			this.labelDivId.Text = "DivId";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 359);
			this.Controls.Add(this.labelDivId);
			this.Controls.Add(this.textBoxInputTableId);
			this.Controls.Add(this.buttonParse);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.labelInputUrl);
			this.Controls.Add(this.textBoxInputUrl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInputUrl;
		private System.Windows.Forms.Label labelInputUrl;
		private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Button buttonParse;
		private System.Windows.Forms.TextBox textBoxInputTableId;
		private System.Windows.Forms.Label labelDivId;
	}
}

