namespace Lab3;

public partial class Form1 : Form {
	public Form1 () {
		InitializeComponent();
	}

	private void button_Click (object sender, EventArgs e) {
		double x, y;

		if (tbx.Text == "" || tby.Text == "")
			return;

		if (double.TryParse(tbx.Text, out _) && double.TryParse(tby.Text, out _)) {
			x = double.Parse(tbx.Text);
			y = double.Parse(tby.Text);
		} else
			return;

		if (x > 0 && y > 0) {
			x /= 5; y /= 5;
		} else if (x >= -3 && x <= 9 && y >= -3 && y <= 9) {
			x = 0; y = 0;
		} else {
			x += 3; y += 3;
		}

		tbx.Text = x.ToString();
		tby.Text = y.ToString();
	}

	string[] eng = new string[5] {"zero", "one", "two", "three", "four"};
	string[] rus = new string[5] {"ноль", "один", "два", "три", "четыре"};

	private void button2_Click (object sender, EventArgs e) {
		int num;
		if (int.TryParse(tb2.Text, out int n)) {
			if (n.ToString().Length > 2) {
				res.Text = "Неверный формат числа";
				return;
			}
			num = n;
		} else {
			res.Text = "Неверный формат числа";
			return;
		}

		if (num.ToString().Contains('5') || num.ToString().Contains('6') || num.ToString().Contains('7') || num.ToString().Contains('8') || num.ToString().Contains('9')) {
			res.Text = "Неверный формат числа";
			return;
		}

		if (num / 10 / (num % 10) == 2)
			res.Text = $"{eng[num / 10]}, {eng[num % 10]}";
		else
			res.Text = $"{rus[num / 10]}, {rus[num % 10]}";
	}
}
