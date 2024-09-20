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
	internal class hizmetClass
	{
		veritabani vt = new veritabani();

		public DataTable goster()
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Select * From hizmet", vt.baglan);
				vt.oku = vt.komut.ExecuteReader();
				DataTable tablo = new DataTable();
				tablo.Load(vt.oku);
				vt.baglantiKapa();
				return tablo;
			}
			catch (Exception)
			{
				MessageBox.Show("hizmet classinda goster metodunda hata var");
				throw;
			}
		}
		public void hizmetEkle(int id, string gsaat, string csaat, string ucret, string abonelik,string plaka)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Insert into hizmet (hizmet_id,arac_giris_saat,arac_cikis_saat,ucret,abonelik,plaka) values (@hizmet_id,@arac_giris_saat,@arac_cikis_saat,@ucret,@abonelik,@plaka)", vt.baglan);
				vt.komut.Parameters.AddWithValue("@hizmet_id", id);
				vt.komut.Parameters.AddWithValue("@arac_giris_saat", gsaat);
				vt.komut.Parameters.AddWithValue("@arac_cikis_saat", csaat);
				vt.komut.Parameters.AddWithValue("@ucret", ucret);
				vt.komut.Parameters.AddWithValue("@abonelik", abonelik);
				vt.komut.Parameters.AddWithValue("@plaka", plaka);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("hizmet classinda hizmet ekle bolumunde hata var");
				throw;
			}
			finally
			{
				MessageBox.Show("kayit basarili");
			}
		}

		public void hizmetSil(int id)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Delete from hizmet where hizmet_id=@hizmet_id", vt.baglan);
				vt.komut.Parameters.AddWithValue("@hizmet_id", id);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("hizmet classında hizmetsil bolumunde hata var");
				throw;
			}
			finally
			{
				MessageBox.Show("Silme islemi basarili");
			}
		}
		public void hizmetGuncelle(int id, string gsaat, string csaat, string ucret, string abonelik, string plaka)
		{
			try
			{
				vt.baglantiAc();
				vt.komut = new SqlCommand("Update hizmet set hizmet_id=@hizmet_id,arac_giris_saat=@arac_giris_saat,arac_cikis_saat=@arac_cikis_saat,ucret=@ucret,abonelik=@abonelik,plaka=@plaka Where hizmet_id=@hizmet_id", vt.baglan);
				vt.komut.Parameters.AddWithValue("@hizmet_id", id);
				vt.komut.Parameters.AddWithValue("@arac_giris_saat", gsaat);
				vt.komut.Parameters.AddWithValue("@arac_cikis_saat", csaat);
				vt.komut.Parameters.AddWithValue("@ucret", ucret);
				vt.komut.Parameters.AddWithValue("@abonelik", abonelik);
				vt.komut.Parameters.AddWithValue("@plaka", plaka);
				vt.komut.ExecuteNonQuery();
				vt.baglantiKapa();
			}
			catch (Exception)
			{
				MessageBox.Show("hizmet classinda hizmet guncelle bolumunde hata");
				throw;
			}
			finally
			{
				MessageBox.Show("Guncelleme islemi basarili");
			}
		}
	}
}

