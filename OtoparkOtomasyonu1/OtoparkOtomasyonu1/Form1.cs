using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			araclar formAraclar = new araclar();
			formAraclar.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			musteri formMusteri= new musteri();
			formMusteri.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			abonelik formAbonelik= new abonelik();
			formAbonelik.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			hizmet formHizmet= new hizmet();
			formHizmet.Show();
		}
	}
}
