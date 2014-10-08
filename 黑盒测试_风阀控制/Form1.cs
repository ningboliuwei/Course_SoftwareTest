using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 黑盒测试_风阀控制
{
	public partial class Form1 : Form
	{
		private bool fengfaOn = false;

		private bool fengjiOn = false;

		private bool famenOn = false;

		private bool bengOn = false;

		private bool liuchengOn = false;




		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtBeng.BackColor = Color.LightCoral;
			txtFengji.BackColor = Color.LightCoral;
			txtFamen.BackColor = Color.LightCoral;
			txtFengfa.BackColor = Color.LightGreen;
			txtLiucheng.BackColor = Color.LightCoral;

			lblLiuliang.Text = "流量 (" + trackBarLiuliang.Value + ")";
			lblYali.Text = "压力 (" + trackBarYali.Value + ")";
			lblWendu.Text = "温度 (" + trackBarWendu.Value + ")";

			fengfaOn = true;

			this.ChangeState();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bengOn = !bengOn;

			if (bengOn)
			{
				btnBeng.Text = "关闭泵";
				txtBeng.BackColor = Color.LightGreen;
			}
			else
			{
				btnBeng.Text = "打开泵";
				txtBeng.BackColor = Color.LightCoral;
			}

			ChangeState();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			bengOn = !bengOn;

			if (bengOn)
			{
				btnFengji.Text = "关闭风机";
				txtFengji.BackColor = Color.LightGreen;
			}
			else
			{
				btnFengji.Text = "打开风机";
				txtFengji.BackColor = Color.LightCoral;
			}

			ChangeState();
		}



		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			lblLiuliang.Text = "流量 (" + trackBarLiuliang.Value + ")";
			ChangeState();
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			lblYali.Text = "压力 (" + trackBarYali.Value + ")";
			ChangeState();
		}

		private void trackBar3_Scroll(object sender, EventArgs e)
		{
			lblWendu.Text = "温度 (" + trackBarWendu.Value + ")";
			ChangeState();
		}

		private void ChangeState()
		{
			if (bengOn || trackBarLiuliang.Value > 10 || trackBarYali.Value > 20)
			{
				famenOn = true;
			}
			else
			{
				famenOn = false;
			}

			if (fengjiOn == false && trackBarWendu.Value < 100)
			{
				fengfaOn = false;
			}
			else
			{
				fengfaOn = true;
			}

			if (famenOn && fengfaOn)
			{
				liuchengOn = true;
			}
			else
			{
				liuchengOn = false;
			}

			if (famenOn)
			{
				txtFamen.BackColor = Color.LightGreen;
			}
			else
			{
				txtFamen.BackColor = Color.LightCoral;
			}

			if (fengfaOn)
			{
				txtFengfa.BackColor = Color.LightGreen;
			}
			else
			{
				txtFengfa.BackColor = Color.LightCoral;
			}

			if (liuchengOn)
			{
				txtLiucheng.BackColor = Color.LightGreen;
			}
			else
			{
				txtLiucheng.BackColor = Color.LightCoral;
			}

		}
	}


}
