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
	internal class abonelikClass
	{
		veritabani vt=new veritabani();

		public DataTable goster()
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Select * From abonelik", vt.baglan);
				vt.oku = vt.komut.ExecuteReader();
				DataTable tablo = new DataTable();
				tablo.Load(vt.oku);
				vt.baglantiKapa();
				return tablo;
			}
			catch (Exception)
			{
				MessageBox.Show("Abonelik classinda goster metodunda hata var");
				throw;
			}
		}
		public void aboneEkle(int id, string tip, string sure, string btarih, string bitisTarih,int ucret)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Insert into abonelik (abonelik_id,abonelik_tipi,abonelik_sure,abonelik_giris_tarihi,abonelik_cikis_tarihi,ucret) values (@abonelik_id,@abonelik_tipi,@abonelik_sure,@abonelik_giris_tarihi,@abonelik_cikis_tarihi,@ucret)", vt.baglan);
				vt.komut.Parameters.AddWithValue("@abonelik_id", id);
				vt.komut.Parameters.AddWithValue("@abonelik_tipi", tip);
				vt.komut.Parameters.AddWithValue("@abonelik_sure", sure);
				vt.komut.Parameters.AddWithValue("@abonelik_giris_tarihi", btarih);
				vt.komut.Parameters.AddWithValue("@abonelik_cikis_tarihi", bitisTarih);
				vt.komut.Parameters.AddWithValue("@ucret", ucret);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("Abonelik classinda abone ekle bolumunde hata var");
				throw;
			}
			finally
			{
				MessageBox.Show("kayit basarili");
			}
		}

		public void aboneSil(int id)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Delete from abonelik where abonelik_id=@abonelik_id", vt.baglan);
				vt.komut.Parameters.AddWithValue("@abonelik_id", id);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("Abone classında Abonesil bolumunde hata var");
				throw;
			}
			finally
			{
				MessageBox.Show("Silme islemi basarili");
			}
		}
		public void aboneGuncelle(int id, string tip, string sure, string btarih, string bitisTarih, int ucret)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Update abonelik set abonelik_id=@abonelik_id,abonelik_tipi=@abonelik_tipi,abonelik_sure=@abonelik_sure,abonelik_giris_tarihi=@abonelik_giris_tarihi,abonelik_cikis_tarihi=@abonelik_cikis_tarihi,ucret=@ucret Where abonelik_id=@abonelik_id", vt.baglan);
				vt.komut.Parameters.AddWithValue("@abonelik_id", id);
				vt.komut.Parameters.AddWithValue("@abonelik_tipi", tip);
				vt.komut.Parameters.AddWithValue("@abonelik_sure", sure);
				vt.komut.Parameters.AddWithValue("@abonelik_giris_tarihi", btarih);
				vt.komut.Parameters.AddWithValue("@abonelik_cikis_tarihi", bitisTarih);
				vt.komut.Parameters.AddWithValue("@ucret", ucret);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("Abone classinda abone guncelle bolumunde hata");
				throw;
			}
			finally
			{
				MessageBox.Show("Guncelleme islemi basarili");
			}
		}
	}
}
