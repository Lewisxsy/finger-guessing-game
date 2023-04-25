using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _02猜拳小游戏
{
	public class Form1 : Form
	{
		private IContainer components = null;

		private Label label1;

		private Label lbl_user;

		private Label label3;

		private Label lbl_computer;

		private Label lbl_result;

		private Button button1;

		private Button button2;

		private Button button3;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UserPlayer userPlayer = new UserPlayer();
			int user = userPlayer.ShowFist(((Button)sender).Text);
			lbl_user.Text = userPlayer.FistName;
			ComputerPlayer computerPlayer = new ComputerPlayer();
			int computer = computerPlayer.ShowFist();
			lbl_computer.Text = computerPlayer.FistName;
			Judge judge = new Judge();
			lbl_result.Text = judge.IsUserWin(user, computer);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			label1 = new System.Windows.Forms.Label();
			lbl_user = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			lbl_computer = new System.Windows.Forms.Label();
			lbl_result = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("宋体", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			label1.Location = new System.Drawing.Point(121, 90);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(99, 28);
			label1.TabIndex = 0;
			label1.Text = "用户：";
			lbl_user.AutoSize = true;
			lbl_user.Font = new System.Drawing.Font("宋体", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			lbl_user.Location = new System.Drawing.Point(273, 90);
			lbl_user.Name = "lbl_user";
			lbl_user.Size = new System.Drawing.Size(0, 28);
			lbl_user.TabIndex = 0;
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("宋体", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			label3.Location = new System.Drawing.Point(472, 90);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(99, 28);
			label3.TabIndex = 0;
			label3.Text = "电脑：";
			lbl_computer.AutoSize = true;
			lbl_computer.Font = new System.Drawing.Font("宋体", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			lbl_computer.Location = new System.Drawing.Point(605, 90);
			lbl_computer.Name = "lbl_computer";
			lbl_computer.Size = new System.Drawing.Size(0, 28);
			lbl_computer.TabIndex = 0;
			lbl_result.AutoSize = true;
			lbl_result.Font = new System.Drawing.Font("宋体", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			lbl_result.Location = new System.Drawing.Point(363, 202);
			lbl_result.Name = "lbl_result";
			lbl_result.Size = new System.Drawing.Size(0, 28);
			lbl_result.TabIndex = 0;
			button1.Font = new System.Drawing.Font("宋体", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			button1.Location = new System.Drawing.Point(126, 295);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(127, 42);
			button1.TabIndex = 1;
			button1.Text = "石头";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			button2.Font = new System.Drawing.Font("宋体", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			button2.Location = new System.Drawing.Point(338, 295);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(127, 42);
			button2.TabIndex = 1;
			button2.Text = "剪刀";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button1_Click);
			button3.Font = new System.Drawing.Font("宋体", 16.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			button3.Location = new System.Drawing.Point(541, 295);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(127, 42);
			button3.TabIndex = 1;
			button3.Text = "布";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(button1_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(800, 450);
			base.Controls.Add(button3);
			base.Controls.Add(button2);
			base.Controls.Add(button1);
			base.Controls.Add(lbl_computer);
			base.Controls.Add(label3);
			base.Controls.Add(lbl_result);
			base.Controls.Add(lbl_user);
			base.Controls.Add(label1);
			base.Name = "Form1";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "猜拳小游戏";
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
