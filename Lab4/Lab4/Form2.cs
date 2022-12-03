using System;
using System.Windows.Forms;

namespace Lab4 {
	public partial class Form2 : Form {
		public Form2 () {
			InitializeComponent();
		}

		int x, n;
		private void button1_Click (object sender, EventArgs e) {
			if (int.TryParse(textBox1.Text, out int xv) && xv >= 0)
				x = xv;
			else {
				textBox3.Text = "Неверный формат";
				return;
			}

			if (int.TryParse(textBox2.Text, out int nv) && nv >= 0)
				n = nv;
			else {
				textBox3.Text = "Неверный формат";
				return;
			}

			double sum = 0;
			for (int i = 1; i < 10; i++) {
				for (int j = 1; j < n; j++) {
					sum += Math.Sin(Math.Pow(x, 5) + Math.Pow(j, 4)) + 5;
				}
			}

			textBox3.Text = sum.ToString();
		}
	}
}
