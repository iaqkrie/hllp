namespace Lab7 {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent () {
			this.nbtb = new System.Windows.Forms.TextBox();
			this.btb = new System.Windows.Forms.TextBox();
			this.res = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nbtb
			// 
			this.nbtb.Location = new System.Drawing.Point(12, 12);
			this.nbtb.Name = "nbtb";
			this.nbtb.Size = new System.Drawing.Size(69, 20);
			this.nbtb.TabIndex = 0;
			// 
			// btb
			// 
			this.btb.Location = new System.Drawing.Point(12, 39);
			this.btb.Name = "btb";
			this.btb.Size = new System.Drawing.Size(312, 20);
			this.btb.TabIndex = 1;
			// 
			// res
			// 
			this.res.Location = new System.Drawing.Point(255, 65);
			this.res.Name = "res";
			this.res.ReadOnly = true;
			this.res.Size = new System.Drawing.Size(69, 20);
			this.res.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(87, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(237, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Сгенерировать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 63);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(237, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Выполнить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 95);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.res);
			this.Controls.Add(this.btb);
			this.Controls.Add(this.nbtb);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nbtb;
		private System.Windows.Forms.TextBox btb;
		private System.Windows.Forms.TextBox res;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

