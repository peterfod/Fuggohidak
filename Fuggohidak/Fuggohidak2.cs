using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuggohidak
{
	public partial class frmFuggohidak2 : Form
	{
		public frmFuggohidak2()
		{
			InitializeComponent();
		}

		//7. feladat
		private void frmFuggohidak2_Load(object sender, EventArgs e)
		{
			foreach (var item in frmFuggohidak1.lista)
			{
				if (!cmbOrszag.Items.Contains(item.Orszag))
				{
					cmbOrszag.Items.Add(item.Orszag);
				}
			}
		}

		//8. feladat
		private void btnKereses_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			foreach (var item in frmFuggohidak1.lista)
			{
				if (item.Orszag.Contains(cmbOrszag.Text))
				{
					if (chb1000.Checked && item.Hossz>1000)
					{
						richTextBox1.Text += item.Hid + "\n";
					}
					if (!chb1000.Checked)
					{
						richTextBox1.Text += item.Hid + "\n";
					}					
				}
			}
		}

		private void btnBezaras_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
