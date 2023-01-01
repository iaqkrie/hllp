using System;
using System.Windows.Forms;

namespace Lab6 {
	public partial class Form2 : Form {
		public Form2 () {
			InitializeComponent();
		}

		int n, m;
		double[][] matrix;

		private void button1_Click (object sender, EventArgs e) {
			n = int.Parse(ntb.Text);
			m = int.Parse(mtb.Text);
			matrix = new double[n][];
			for (int i = 0; i < n; i++)
				matrix[i] = new double[m];

			Random rnd = new Random();

			sdgv.Rows.Clear();
			sdgv.Columns.Clear();

			for (int i = 0; i < m; i++) {
				sdgv.Columns.Add("", "");
			}
			sdgv.Rows.Add(n);

			for (int i = 0; i < n; i++) {
				for (int j = 0; j < m; j++) {
					matrix[i][j] = Math.Round(rnd.NextDouble() * 100, 4);
					sdgv.Rows[i].Cells[j].Value = matrix[i][j];
				}
			}
		}

		private void button2_Click (object sender, EventArgs e) {
			double[] maxValues = new double[n];
			for (int i = 0; i < n; i++) {
				double maxV = 0;
				for (int j = 0; j < m; j++) {
					if (matrix[i][j] > maxV) {
						maxV = matrix[i][j];
					}
				}
				maxValues[i] = maxV;
			}

			for (int i = n - 1; i >= 0; i--) {
				for (int j = 0; j < i; j++) {
					if (maxValues[j] > maxValues[j + 1]) {
						double tmpV = maxValues[j];
						maxValues[j] = maxValues[j + 1];
						maxValues[j + 1] = tmpV;
						double[] tmpR = matrix[j];
						matrix[j] = matrix[j + 1];
						matrix[j + 1] = tmpR;
					}
				}
			}

			dgv.Rows.Clear();
			dgv.Columns.Clear();

			for (int i = 0; i < m; i++) {
				dgv.Columns.Add("", "");
			}
			dgv.Rows.Add(n);

			for (int i = 0; i < n; i++) {
				for (int j = 0; j < m; j++) {
					dgv.Rows[i].Cells[j].Value = matrix[i][j];
				}
			}
		}
	}
}
