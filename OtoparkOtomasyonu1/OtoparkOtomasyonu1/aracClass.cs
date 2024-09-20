using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtoparkOtomasyonu1
{
	internal class aracClass
	{
		veritabani vt = new veritabani();

		public DataTable goster()
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Select * From arac", vt.baglan);
				vt.oku = vt.komut.ExecuteReader();
				DataTable tablo = new DataTable();
				tablo.Load(vt.oku);
				vt.baglantiKapa();
				return tablo;
			}
			catch (Exception)
			{
				MessageBox.Show("arac classinda goster metodunda hata var");
				throw;
			}
		}
		public void aracEkle(int id, string plaka, string renk, string model,string yil)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Insert into arac (arac_id,arac_plaka,renk,model,yil) values (@arac_id,@arac_plaka,@renk,@model,@yil)", vt.baglan);
				vt.komut.Parameters.AddWithValue("@arac_id", id);
				vt.komut.Parameters.AddWithValue("@arac_plaka", plaka);
				vt.komut.Parameters.AddWithValue("@renk", renk);
				vt.komut.Parameters.AddWithValue("@model", model);
				vt.komut.Parameters.AddWithValue("@yil", yil);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("arac classinda arac ekle bolumunde hata var");
				throw;
			}
			finally
			{
				MessageBox.Show("kayit basarili");
			}
		}

		public void aracSil(int id)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Delete from arac where arac_id=@arac_id", vt.baglan);
				vt.komut.Parameters.AddWithValue("@arac_id", id);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("arac classında aracsil bolumunde hata var");
				throw;
			}
			finally
			{
				MessageBox.Show("Silme islemi basarili");
			}
		}
		public void aracGuncelle(int id, string plaka, string renk, string model, string yil)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Update arac set arac_id=@arac_id,arac_plaka=@arac_plaka,renk=@renk,model=@model,yil=@yil Where arac_id=@arac_id", vt.baglan);
				vt.komut.Parameters.AddWithValue("@arac_id", id);
				vt.komut.Parameters.AddWithValue("@arac_plaka", plaka);
				vt.komut.Parameters.AddWithValue("@renk", renk);
				vt.komut.Parameters.AddWithValue("@model", model);
				vt.komut.Parameters.AddWithValue("@yil", yil);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("arac classinda arac guncelle bolumunde hata");
				throw;
			}
			finally
			{
				MessageBox.Show("Guncelleme islemi basarili");
			}
		}
	}
}

