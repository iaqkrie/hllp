namespace Lab3;

partial class Form1 {
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent () {
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.t1 = new System.Windows.Forms.TabPage();
			this.button = new System.Windows.Forms.Button();
			this.tby = new System.Windows.Forms.TextBox();
			this.tbx = new System.Windows.Forms.TextBox();
			this.t2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.res = new System.Windows.Forms.TextBox();
			this.tb2 = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.t1.SuspendLayout();
			this.t2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.t1);
			this.tabControl1.Controls.Add(this.t2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(269, 260);
			this.tabControl1.TabIndex = 0;
			// 
			// t1
			// 
			this.t1.Controls.Add(this.button);
			this.t1.Controls.Add(this.tby);
			this.t1.Controls.Add(this.tbx);
			this.t1.Location = new System.Drawing.Point(4, 24);
			this.t1.Name = "t1";
			this.t1.Padding = new System.Windows.Forms.Padding(3);
			this.t1.Size = new System.Drawing.Size(261, 232);
			this.t1.TabIndex = 0;
			this.t1.Text = "1";
			this.t1.UseVisualStyleBackColor = true;
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(15, 108);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(222, 23);
			this.button.TabIndex = 2;
			this.button.Text = "Выполнить";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// tby
			// 
			this.tby.Location = new System.Drawing.Point(137, 69);
			this.tby.Name = "tby";
			this.tby.PlaceholderText = "Y";
			this.tby.Size = new System.Drawing.Size(100, 23);
			this.tby.TabIndex = 1;
			// 
			// tbx
			// 
			this.tbx.Location = new System.Drawing.Point(15, 69);
			this.tbx.Name = "tbx";
			this.tbx.PlaceholderText = "X";
			this.tbx.Size = new System.Drawing.Size(100, 23);
			this.tbx.TabIndex = 0;
			// 
			// t2
			// 
			this.t2.Controls.Add(this.label1);
			this.t2.Controls.Add(this.button2);
			this.t2.Controls.Add(this.res);
			this.t2.Controls.Add(this.tb2);
			this.t2.Location = new System.Drawing.Point(4, 24);
			this.t2.Name = "t2";
			this.t2.Padding = new System.Windows.Forms.Padding(3);
			this.t2.Size = new System.Drawing.Size(261, 232);
			this.t2.TabIndex = 1;
			this.t2.Text = "2";
			this.t2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 30);
			this.label1.TabIndex = 3;
			this.label1.Text = "Введите целое двузначное положительное \r\nчисло в пятиричной системе счисления";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 107);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(249, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Выполнить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// res
			// 
			this.res.Location = new System.Drawing.Point(6, 136);
			this.res.Name = "res";
			this.res.PlaceholderText = "Результат";
			this.res.Size = new System.Drawing.Size(249, 23);
			this.res.TabIndex = 1;
			// 
			// tb2
			// 
			this.tb2.Location = new System.Drawing.Point(6, 78);
			this.tb2.Name = "tb2";
			this.tb2.Size = new System.Drawing.Size(249, 23);
			this.tb2.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 284);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.t1.ResumeLayout(false);
			this.t1.PerformLayout();
			this.t2.ResumeLayout(false);
			this.t2.PerformLayout();
			this.ResumeLayout(false);

	}

	#endregion

	private TabControl tabControl1;
	private TabPage t1;
	private TextBox tby;
	private TextBox tbx;
	private TabPage t2;
	private Button button;
	private Button button2;
	private TextBox res;
	private TextBox tb2;
	private Label label1;
}
