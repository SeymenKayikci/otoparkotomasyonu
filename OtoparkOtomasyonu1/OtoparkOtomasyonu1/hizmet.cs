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
	public partial class hizmet : Form
	{
		public hizmet()
		{
			InitializeComponent();
		}

		void temizle()
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
		}
		public void veriGoster()
		{
			aracClass ac = new aracClass();
			DataTable table = ac.goster();
			dataGridView1.DataSource = table;
		}

		private void hizmet_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'otoparkOtomasyonuDataSet.hizmet' table. You can move, or remove it, as needed.
            this.hizmetTableAdapter.Fill(this.otoparkOtomasyonuDataSet.hizmet);
			veriGoster();

        }

		private void button1_Click(object sender, EventArgs e)
		{
			hizmetClass hc = new hizmetClass();
			hc.hizmetEkle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox6.Text,textBox5.Text);
			veriGoster();
			temizle();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			hizmetClass hc = new hizmetClass();
			hc.hizmetGuncelle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox6.Text,textBox5.Text);
			veriGoster();
			temizle();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			hizmetClass hc = new hizmetClass();
			hc.hizmetSil(Convert.ToInt32(textBox1.Text));
			veriGoster();
			temizle();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
		}
	}
}
