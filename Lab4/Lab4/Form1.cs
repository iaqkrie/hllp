using System;
using System.Windows.Forms;

namespace Lab4 {
	public partial class Form1 : Form {
		public Form1 () {
			InitializeComponent();
		}

		int n;
		bool p;
		private void button1_Click (object sender, EventArgs e) {
			if (int.TryParse(textBox1.Text, out int num)) n = num;
			else {
				textBox2.Text = "Неверный формат";
				return;
			}

			if (n <= 1) {
				textBox2.Text = "Неверный формат";
				return;
			}

			p = true;
			for (int i = 2; i <= n / 2; i++) {
				if (n % i == 0)
					p = false;
			}

			textBox2.Text = p.ToString();
		}
	}
}
