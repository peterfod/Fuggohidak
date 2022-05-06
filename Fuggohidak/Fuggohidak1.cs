using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuggohidak
{
	public partial class frmFuggohidak1 : Form
	{
		public static List<Fuggohid> lista = new List<Fuggohid>(); //2. feladat
		public static string fajlnev { get; set; }

		public frmFuggohidak1()
		{
			InitializeComponent();
		}

		//2. feladat
		private void frmFuggohidak1_Load(object sender, EventArgs e)
		{
			StreamReader sr = new StreamReader("fuggohidak.csv");
			string elsosor = sr.ReadLine();
			while (!sr.EndOfStream)
			{
				Fuggohid sor = new Fuggohid(sr.ReadLine());
				lista.Add(sor);
				listBox1.Items.Add(sor.Hid); //3. feladat
			}
			sr.Close();
		}

		//3. feladat
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			txbHely.Text = lista[listBox1.SelectedIndex].Hely;
			txbOrszag.Text = lista[listBox1.SelectedIndex].Orszag;
			txbHossz.Text = lista[listBox1.SelectedIndex].Hossz.ToString();
			txbEv.Text = lista[listBox1.SelectedIndex].Ev;
		}

		//4. feladat
		private void rbn2000elott_CheckedChanged(object sender, EventArgs e)
		{
			if (rbn2000elott.Checked)
			{
				int darab = 0;
				foreach (var item in lista)
				{
					if (int.Parse(item.Ev) < 2000)
					{
						darab++;
					}
				}
				txbdarab.Text = darab.ToString();
			}
		}

		private void rbn2000utan_CheckedChanged(object sender, EventArgs e)
		{
			if (rbn2000utan.Checked)
			{
				int darab = 0;
				foreach (var item in lista)
				{
					if (int.Parse(item.Ev) >= 2000)
					{
						darab++;
					}
				}
				txbdarab.Text = darab.ToString();
			}
		}

		//5. feladat
		private void mnuKilepes_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//6. feladat
		private void mnuKereses_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmFuggohidak2 kereses = new frmFuggohidak2();
			kereses.ShowDialog();
			kereses.Dispose();
			this.Show();
		}
	}

	//1. feladat
	public class Fuggohid
	{
		public string Helyezes { get; set; }
		public string Hid { get; set; }
		public string Hely { get; set; }
		public string Orszag { get; set; }
		public int Hossz { get; set; }
		public string Ev { get; set; }

		public Fuggohid(string sor)
		{
			string[] reszek = sor.Split('\t');
			Helyezes = reszek[0];
			Hid = reszek[1];
			Hely = reszek[2];
			Orszag = reszek[3];
			Hossz = Convert.ToInt32(reszek[4]);
			Ev = reszek[5];
		}
	}
}
