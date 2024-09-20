using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace OtoparkOtomasyonu1
{
	internal class veritabani
	{
		public SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-93FUJMN;Initial Catalog=otoparkOtomasyonu;Integrated Security=True");
		public SqlCommand komut;
		public SqlDataReader oku;

		public void baglantiAc()
		{
			try
			{
				if (baglan.State ==ConnectionState.Closed)
				{
					baglan.Open();
				}
				
			}
			catch (Exception)
			{
				MessageBox.Show("Veritabanı classında bağlantı aç kısmında hata var !");
				throw;
			}
		}
		public void baglantiKapa()
		{
			try
			{
				if (baglan.State == ConnectionState.Open)
				{
					baglan.Close();
				}

			}
			catch (Exception)
			{
				MessageBox.Show("Veritabanı classında bağlantı kapa kısmında hata var !");
				throw;
			}
		}
	}
}
