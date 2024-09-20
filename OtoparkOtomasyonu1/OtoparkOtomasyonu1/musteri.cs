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
	public partial class musteri : Form
	{
		public musteri()
		{
			InitializeComponent();
		}

		void temizle()
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
		}
		public void veriGoster()
		{
			mustericlass mc = new mustericlass();
			DataTable table = mc.goster();
			dataGridView1.DataSource = table;
		}

		private void musteri_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'otoparkOtomasyonuDataSet.musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.otoparkOtomasyonuDataSet.musteri);
			veriGoster();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			mustericlass mc= new mustericlass();
			mc.musteriEkle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
			veriGoster();
			temizle();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			mustericlass mc = new mustericlass();
			mc.musteriGuncelle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
			veriGoster();
			temizle();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			mustericlass mc = new mustericlass();
			mc.musteriSil(Convert.ToInt32(textBox1.Text));
			veriGoster();
			temizle();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
		}
	}
}
