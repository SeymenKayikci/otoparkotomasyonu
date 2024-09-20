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
	internal class mustericlass
	{
		veritabani vt=new veritabani();

		public DataTable goster()
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Select * From Musteri", vt.baglan);
				vt.oku = vt.komut.ExecuteReader();
				DataTable tablo = new DataTable();
				tablo.Load(vt.oku);
				vt.baglantiKapa();
				return tablo;
			}
			catch (Exception)
			{
				MessageBox.Show("Musteri classinda goster metodunda hata var");
				throw;
			}
		}
		public void musteriEkle(int id, string adSoyad,string adres,string tel)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Insert into musteri (musteri_id,musteri_ad_soyad,adres,tel_no) values (@musteri_id,@musteri_ad_soyad,@adres,@tel_no)", vt.baglan);
				vt.komut.Parameters.AddWithValue("@musteri_id", id);
				vt.komut.Parameters.AddWithValue("@musteri_ad_soyad", adSoyad);
				vt.komut.Parameters.AddWithValue("@adres", adres);
				vt.komut.Parameters.AddWithValue("@tel_no", tel);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("Musteri classinda musteri ekle bolumunde hata var");
				throw;
			}
			finally
			{
				MessageBox.Show("kayit basarili");
			}
		}

		public void musteriSil(int id)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Delete from musteri where musteri_id=@musteri_id",vt.baglan);
				vt.komut.Parameters.AddWithValue("@musteri_id", id);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("Musteri classında musterisil bolumunde hata var");
				throw;
			}
			finally
			{
				MessageBox.Show("Silme islemi basarili");
			}
		}
		public void musteriGuncelle(int id, string adSoyad, string adres, string tel)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Update musteri set musteri_id=@musteri_id,musteri_ad_soyad=@musteri_ad_soyad,adres=@adres,tel_no=@tel_no Where musteri_id=@musteri_id", vt.baglan);
				vt.komut.Parameters.AddWithValue("@musteri_id", id);
				vt.komut.Parameters.AddWithValue("@musteri_ad_soyad", adSoyad);
				vt.komut.Parameters.AddWithValue("@adres", adres);
				vt.komut.Parameters.AddWithValue("@tel_no", tel);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();	
			}
			catch (Exception)
			{
				MessageBox.Show("Musteri classinda musteri guncelle bolumunde hata");
				throw;
			}
			finally
			{
				MessageBox.Show("Guncelleme islemi basarili");
			}
		}
	}
}
