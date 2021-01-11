using System;
using System.Drawing;
using System.Windows.Forms;

namespace HYDRA
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		
		void Form2Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;	
			this.TopMost = true;			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MForm h1 = new MForm();	
			Form1 h2 = new Form1();
			Form3 h3 = new Form3();
			
			h1.Show();	
			h2.Show();
			h3.Show();
			this.Hide();			
		}
		
		
		
		void F2close(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}
	}
}
