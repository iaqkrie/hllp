namespace Lab6 {
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
			this.sdgv = new System.Windows.Forms.DataGridView();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.ntb = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.mtb = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.sdgv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// sdgv
			// 
			this.sdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sdgv.Location = new System.Drawing.Point(12, 12);
			this.sdgv.Name = "sdgv";
			this.sdgv.Size = new System.Drawing.Size(979, 391);
			this.sdgv.TabIndex = 0;
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(12, 409);
			this.dgv.Name = "dgv";
			this.dgv.Size = new System.Drawing.Size(979, 391);
			this.dgv.TabIndex = 1;
			// 
			// ntb
			// 
			this.ntb.Location = new System.Drawing.Point(997, 354);
			this.ntb.Name = "ntb";
			this.ntb.Size = new System.Drawing.Size(100, 20);
			this.ntb.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(997, 380);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(223, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Сгенерировать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(997, 409);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(223, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Выполнить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// mtb
			// 
			this.mtb.Location = new System.Drawing.Point(1120, 354);
			this.mtb.Name = "mtb";
			this.mtb.Size = new System.Drawing.Size(100, 20);
			this.mtb.TabIndex = 5;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1232, 811);
			this.Controls.Add(this.mtb);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ntb);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.sdgv);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.sdgv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView sdgv;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.TextBox ntb;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox mtb;
	}
}