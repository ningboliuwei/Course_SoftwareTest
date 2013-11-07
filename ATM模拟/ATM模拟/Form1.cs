namespace ATM模拟
{
	using System;
	using System.Threading;
	using System.Windows.Forms;

	public partial class Form1 : Form
	{
		#region Fields

		private int balance = 12000;

		#endregion

		#region Constructors and Destructors

		public Form1()
		{
			this.InitializeComponent();
		}

		#endregion

		#region Methods

		private bool CheckCard()
		{
			if (this.button21.Enabled)
			{
				this.ShowInfo("请先插卡");
				//System.Threading.Thread.Sleep(1000);
				MessageBox.Show("好吧，我知道了，插卡先");
				this.ShowInitialScreen();
				return false;
			}
			return true;
		}

		private void ClearMenu()
		{
			this.label2.Visible = false;
			this.label2.Text = "";

			this.label3.Visible = false;
			this.label3.Text = "";

			this.label4.Visible = false;
			this.label4.Text = "";

			this.label5.Visible = false;
			this.label5.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.ShowInitialScreen();
		}

		private void ShowAmountScreen()
		{
			this.textBox1.Visible = true;
			this.textBox1.PasswordChar = '\0';
			this.ShowInfo("请输入金额\n（必须为100的倍数）");
			this.textBox1.Focus();
			this.textBox1.Clear();

			this.label2.Visible = false;
			this.label3.Visible = false;
			this.label4.Visible = false;
			this.label5.Visible = true;
			this.label5.Text = "返回";
		}

		private void ShowInfo(string infoText)
		{
			this.label1.Visible = true;
			this.label1.Text = infoText;
		}

		private void ShowInitialScreen() //初始界面
		{
			this.ClearMenu();

			this.label1.Visible = true;
			this.label1.Text = "欢迎使用ATM机";
			this.textBox1.Visible = false;
			this.label2.Visible = false;
			this.label3.Visible = false;
			this.label4.Visible = false;
			this.label5.Visible = false;

			this.button21.Enabled = true;
		}

		private void ShowMainMenu()
		{
			this.ClearMenu();

			this.textBox1.Visible = false;
			this.label1.Visible = false;

			this.label2.Visible = true;
			this.label2.Text = "取款";

			this.label3.Visible = true;
			this.label3.Text = "查询";

			this.label4.Visible = false;

			this.label5.Visible = true;
			this.label5.Text = "取消";
		}

		private void ShowMoney()
		{
			this.label3.Visible = true;
			this.label3.Text = this.balance.ToString();

			this.label5.Visible = true;
			this.label5.Text = "返回";

			this.ShowInfo("您的余额为");
		}

		private void ShowPasswordErrorScreen()
		{
			this.ShowInfo("密码错误，请重新输入");
			this.textBox1.Text = "";
			this.textBox1.Focus();

			this.ClearMenu();
		}

		private void ShowPasswordScreen()
		{
			this.textBox1.Text = "";

			this.label1.Text = "请输入密码";
			this.label1.Visible = true;

			this.textBox1.Visible = true;
			this.textBox1.PasswordChar = '*';
			this.textBox1.Focus();
			this.ClearMenu();
		}

		private void ShowWithDrawScreen()
		{
			this.ClearMenu();

			this.textBox1.Visible = false;
			this.label1.Visible = false;

			this.label2.Visible = true;
			this.label2.Text = "100";

			this.label3.Visible = true;
			this.label3.Text = "200";

			this.label4.Visible = true;
			this.label4.Text = "500";

			this.label5.Visible = true;
			this.label5.Text = "自定";
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "8";
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "9";
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + ".";
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "0";
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "00";
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				int amount = 0;
				//重新输入可以作为一个bug
				if (this.label1.Text == "请输入密码" || this.label1.Text == "密码错误，请重新输入") //当前要求用户输入密码且密码为“123456”
				{
					if (this.textBox1.Text == "123456")
					{
						this.ShowMainMenu();
					}
					else
					{
						this.ShowPasswordErrorScreen();
					}
				}
				else if (this.label1.Text.Contains("金额"))
				{
					if (this.textBox1.Text.Contains(".") == false)
					{
						amount = Convert.ToInt32(this.textBox1.Text.Trim());
					}

					//此处为bug 输入小数点后出错
					if (this.textBox1.Text.Contains("."))
					{
						this.ShowInfo("系统崩溃");
						this.textBox1.Visible = false;
					}
					else if (amount % 50 != 0) //输入的金额不是50的倍数（此处为bug，实际应为100倍数）
					{
						this.ShowInfo("输入的金额必须为100的倍数\n请重新输入");
						this.textBox1.Text = "";
						this.textBox1.Focus();
					}
					else if (amount > this.balance)
					{
						this.ShowInfo("您的金额不足\n请重新输入");
						this.textBox1.Text = "";
						this.textBox1.Focus();
					}
					else
					{
						MessageBox.Show(string.Format("吐出{0}元钱", amount));
						this.ShowMainMenu();
						this.balance = this.balance - amount;
					}
				}
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				if (this.label2.Text == "取款") //此处bug，不作余额检查
				{
					this.ShowWithDrawScreen();
				}
				else if (this.label2.Text == "100")
				{
					MessageBox.Show(string.Format("吐出{0}元钱", 100));
					this.ShowMainMenu();
					this.balance = this.balance - 100;
				}
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				if (this.label3.Text == "查询")
				{
					this.ShowMoney();
				}
				else if (this.label3.Text == "200") //此处2bug，一个是不作余额检查，另一个是选择200，实际余额只少了100
				{
					MessageBox.Show(string.Format("吐出{0}元钱", 200));
					this.ShowMainMenu();
					this.balance = this.balance - 100;
				}
			}
		}

		private void button19_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				if (500 > this.balance)
				{
					this.ShowInfo("您的金额不足\n请重新输入");
					this.textBox1.Text = "";
					this.textBox1.Focus();
				}
				else if (this.label4.Text == "500") //此处为bug 取500，只吐了400
				{
					MessageBox.Show(string.Format("吐出{0}元钱", 400));
					this.ShowMainMenu();
					this.balance = this.balance - 500;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "1";
			}
		}

		private void button20_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				if (this.label5.Text == "取消")
				{
					MessageBox.Show("卡已退出");
					this.ShowInitialScreen();
				}
				else if (this.label5.Text == "返回")
				{
					if (this.label3.Text == this.balance.ToString()) //之前是查询余额
					{
						this.ShowMainMenu(); //返回后显示主菜单
					}
					else if (this.label3.Text == "200") //之前是输入金额
					{
						this.ShowWithDrawScreen(); //返回后显示选择取款金额菜单
					}
				}
				else if (this.label5.Text == "自定")
				{
					this.ShowAmountScreen();
				}
			}
		}

		private void button21_Click(object sender, EventArgs e)
		{
			this.ShowPasswordScreen();
			this.button21.Enabled = false;
		}

		private void button22_Click(object sender, EventArgs e)
		{
			this.button21.Enabled = false;
			this.ShowInfo("插卡错误，请重新插卡");
			Thread.Sleep(1000);
			MessageBox.Show("卡已吐");
			this.button21.Enabled = true;
			this.ShowInitialScreen();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "2";
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "3";
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				if (this.label1.Text.Contains("密码"))
				{
					this.textBox1.Clear();
				}

				if (this.label2.Text == "100") //在金额选择界面
				{
					this.ShowMainMenu();
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "4";
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "5";
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "6";
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (this.CheckCard())
			{
				this.textBox1.Text = this.textBox1.Text + "7";
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		#endregion
	}
}