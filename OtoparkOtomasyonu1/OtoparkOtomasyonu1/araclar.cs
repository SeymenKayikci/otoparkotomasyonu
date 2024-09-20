using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtoparkOtomasyonu1
{
	public partial class araclar : Form
	{
		public SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-93FUJMN;Initial Catalog=otoparkOtomasyonu;Integrated Security=True");
		public SqlCommand komut;
		public SqlDataReader oku;
		string connectionString = ("Server=DESKTOP-93FUJMN;Database=otoparkOtomasyonu;Trusted_Connection=True;");
		public araclar()
		{
			InitializeComponent();
		}

		void temizle()
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox6.Clear();
		}
		public void veriGoster()
		{
			aracClass ac = new aracClass();
			DataTable table = ac.goster();
			dataGridView1.DataSource = table;
		}

		private void araclar_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'otoparkOtomasyonuDataSet.arac' table. You can move, or remove it, as needed.
            this.aracTableAdapter.Fill(this.otoparkOtomasyonuDataSet.arac);
			veriGoster();

        }

		private void button2_Click(object sender, EventArgs e)
		{
			aracClass ac = new aracClass();
			ac.aracEkle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox6.Text);
			veriGoster();
			temizle();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			aracClass ac = new aracClass();
			ac.aracGuncelle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text,textBox6.Text);
			veriGoster();
			temizle();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			aracClass mc = new aracClass();
			mc.aracSil(Convert.ToInt32(textBox1.Text));
			veriGoster();
			temizle();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// TextBox'tan plaka bilgisini al
			string plaka = textBox2.Text.Trim();

			
			using (SqlConnection connection = new SqlConnection(connectionString)) 
			{
				try
				{
					
					string query = "SELECT * FROM arac WHERE arac_plaka = @arac_plaka";

					
					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@arac_plaka", plaka);

					// Bağlantıyı aç
					connection.Open();

					// SqlDataReader ile sorguyu çalıştır ve sonuçları al
					SqlDataReader reader = command.ExecuteReader();

					if (reader.Read()) 
					{
						MessageBox.Show("Plaka Otoparkımızda mevcut.");
					}
					else
					{
						MessageBox.Show("Plaka Otoparkımızda mevcut değil.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bir hata oluştu: " + ex.Message);
				}
			}
		}
	}
}
