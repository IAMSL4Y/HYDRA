using System;
using System.Drawing;
using System.Windows.Forms;

namespace HYDRA
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
		
		void Form3Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;				
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MForm h1 = new MForm();	
			Form1 h2 = new Form1();
			Form2 h3 = new Form2();
			
			h1.Show();	
			h2.Show();
			h3.Show();
			this.Hide();			
		}
		
		void F3close(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}
		
	}
}
