using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2_2
{
	public partial class Form1 : Form
	{
			List<string> kazu = new List<string>();
			List<string> question = new List<string>();
			List<string> ans1 = new List<string>();
			List<string> ans2 = new List<string>();
			List<string> ans3 = new List<string>();

		public Form1()
		{
			InitializeComponent();

			kazu.Add("問１");
			kazu.Add("問２");
			kazu.Add("問３");
			kazu.Add("最終問題");

			question.Add("「ゼロの使い魔」のヒロインの名前は？");
			ans1.Add("ルイズ・フランソワーズ・ル・ブラン・ド・ラ・ヴァリエール");
			ans2.Add("ルイズ・フランソワーズ・ラ・ショコラ・ド・ラ・カラミナフ");
			ans3.Add("ルイズ・フランソワーズ・ル・カラム・ド・ラ・シャルロット");

			question.Add("「ラブライブ！」μ'sの曲で恋愛ソングなのはどれ？");
			ans1.Add("それは僕たちの奇跡");
			ans2.Add("Snow Halation");
			ans3.Add("SUNNY DAY SONG");

			question.Add("「シティハンター」海坊主の本名は？");
			ans1.Add("海野春樹");
			ans2.Add("白鳥一馬");
			ans3.Add("伊集院隼人");

			question.Add("「けいおん！」の中野梓がギターを始めたのはいつから？");
			ans1.Add("小学4年生");
			ans2.Add("小学5年生");
			ans3.Add("小学6年生");

			//表示
			label1.Text = kazu[0];
			label2.Text = question[0];
			radioButton1.Text = ans1[0];
			radioButton2.Text = ans2[0];
			radioButton3.Text = ans3[0];
			button1.Text = "答える";
		}

		int mondaisuu = 0;
		int seikaisuu = 0;

		private void button1_Click(object sender, EventArgs e)
		{
			mondaisuu++;

			if (mondaisuu <= 3)
			{
			label1.Text = kazu[mondaisuu];
			label2.Text = question[mondaisuu];
			radioButton1.Text = ans1[mondaisuu];
			radioButton2.Text = ans2[mondaisuu];
			radioButton3.Text = ans3[mondaisuu];
			button1.Text = "答える";
			}

			if (mondaisuu == 1 && radioButton1.Checked)
			{
				seikaisuu++;
			}

			if (mondaisuu == 2 && radioButton2.Checked)
			{
				seikaisuu++;
			}

			if (mondaisuu == 3)
			{
				button1.Text = "結果をみる";

				if (radioButton3.Checked)
				{
					seikaisuu++;
				}
			}

			if (mondaisuu == 4)
			{
				if (radioButton1.Checked)
				{
					seikaisuu++;
				}

				float seitouritu = (float)seikaisuu / 4 * 100;

				MessageBox.Show("正解数は" + seikaisuu+"個。\r\n正答率は"+seitouritu+"％です。");
			}
		}
	}
}
