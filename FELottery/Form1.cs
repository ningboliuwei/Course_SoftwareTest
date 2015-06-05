using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FELottery
{
	public partial class Form1 : Form
	{
		private static string[] elements = { "系统设置+宿舍管理", "数据维护+资助管理", "班级管理", "日常事务管理", "卫生检查相关", "奖惩管理", "迎新模块", "综合申请" };

		private static int index;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = !timer1.Enabled;

			if (timer1.Enabled)
			{
				button1.Text = "停止";
			}
			else
			{
				button1.Text = "开始";
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			textBox1.Text = elements[index];
			index++;
			if (index == elements.Count())
			{
				index = 0;
			}


		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.Text = elements[index];
		}
	}
}
