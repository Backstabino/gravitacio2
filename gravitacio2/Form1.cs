using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gravitacio2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Bitmap kep = new Bitmap(palya.Width, palya.Height);
			Graphics gr = Graphics.FromImage(kep);
			Pen toll = new Pen(Color.White);	
			gr.DrawLine(toll, new Point(0, 0), new Point(100, 100));
			palya.Image = kep;	
			palya.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void palya_Click(object sender, EventArgs e)
		{
			bolygo b = new bolygo("Hektor", Color.Green, 100, new Vektor(200, 300),new Vektor(1.2, 0.5) );
		}
	}
}
