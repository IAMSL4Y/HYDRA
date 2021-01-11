using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HYDRA
{
	public partial class MForm : Form
	{
		public MForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.TopMost = true;			
		}
		
		void Button1Click(object sender, EventArgs e)
		{	
			Form1 h1 = new Form1();	
			Form2 h2 = new Form2();
			Form3 h3 = new Form3();
			
			h1.Show();	
			h2.Show();
			h3.Show();
			this.Hide();
		}
		
		void Mclose(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}
	}
}
