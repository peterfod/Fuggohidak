
namespace Fuggohidak
{
	partial class frmFuggohidak2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnBezaras = new System.Windows.Forms.Button();
			this.cmbOrszag = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnKereses = new System.Windows.Forms.Button();
			this.chb1000 = new System.Windows.Forms.CheckBox();
			this.lblOrszag = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBezaras
			// 
			this.btnBezaras.Location = new System.Drawing.Point(265, 116);
			this.btnBezaras.Name = "btnBezaras";
			this.btnBezaras.Size = new System.Drawing.Size(75, 23);
			this.btnBezaras.TabIndex = 0;
			this.btnBezaras.Text = "Bezárás";
			this.btnBezaras.UseVisualStyleBackColor = true;
			this.btnBezaras.Click += new System.EventHandler(this.btnBezaras_Click);
			// 
			// cmbOrszag
			// 
			this.cmbOrszag.FormattingEnabled = true;
			this.cmbOrszag.Location = new System.Drawing.Point(90, 27);
			this.cmbOrszag.Name = "cmbOrszag";
			this.cmbOrszag.Size = new System.Drawing.Size(121, 23);
			this.cmbOrszag.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnKereses);
			this.groupBox1.Controls.Add(this.chb1000);
			this.groupBox1.Controls.Add(this.btnBezaras);
			this.groupBox1.Controls.Add(this.lblOrszag);
			this.groupBox1.Controls.Add(this.cmbOrszag);
			this.groupBox1.Location = new System.Drawing.Point(47, 257);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(406, 170);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Keresés";
			// 
			// btnKereses
			// 
			this.btnKereses.Location = new System.Drawing.Point(89, 116);
			this.btnKereses.Name = "btnKereses";
			this.btnKereses.Size = new System.Drawing.Size(75, 23);
			this.btnKereses.TabIndex = 6;
			this.btnKereses.Text = "Keresés";
			this.btnKereses.UseVisualStyleBackColor = true;
			this.btnKereses.Click += new System.EventHandler(this.btnKereses_Click);
			// 
			// chb1000
			// 
			this.chb1000.AutoSize = true;
			this.chb1000.Location = new System.Drawing.Point(27, 75);
			this.chb1000.Name = "chb1000";
			this.chb1000.Size = new System.Drawing.Size(137, 19);
			this.chb1000.TabIndex = 5;
			this.chb1000.Text = "1 km-nél hosszabbak";
			this.chb1000.UseVisualStyleBackColor = true;
			// 
			// lblOrszag
			// 
			this.lblOrszag.AutoSize = true;
			this.lblOrszag.Location = new System.Drawing.Point(27, 30);
			this.lblOrszag.Name = "lblOrszag";
			this.lblOrszag.Size = new System.Drawing.Size(43, 15);
			this.lblOrszag.TabIndex = 4;
			this.lblOrszag.Text = "Ország";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(45, 16);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(407, 217);
			this.richTextBox1.TabIndex = 5;
			this.richTextBox1.Text = "";
			// 
			// frmFuggohidak2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 447);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmFuggohidak2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Keresés";
			this.Load += new System.EventHandler(this.frmFuggohidak2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBezaras;
		private System.Windows.Forms.ComboBox cmbOrszag;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnKereses;
		private System.Windows.Forms.CheckBox chb1000;
		private System.Windows.Forms.Label lblOrszag;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}