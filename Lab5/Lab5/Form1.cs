using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab5 {
	public partial class Form1 : Form {
		public Form1 () {
			InitializeComponent();
		}

		int[] arr = new int[15];
		int[] newArr = new int[15];
		int am;

		private void button1_Click (object sender, EventArgs e) {
			Random rnd = new Random();
			textBox1.Text = "";
			for (int i = 0; i < 15; i++)
				textBox1.Text += $"{rnd.Next(20)} ";
		}

		private void button2_Click (object sender, EventArgs e) {
			if (textBox1.Text.Split().Length < 15) {
				textBox2.Text = "Неверный формат";
				return;
			}
			for (int i = 0; i < 15; i++) {
				if (int.TryParse(textBox1.Text.Split()[i], out int n))
					arr[i] = n;
				else {
					textBox2.Text = "Неверный формат";
					return;
				}
			}
			am = arr.Sum() / arr.Length;
			int min = 101;
			foreach (int n in arr)
				if (n < min)
					min = n;
			for (int i = 0; i < 15; i++) {
				if (arr[i] == min)
					newArr[i] = am;
				else
					newArr[i] = arr[i];
			}

			textBox2.Text = "";
			foreach (int n in newArr)
				textBox2.Text += $"{n} ";
		}
	}
}
