
namespace Fuggohidak
{
	partial class frmFuggohidak1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuKereses = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuKilepes = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.lblHely = new System.Windows.Forms.Label();
			this.txbHely = new System.Windows.Forms.TextBox();
			this.txbEv = new System.Windows.Forms.TextBox();
			this.lblHossz = new System.Windows.Forms.Label();
			this.txbHossz = new System.Windows.Forms.TextBox();
			this.lblEv = new System.Windows.Forms.Label();
			this.txbOrszag = new System.Windows.Forms.TextBox();
			this.lblOrszag = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblDarab = new System.Windows.Forms.Label();
			this.txbdarab = new System.Windows.Forms.TextBox();
			this.rbn2000utan = new System.Windows.Forms.RadioButton();
			this.rbn2000elott = new System.Windows.Forms.RadioButton();
			this.btnKilepes = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKereses,
            this.mnuKilepes});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(496, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuKereses
			// 
			this.mnuKereses.Name = "mnuKereses";
			this.mnuKereses.Size = new System.Drawing.Size(58, 20);
			this.mnuKereses.Text = "Keresés";
			this.mnuKereses.Click += new System.EventHandler(this.mnuKereses_Click);
			// 
			// mnuKilepes
			// 
			this.mnuKilepes.Name = "mnuKilepes";
			this.mnuKilepes.Size = new System.Drawing.Size(56, 20);
			this.mnuKilepes.Text = "Kilépés";
			this.mnuKilepes.Click += new System.EventHandler(this.mnuKilepes_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(23, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(242, 214);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// lblHely
			// 
			this.lblHely.AutoSize = true;
			this.lblHely.Location = new System.Drawing.Point(296, 39);
			this.lblHely.Name = "lblHely";
			this.lblHely.Size = new System.Drawing.Size(31, 15);
			this.lblHely.TabIndex = 2;
			this.lblHely.Text = "Hely";
			// 
			// txbHely
			// 
			this.txbHely.Location = new System.Drawing.Point(346, 36);
			this.txbHely.Name = "txbHely";
			this.txbHely.Size = new System.Drawing.Size(100, 23);
			this.txbHely.TabIndex = 3;
			// 
			// txbEv
			// 
			this.txbEv.Location = new System.Drawing.Point(346, 205);
			this.txbEv.Name = "txbEv";
			this.txbEv.Size = new System.Drawing.Size(100, 23);
			this.txbEv.TabIndex = 5;
			// 
			// lblHossz
			// 
			this.lblHossz.AutoSize = true;
			this.lblHossz.Location = new System.Drawing.Point(296, 147);
			this.lblHossz.Name = "lblHossz";
			this.lblHossz.Size = new System.Drawing.Size(38, 15);
			this.lblHossz.TabIndex = 4;
			this.lblHossz.Text = "Hossz";
			// 
			// txbHossz
			// 
			this.txbHossz.Location = new System.Drawing.Point(346, 144);
			this.txbHossz.Name = "txbHossz";
			this.txbHossz.Size = new System.Drawing.Size(100, 23);
			this.txbHossz.TabIndex = 7;
			// 
			// lblEv
			// 
			this.lblEv.AutoSize = true;
			this.lblEv.Location = new System.Drawing.Point(296, 208);
			this.lblEv.Name = "lblEv";
			this.lblEv.Size = new System.Drawing.Size(19, 15);
			this.lblEv.TabIndex = 6;
			this.lblEv.Text = "Év";
			// 
			// txbOrszag
			// 
			this.txbOrszag.Location = new System.Drawing.Point(346, 88);
			this.txbOrszag.Name = "txbOrszag";
			this.txbOrszag.Size = new System.Drawing.Size(100, 23);
			this.txbOrszag.TabIndex = 9;
			// 
			// lblOrszag
			// 
			this.lblOrszag.AutoSize = true;
			this.lblOrszag.Location = new System.Drawing.Point(296, 91);
			this.lblOrszag.Name = "lblOrszag";
			this.lblOrszag.Size = new System.Drawing.Size(43, 15);
			this.lblOrszag.TabIndex = 8;
			this.lblOrszag.Text = "Ország";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblDarab);
			this.groupBox1.Controls.Add(this.txbdarab);
			this.groupBox1.Controls.Add(this.rbn2000utan);
			this.groupBox1.Controls.Add(this.rbn2000elott);
			this.groupBox1.Location = new System.Drawing.Point(23, 277);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(242, 146);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hidak száma";
			// 
			// lblDarab
			// 
			this.lblDarab.AutoSize = true;
			this.lblDarab.Location = new System.Drawing.Point(137, 109);
			this.lblDarab.Name = "lblDarab";
			this.lblDarab.Size = new System.Drawing.Size(37, 15);
			this.lblDarab.TabIndex = 14;
			this.lblDarab.Text = "darab";
			// 
			// txbdarab
			// 
			this.txbdarab.Location = new System.Drawing.Point(31, 106);
			this.txbdarab.Name = "txbdarab";
			this.txbdarab.Size = new System.Drawing.Size(100, 23);
			this.txbdarab.TabIndex = 13;
			// 
			// rbn2000utan
			// 
			this.rbn2000utan.AutoSize = true;
			this.rbn2000utan.Location = new System.Drawing.Point(31, 69);
			this.rbn2000utan.Name = "rbn2000utan";
			this.rbn2000utan.Size = new System.Drawing.Size(135, 19);
			this.rbn2000utan.TabIndex = 12;
			this.rbn2000utan.Text = "2000-ben vagy utána";
			this.rbn2000utan.UseVisualStyleBackColor = true;
			this.rbn2000utan.CheckedChanged += new System.EventHandler(this.rbn2000utan_CheckedChanged);
			// 
			// rbn2000elott
			// 
			this.rbn2000elott.AutoSize = true;
			this.rbn2000elott.Location = new System.Drawing.Point(31, 35);
			this.rbn2000elott.Name = "rbn2000elott";
			this.rbn2000elott.Size = new System.Drawing.Size(106, 19);
			this.rbn2000elott.TabIndex = 11;
			this.rbn2000elott.Text = "2000 előtt épült";
			this.rbn2000elott.UseVisualStyleBackColor = true;
			this.rbn2000elott.CheckedChanged += new System.EventHandler(this.rbn2000elott_CheckedChanged);
			// 
			// btnKilepes
			// 
			this.btnKilepes.Location = new System.Drawing.Point(346, 342);
			this.btnKilepes.Name = "btnKilepes";
			this.btnKilepes.Size = new System.Drawing.Size(75, 23);
			this.btnKilepes.TabIndex = 12;
			this.btnKilepes.Text = "Kilépés";
			this.btnKilepes.UseVisualStyleBackColor = true;
			this.btnKilepes.Click += new System.EventHandler(this.mnuKilepes_Click);
			// 
			// frmFuggohidak1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 447);
			this.Controls.Add(this.btnKilepes);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txbOrszag);
			this.Controls.Add(this.lblOrszag);
			this.Controls.Add(this.txbHossz);
			this.Controls.Add(this.lblEv);
			this.Controls.Add(this.txbEv);
			this.Controls.Add(this.lblHossz);
			this.Controls.Add(this.txbHely);
			this.Controls.Add(this.lblHely);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmFuggohidak1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Függőhidak";
			this.Load += new System.EventHandler(this.frmFuggohidak1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label lblHely;
		private System.Windows.Forms.TextBox txbHely;
		private System.Windows.Forms.TextBox txbEv;
		private System.Windows.Forms.Label lblHossz;
		private System.Windows.Forms.TextBox txbHossz;
		private System.Windows.Forms.Label lblEv;
		private System.Windows.Forms.TextBox txbOrszag;
		private System.Windows.Forms.Label lblOrszag;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbn2000utan;
		private System.Windows.Forms.RadioButton rbn2000elott;
		private System.Windows.Forms.Label lblDarab;
		private System.Windows.Forms.TextBox txbdarab;
		private System.Windows.Forms.ToolStripMenuItem mnuKereses;
		private System.Windows.Forms.Button btnKilepes;
		private System.Windows.Forms.ToolStripMenuItem mnuKilepes;
	}
}

