using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Clock
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (cdShowCheck.Checked == true)
			{
				label1.Text = DateTime.Now.ToString("HH:mm:ss");
			}
			else
			{
				label1.Text = DateTime.Now.ToString();
			}
		}

		private void cdShowCheck_CheckedChanged(object sender, EventArgs e)
		{
			//if (cdShowCheck.Checked == true)
			//{
			//	label1.Text = DateTime.Now.ToString("HH:mm:ss");
			//}
			//else
			//{
			//	label1.Text = DateTime.Now.ToString("HH:ss:mm");
			//}
		}
	}
}
