using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				textBox1.Font = new Font(radioButton2.Text, textBox1.Font.Size, textBox1.Font.Style);
			}
		}

		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{

			if (radioButton1.Checked)
			{
				textBox1.Font = new Font(radioButton1.Text, textBox1.Font.Size, textBox1.Font.Style);
			}
		}

		private void GroupBox1_Enter(object sender, EventArgs e)
		{

	
		}

		private void RadioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
			{
				textBox1.Font = new Font(textBox1.Font.Name,int.Parse(radioButton3.Text), textBox1.Font.Style);
			}
		}

		private void RadioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton4.Checked)
			{
				textBox1.Font = new Font(textBox1.Font.Name, int.Parse(radioButton4.Text), textBox1.Font.Style);
			}
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, FontStyle.Bold);
			}
			else
			{
				textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, FontStyle.Regular);
			}
		}
	}
}
