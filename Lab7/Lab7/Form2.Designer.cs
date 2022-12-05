namespace Lab7 {
	partial class Form2 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.dgw = new System.Windows.Forms.DataGridView();
			this.button = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
			this.SuspendLayout();
			// 
			// dgw
			// 
			this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw.Location = new System.Drawing.Point(12, 12);
			this.dgw.Name = "dgw";
			this.dgw.Size = new System.Drawing.Size(266, 369);
			this.dgw.TabIndex = 0;
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(12, 387);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(266, 51);
			this.button.TabIndex = 1;
			this.button.Text = "Выполнить";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(354, 137);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(421, 102);
			this.textBox1.TabIndex = 2;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(866, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button);
			this.Controls.Add(this.dgw);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgw;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.TextBox textBox1;
	}
}