using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace gravitacio2
{
	class bolygo
	{
		public string nev;
		public double m;
		public Color szin;
		public Vektor hely;
		public Vektor v;
		Label nevcimke;
		Label mcimke;
		Label helycimke;
		Label vcimke;


		
		public bolygo(string nev, Color szin, double m, Vektor hely, Vektor v, Panel panel)
		{
			this.nev = nev;
			this.szin = szin;
			this.m = m;
			this.hely = hely;
			this.v = v;
			this.nevcimke = new Label();
			nevcimke.Text = this.nev;
			this.nevcimke.Location = new Point(0, 10);
			panel.Controls.Add(nevcimke);



			this.mcimke = new Label();
			mcimke.Text = $"{this.m} Mt";
			panel.Controls.Add(mcimke);



			this.helycimke = new Label();
			helycimke.Text = $"{hely.X}, {hely.Y}";
			panel.Controls.Add(helycimke);



			this.vcimke = new Label();
			vcimke.Text = $"{v.X}, {v.Y}";
			panel.Controls.Add(vcimke);
		}
	}
}
