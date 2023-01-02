using System;
using System.Windows.Forms;

namespace Lab7 {
	public partial class Form1 : Form {
		public Form1 () {
			InitializeComponent();
		}

		int nb;
		double[] b;

		private void button1_Click (object sender, EventArgs e) {
			nb = int.Parse(nbtb.Text);
			b = new double[nb];

			Random rnd = new Random();

			btb.Text = "";

			for (int i = 0; i < nb; i++) {
				b[i] = Math.Round(rnd.NextDouble() * 100, 2);
				btb.Text += b[i].ToString() + (i == nb - 1 ? "" : "; ");
			}
		}

		private void button2_Click (object sender, EventArgs e) {
			res.Text = num_elem(b, nb).ToString();
		}

		private int num_elem (double[] a, int n) {
			int maxI = 0;
			double maxV = a[0];
			for (int i = 0; i < n; i++) {
				if (a[i] > maxV) {
					maxV = a[i];
					maxI = i;
				}
			}

			return maxI;
		}
	}
}
