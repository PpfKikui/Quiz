using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	public partial class Form1 : Form
	{
		int n = 1;
		double a = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			n = n + 1;

			if (n == 2)
			{
				if (radioButton2.Checked)
				{
					a = a + 1;
				}

				label1.Text = "問題２　２＋２＝？";
				radioButton1.Text = "４";
				radioButton2.Text = "５";
				radioButton3.Text = "６";
			}
			else if (n == 3)
			{
				if (radioButton1.Checked)
				{
					a = a + 1;
				}

				label1.Text = "問題３　１＋２＝？";
				radioButton1.Text = "４";
				radioButton2.Text = "５";
				radioButton3.Text = "３";
			}
			else if (n == 4)
			{
				if (radioButton3.Checked)
				{
					a = a + 1;
				}

				label1.Text = "最終問題　３＋３＝？";
				radioButton1.Text = "６";
				radioButton2.Text = "７";
				radioButton3.Text = "８";
				button1.Text = "結果を見てみる";
			}
			else if (n == 5)
			{
				if (radioButton1.Checked)
				{
					a = a + 1;
				}
				double b = a / 4 * 100;

				MessageBox.Show("お疲れ様でした。\r\n正解した数は" + a.ToString() + "個。"
					+"\r\n正解率は"+b.ToString()+"パーセントでした。", "結果はっぴょー");
			}

			/*
			switch (n)
			{
				case 2:
					label1.Text = "問題２　２＋２＝？";
					radioButton1.Text = "４";
					radioButton2.Text = "５";
					radioButton3.Text = "６";
					break;
				case 3:
					label1.Text = "問題３　２＋２＝？";
					radioButton1.Text = "４";
					radioButton2.Text = "５";
					radioButton3.Text = "６";
					break;
			}
			*/
		}
	}
}
