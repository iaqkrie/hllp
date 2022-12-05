using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7 {
	public partial class Form2 : Form {
		public Form2 () {
			InitializeComponent();
		}

		private void button_Click (object sender, EventArgs e) {
			textBox1.Text = $"{CountY(1)} {Sum(1, 10)}";
		}

		private double CountY (double x) {
			return Math.Sin(x);
		}

		private double Sum (double x, int n) {
			if (n == 1)
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
