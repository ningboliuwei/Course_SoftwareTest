using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM模拟
{
	public partial class Form1 : Form
	{
		private int balance = 12000;

		public Form1()
		{
			InitializeComponent();
		}

		private void button21_Click(object sender, EventArgs e)
		{
			ShowPasswordScreen();
			button21.Enabled = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ShowInitialScreen();
		}

		private void ShowInitialScreen() //初始界面
		{
			ClearMenu();

			label1.Visible = true; 
			label1.Text = "欢迎使用ATM机";
			textBox1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
			label5.Visible = false;

			button21.Enabled = true;
			
			
		}

		private void ShowPasswordScreen()
		{
			textBox1.Text = "";


			label1.Text = "请输入密码";
			label1.Visible = true;

			textBox1.Visible = true;
			textBox1.PasswordChar = '*';
			textBox1.Focus();
			ClearMenu();

		}

		private void ShowAmountScreen()
		{
			textBox1.Visible = true;
			textBox1.PasswordChar = '\0';
			ShowInfo("请输入金额\n（必须为100的倍数）");
			textBox1.Focus();
			textBox1.Clear();

			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
			label5.Visible = true;
			label5.Text = "返回";

			
		}

		private void ShowMainMenu()
		{
			ClearMenu();

			textBox1.Visible = false;
			label1.Visible = false;

			label2.Visible = true;
			label2.Text = "取款";

			label3.Visible = true;
			label3.Text = "查询";

			label4.Visible = false;

			label5.Visible = true;
			label5.Text = "取消";

			
		}

		private void ShowPasswordErrorScreen()
		{
			ShowInfo("密码错误，请重新输入");
			textBox1.Text = "";
			textBox1.Focus();

			ClearMenu();
		}

		private void ShowInfo(string infoText)
		{
			label1.Visible = true;
			label1.Text = infoText;
		}

		private void ShowWithDrawScreen()
		{

			ClearMenu();

			textBox1.Visible = false;
			label1.Visible = false;

			label2.Visible = true;
			label2.Text = "100";

			label3.Visible = true;
			label3.Text = "200";

			label4.Visible = true;
			label4.Text = "500";

			label5.Visible = true;
			label5.Text = "自定";
		}

		private void button16_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				int amount = 0;
				//重新输入可以作为一个bug
				if (label1.Text == "请输入密码" || label1.Text == "密码错误，请重新输入") //当前要求用户输入密码且密码为“123456”
				{
					if (textBox1.Text == "123456")
					{
						ShowMainMenu();
					}
					else
					{
						ShowPasswordErrorScreen();
					}
				}
				else if (label1.Text.Contains("金额"))
				{
					if (textBox1.Text.Contains(".") == false)
					{
						amount = Convert.ToInt32(textBox1.Text.Trim());
					}

					//此处为bug 输入小数点后出错
					if (textBox1.Text.Contains("."))
					{
						ShowInfo("系统崩溃");
						textBox1.Visible = false;
					}
					else if (amount % 50 != 0) //输入的金额不是50的倍数（此处为bug，实际应为100倍数）
					{

						ShowInfo("输入的金额必须为100的倍数\n请重新输入");
						textBox1.Text = "";
						textBox1.Focus();
					}
					else if (amount > balance) 
					{
						ShowInfo("您的金额不足\n请重新输入");
						textBox1.Text = "";
						textBox1.Focus();
					}
					else
					{
						MessageBox.Show(string.Format("吐出{0}元钱", amount));
						ShowMainMenu();
						balance = balance - amount;
					}
				}
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				if (label3.Text == "查询")
				{
					ShowMoney();
				}
				else if (label3.Text == "200") //此处2bug，一个是不作余额检查，另一个是选择200，实际余额只少了100
				{
					MessageBox.Show(string.Format("吐出{0}元钱", 200));
					ShowMainMenu();
					balance = balance - 100;
				}
			}
		}

		private void ShowMoney()
		{
			label3.Visible = true;
			label3.Text = balance.ToString();

			label5.Visible = true;
			label5.Text = "返回";

			ShowInfo("您的余额为");
		}

		private void button20_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				if (label5.Text == "取消")
				{
					MessageBox.Show("卡已退出");
					ShowInitialScreen();
				}
				else if (label5.Text == "返回")
				{
					if (label3.Text == balance.ToString()) //之前是查询余额
					{
						ShowMainMenu(); //返回后显示主菜单
					}
					else if (label3.Text == "200") //之前是输入金额
					{
						ShowWithDrawScreen(); //返回后显示选择取款金额菜单
					}
				}
				else if (label5.Text == "自定")
				{
					ShowAmountScreen();
				}
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				if (label2.Text == "取款")//此处bug，不作余额检查
				{
					ShowWithDrawScreen();
				}
				else if (label2.Text == "100")
				{
					MessageBox.Show(string.Format("吐出{0}元钱", 100));
					ShowMainMenu();
					balance = balance - 100;
				}
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "1";
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "2";
			}
		}


		private void button3_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "3";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "4";
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "5";
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "6";
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "7";
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "8";
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "9";
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + ".";
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "0";
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				textBox1.Text = textBox1.Text + "00";
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				if (label1.Text.Contains("密码"))
				{
					textBox1.Clear();
				}

				if (label2.Text == "100") //在金额选择界面
				{
					ShowMainMenu();
				}
			}
		}

		private void button19_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
				if (500 > balance)
				{
					ShowInfo("您的金额不足\n请重新输入");
					textBox1.Text = "";
					textBox1.Focus();
				}
				else if (label4.Text == "500") //此处为bug 取500，只吐了400
				{
					MessageBox.Show(string.Format("吐出{0}元钱", 400));
					ShowMainMenu();
					balance = balance - 500;
				}
			}
		}

		private void button22_Click(object sender, EventArgs e)
		{

			button21.Enabled = false;
			ShowInfo("插卡错误，请重新插卡");
			System.Threading.Thread.Sleep(1000);
			MessageBox.Show("卡已吐");
			button21.Enabled = true;
			ShowInitialScreen();

		}

		private void ClearMenu()
		{
			label2.Visible = false;
			label2.Text = "";

			label3.Visible = false;
			label3.Text = "";

			label4.Visible = false;
			label4.Text = "";

			label5.Visible = false;
			label5.Text = "";

		}

		private bool CheckCard()
		{
			if (button21.Enabled == true)
			{
				ShowInfo("请先插卡");
				//System.Threading.Thread.Sleep(1000);
				MessageBox.Show("好吧，我知道了，插卡先");
				ShowInitialScreen();
				return false;
			}
			else
			{
				return true;
			}

		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			if (CheckCard())
			{
			}
		}
	}
}