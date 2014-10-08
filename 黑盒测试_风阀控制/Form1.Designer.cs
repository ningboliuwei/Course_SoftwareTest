namespace 黑盒测试_风阀控制
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblLiuliang = new System.Windows.Forms.Label();
			this.trackBarLiuliang = new System.Windows.Forms.TrackBar();
			this.lblYali = new System.Windows.Forms.Label();
			this.trackBarYali = new System.Windows.Forms.TrackBar();
			this.lblWendu = new System.Windows.Forms.Label();
			this.trackBarWendu = new System.Windows.Forms.TrackBar();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBeng = new System.Windows.Forms.TextBox();
			this.btnBeng = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFengji = new System.Windows.Forms.TextBox();
			this.btnFengji = new System.Windows.Forms.Button();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFamen = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFengfa = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtLiucheng = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarLiuliang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarYali)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarWendu)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 317);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.lblLiuliang);
			this.flowLayoutPanel2.Controls.Add(this.trackBarLiuliang);
			this.flowLayoutPanel2.Controls.Add(this.lblYali);
			this.flowLayoutPanel2.Controls.Add(this.trackBarYali);
			this.flowLayoutPanel2.Controls.Add(this.lblWendu);
			this.flowLayoutPanel2.Controls.Add(this.trackBarWendu);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 236);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(1123, 55);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// lblLiuliang
			// 
			this.lblLiuliang.AutoSize = true;
			this.lblLiuliang.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblLiuliang.Location = new System.Drawing.Point(3, 0);
			this.lblLiuliang.Name = "lblLiuliang";
			this.lblLiuliang.Size = new System.Drawing.Size(69, 35);
			this.lblLiuliang.TabIndex = 1;
			this.lblLiuliang.Text = "流量";
			// 
			// trackBarLiuliang
			// 
			this.trackBarLiuliang.Location = new System.Drawing.Point(78, 3);
			this.trackBarLiuliang.Maximum = 30;
			this.trackBarLiuliang.Name = "trackBarLiuliang";
			this.trackBarLiuliang.Size = new System.Drawing.Size(202, 45);
			this.trackBarLiuliang.TabIndex = 2;
			this.trackBarLiuliang.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// lblYali
			// 
			this.lblYali.AutoSize = true;
			this.lblYali.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblYali.Location = new System.Drawing.Point(286, 0);
			this.lblYali.Name = "lblYali";
			this.lblYali.Size = new System.Drawing.Size(69, 35);
			this.lblYali.TabIndex = 3;
			this.lblYali.Text = "压力";
			// 
			// trackBarYali
			// 
			this.trackBarYali.Location = new System.Drawing.Point(361, 3);
			this.trackBarYali.Maximum = 30;
			this.trackBarYali.Name = "trackBarYali";
			this.trackBarYali.Size = new System.Drawing.Size(202, 45);
			this.trackBarYali.TabIndex = 0;
			this.trackBarYali.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// lblWendu
			// 
			this.lblWendu.AutoSize = true;
			this.lblWendu.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblWendu.Location = new System.Drawing.Point(569, 0);
			this.lblWendu.Name = "lblWendu";
			this.lblWendu.Size = new System.Drawing.Size(69, 35);
			this.lblWendu.TabIndex = 4;
			this.lblWendu.Text = "温度";
			// 
			// trackBarWendu
			// 
			this.trackBarWendu.Location = new System.Drawing.Point(644, 3);
			this.trackBarWendu.Maximum = 200;
			this.trackBarWendu.Name = "trackBarWendu";
			this.trackBarWendu.Size = new System.Drawing.Size(202, 45);
			this.trackBarWendu.TabIndex = 5;
			this.trackBarWendu.TickFrequency = 5;
			this.trackBarWendu.Scroll += new System.EventHandler(this.trackBar3_Scroll);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.txtBeng);
			this.flowLayoutPanel1.Controls.Add(this.btnBeng);
			this.flowLayoutPanel1.Controls.Add(this.label4);
			this.flowLayoutPanel1.Controls.Add(this.txtFengji);
			this.flowLayoutPanel1.Controls.Add(this.btnFengji);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 109);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1123, 121);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 75);
			this.label1.TabIndex = 0;
			this.label1.Text = "泵";
			// 
			// txtBeng
			// 
			this.txtBeng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtBeng.Location = new System.Drawing.Point(97, 3);
			this.txtBeng.Multiline = true;
			this.txtBeng.Name = "txtBeng";
			this.txtBeng.Size = new System.Drawing.Size(100, 81);
			this.txtBeng.TabIndex = 1;
			// 
			// btnBeng
			// 
			this.btnBeng.Location = new System.Drawing.Point(203, 3);
			this.btnBeng.Name = "btnBeng";
			this.btnBeng.Size = new System.Drawing.Size(77, 81);
			this.btnBeng.TabIndex = 2;
			this.btnBeng.Text = "打开泵";
			this.btnBeng.UseVisualStyleBackColor = true;
			this.btnBeng.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(286, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 75);
			this.label4.TabIndex = 3;
			this.label4.Text = "风机";
			// 
			// txtFengji
			// 
			this.txtFengji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtFengji.Location = new System.Drawing.Point(436, 3);
			this.txtFengji.Multiline = true;
			this.txtFengji.Name = "txtFengji";
			this.txtFengji.Size = new System.Drawing.Size(100, 81);
			this.txtFengji.TabIndex = 4;
			// 
			// btnFengji
			// 
			this.btnFengji.Location = new System.Drawing.Point(542, 3);
			this.btnFengji.Name = "btnFengji";
			this.btnFengji.Size = new System.Drawing.Size(77, 81);
			this.btnFengji.TabIndex = 5;
			this.btnFengji.Text = "打开风机";
			this.btnFengji.UseVisualStyleBackColor = true;
			this.btnFengji.Click += new System.EventHandler(this.button2_Click);
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.label6);
			this.flowLayoutPanel3.Controls.Add(this.txtFamen);
			this.flowLayoutPanel3.Controls.Add(this.label7);
			this.flowLayoutPanel3.Controls.Add(this.txtFengfa);
			this.flowLayoutPanel3.Controls.Add(this.label8);
			this.flowLayoutPanel3.Controls.Add(this.txtLiucheng);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(1123, 100);
			this.flowLayoutPanel3.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 75);
			this.label6.TabIndex = 8;
			this.label6.Text = "阀门";
			// 
			// txtFamen
			// 
			this.txtFamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtFamen.Location = new System.Drawing.Point(153, 3);
			this.txtFamen.Multiline = true;
			this.txtFamen.Name = "txtFamen";
			this.txtFamen.Size = new System.Drawing.Size(100, 81);
			this.txtFamen.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(259, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 75);
			this.label7.TabIndex = 10;
			this.label7.Text = "风阀";
			// 
			// txtFengfa
			// 
			this.txtFengfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtFengfa.Location = new System.Drawing.Point(409, 3);
			this.txtFengfa.Multiline = true;
			this.txtFengfa.Name = "txtFengfa";
			this.txtFengfa.Size = new System.Drawing.Size(100, 81);
			this.txtFengfa.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(515, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 75);
			this.label8.TabIndex = 12;
			this.label8.Text = "流程";
			// 
			// txtLiucheng
			// 
			this.txtLiucheng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtLiucheng.Location = new System.Drawing.Point(665, 3);
			this.txtLiucheng.Multiline = true;
			this.txtLiucheng.Name = "txtLiucheng";
			this.txtLiucheng.Size = new System.Drawing.Size(100, 81);
			this.txtLiucheng.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1129, 317);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarLiuliang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarYali)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarWendu)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label lblLiuliang;
		private System.Windows.Forms.TrackBar trackBarLiuliang;
		private System.Windows.Forms.Label lblYali;
		private System.Windows.Forms.TrackBar trackBarYali;
		private System.Windows.Forms.Label lblWendu;
		private System.Windows.Forms.TrackBar trackBarWendu;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBeng;
		private System.Windows.Forms.Button btnBeng;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFengji;
		private System.Windows.Forms.Button btnFengji;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFamen;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtFengfa;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtLiucheng;

	}
}

