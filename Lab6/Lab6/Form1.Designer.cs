﻿namespace Lab6 {
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
			this.sourceDGV = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dGV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.sourceDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
			this.SuspendLayout();
			// 
			// sourceDGV
			// 
			this.sourceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sourceDGV.Location = new System.Drawing.Point(12, 12);
			this.sourceDGV.Name = "sourceDGV";
			this.sourceDGV.Size = new System.Drawing.Size(809, 158);
			this.sourceDGV.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(827, 147);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(240, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Сгенерировать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(827, 176);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(240, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Выполнить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dGV
			// 
			this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV.Location = new System.Drawing.Point(12, 176);
			this.dGV.Name = "dGV";
			this.dGV.Size = new System.Drawing.Size(809, 158);
			this.dGV.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1082, 349);
			this.Controls.Add(this.dGV);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.sourceDGV);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.sourceDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView sourceDGV;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dGV;
	}
}

