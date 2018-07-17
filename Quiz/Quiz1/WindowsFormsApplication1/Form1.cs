using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				MessageBox.Show("さすが天才", "正解！",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
			}
			else if (radioButton2.Checked)
			{
				MessageBox.Show("ぶっぶー", "不正解",MessageBoxButtons.OK,MessageBoxIcon.Hand);
			}
			else if(radioButton3.Checked)
			{
				MessageBox.Show("残念", "不正解",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show("何か選択せぃ","答える意欲を見せよ");
			}
		}

	}
}
