using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab5 {
	public partial class Form2 : Form {
		public Form2 () {
			InitializeComponent();
		}

		int n;
		int[] a, b;
		List<int> indexes;

		private void button1_Click (object sender, EventArgs e) {
			if (int.TryParse(textBox1.Text, out int num))
				n = num;
			else {
				textBox2.Text = "Неверный формат данных";
				return;
			}

			textBox2.Text = "";
			Random rnd = new Random();
			for (int i = 0; i < n; i++) {
				if (i < n - 1)
					textBox2.Text += $"{rnd.Next(100)} ";
				else
					textBox2.Text += $"{rnd.Next(100)}";
			}
		}

		private void button2_Click (object sender, EventArgs e) {
			if (int.TryParse(textBox1.Text, out int num))
				n = num;
			else {
				textBox3.Text = "Неверный формат данных";
				return;
			}

			if (textBox2.Text.Split().Length == n) {
				a = new int[n];
				for (int i = 0; i < n; i++) {
					if (int.TryParse(textBox2.Text.Split()[i], out int anum))
						a[i] = anum;
					else {
						textBox3.Text = "Неверный формат данных";
						return;
					}
				}
			} else {
				textBox3.Text = "Неверный формат данных";
				return;
			}

			indexes = new List<int>();
			for (int i = 0; i < n; i++) {
				int[] tmp = new int[n - i - 1];
				for (int j = 0; j < tmp.Length; j++)
					tmp[j] = a[i + j + 1];

				if (tmp.Contains(a[i])) {
					if (indexes.Contains(i))
						continue;
					indexes.Add(i);
					for (int j = 0; j < tmp.Length; j++) {
						if (tmp[j] == a[i])
							indexes.Add(i + j + 1);
					}
				}
			}

			b = new int[a.Length - indexes.Count];
			int bi = 0;
			for (int i = 0; i < a.Length; i++) {
				if (indexes.Contains(i))
					continue;
				else {
					b[bi] = a[i];
					bi++;
				}
			}

			textBox3.Text = "";
			foreach (int bn in b)
				textBox3.Text += $"{bn} ";
		}
	}
}
