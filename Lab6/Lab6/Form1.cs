using System;
using System.Windows.Forms;

namespace Lab6 {
	public partial class Form1 : Form {
		public Form1 () {
			InitializeComponent();
		}

		double[,] matrix = new double[4, 5];

		private void button1_Click (object sender, EventArgs e) {
			sourceDGV.Rows.Clear();
			sourceDGV.Columns.Clear();

			Random rnd = new Random();

			for (int j = 0; j < 5; j++) {
				sourceDGV.Columns.Add("", "");
			}

			sourceDGV.Rows.Add(4);

			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 5; j++) {
					matrix[i, j] = rnd.NextDouble() * 100;
					sourceDGV.Rows[i].Cells[j].Value = Math.Round(matrix[i, j], 4);
				}
			}
		}

		private void button2_Click (object sender, EventArgs e) {
			int maxi = 0;
			int maxj = 0;
			int mini = 0;
			int minj = 0;
			double max = 0;
			double min = matrix[0, 0];
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 5; j++) {
					if (matrix[i, j] > max) {
						max = matrix[i, j];
						maxi = i;
						maxj = j;
					}
					if (matrix[i, j] < min) {
						min = matrix[i, j];
						mini = i;
						minj = j;
					}
				}
			}

			matrix[maxi, maxj] = min;
			matrix[mini, minj] = max;

			dGV.Rows.Clear();
			dGV.Columns.Clear();

			for (int j = 0; j < 5; j++) {
				dGV.Columns.Add("", "");
			}

			dGV.Rows.Add(4);

			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 5; j++) {
					dGV.Rows[i].Cells[j].Value = Math.Round(matrix[i, j], 4);
				}
			}
		}
	}
}
