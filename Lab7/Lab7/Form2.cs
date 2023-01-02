using System;
using System.Windows.Forms;

namespace Lab7 {
	public partial class Form2 : Form {
		public Form2 () {
			InitializeComponent();
		}

		private void button_Click (object sender, EventArgs e) {
			dgv.Rows.Clear();
			dgv.Columns.Clear();

			for (int j = 0; j < 2; j++)
				dgv.Columns.Add("", "");
			dgv.Rows.Add(10);

			double step = (1 - 0.1) / 10;

			int i = 0;
			for (double x = 0.1; x <= 1; x += step) {
				if (i > 10)
					break;
				dgv.Rows[i].Cells[0].Value = CountY(x);
				dgv.Rows[i].Cells[1].Value = Sum(x, 10);
				i++;
			}
		}

		private double CountY (double x) {
			return Math.Sin(x);
		}

		private double Sum (double x, int n) {
			if (n == 0)
				return Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1);

			return Math.Pow(-1, n) * (Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1)) + Sum(x, n - 1);
		}

		public long Factorial (long n) {
			if (n == 0)
				return 1;
			else
				return n * Factorial(n - 1);
		}
	}
}
