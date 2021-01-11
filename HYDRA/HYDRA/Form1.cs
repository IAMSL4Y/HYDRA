using System;
using System.Drawing;
using System.Windows.Forms;

namespace HYDRA
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.TopMost = true;			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MForm h1 = new MForm();	
			Form2 h2 = new Form2();
			Form3 h3 = new Form3();
			
			h1.Show();	
			h2.Show();
			h3.Show();
			this.Hide();			
		}
		
		void hydra1_close(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}
	}
}
