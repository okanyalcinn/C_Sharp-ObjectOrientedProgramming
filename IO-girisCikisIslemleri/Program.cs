using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // yazma okuma kütüphanesi
using System.Diagnostics; // windowsla konuşma kütüphanesi

namespace IO_girisCikisIslemleri
{
    // dosya okuma yazma işlemleri
    // system.IO kütüphanesinde bulunur
    /*
     * ----FileMode Enumaration
     * 
     * Açıklama
     * Create: FileMode.Create se.eneği ile yenni bir dosya oluşturulur, aynı dosya varsa üzerine yazılır.
     * CreateNew: yeni bir dosya oluşturului eper aynı dosya var ise IOException hatası alınır.
     * Append: Dosya açılarak sonundan başlayarak yazma işlemi yapılır. Eğer dosya yok ise oluşturulur.
     *      Not: FileMode.Append seçeneği sadece FileAccess.Write seçeneği ile kullanılır diğer kullanımlarda ArgumentException hatası alınır.
     * Open: Dosya belirtilen dizinde var ise açılır. Eğer dosya yoksa FileNotFoundException hatası alınır
     * OpenOrCreate: Dosya belirtilen dizinde var ise açılır, yok ise oluşturulur
     * Truncate: Dosya açılır ve içerisi boşaltılıp boyutu 0 byte olarak güncellenir.
     * 
     * ----FileAcess enumeration Değerleri 
     * - FileShare değerleri olarak sadece None: işlem yaptığımız kanaldan erişim olur, diğer kanallara erişim sağlanamaz.
     *      Geri kalan tüm özellikler FileAccess ile aynıdır
     * 
     * Read: Dosyaya sadece okuma yetkisi verir
     * Write: Dosyaya sadece yazma erişimi verir
     * ReadWrite: Hem okuma hem yazma yetkisi verir
     * Delete: Silme yetkisi
     * İnheritable: satır bazlı güncelleme //google drive bu sistemi kullanıyor. anlık olarak kullanıcıların tek bir dosya üzerinde çalışması ve güncellemesi
     * 
     * File okuma seçenekleri
     * ReadAllLines: tüm metni satır satır okur
     * ReadAllText: dosya tamamını okur, sonrada streamı kapatır 
     * ReadAllBytes: dat dosyalarını açar. byte dizilere aktarır sonra da kapar
     * */

    interface ITanimlama
    {
        string dosya_yolu { get; set; }
        string baslik { get; set; }
        string mesaj { get; set; }
    }
    class Yaz
    {
        public int satirSayisi { get; set; }
        public void DosyaYaz(string dosyaYolu, DateTime tarih, string baslik, string mesaj)
        {
            // tüm satırları oku
            satirSayisi = File.ReadAllLines(dosyaYolu).Length + 1; // +1 dizi mantığıyla hesapla
            // Filestreamden nesne türettik
            FileStream yaz = new FileStream(dosyaYolu, FileMode.Append);
            try
            {
                using (StreamWriter stream = new StreamWriter(yaz))
                {
                    stream.Write(satirSayisi + " ");
                    stream.Write(tarih + " \t");
                    stream.Write(baslik + " \t");
                    stream.Write(mesaj + " \t");
                    stream.WriteLine(" \t");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Kayıt başarılı");
            }
}
    }
    class Listele
    {
        public int ToplamMesaj { get; set; }
        public string dokuman { get; set; }
        public Listele(string dosya_yolu)
        {
            try
            {
                using (StreamReader reader = new StreamReader(dosya_yolu))
                {
                    dokuman = reader.ReadToEnd().ToString(); //readToEnd() tamamını oku
                    Console.WriteLine(dokuman);
                    ToplamMesaj = File.ReadAllLines(dosya_yolu).Length; // toplam mesaj
                    Console.WriteLine("Toplam: " + ToplamMesaj);
                }
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (FileLoadException)
            {
                throw;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch (FieldAccessException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dokuman = "";
            }
        }
        ~Listele()
        {
            Console.WriteLine(ToplamMesaj + " Mesaj listelendi");
        }
    }
    class Guncelle:ITanimlama
    {
        public string dosya_yolu { get; set; }
        public string baslik { get; set; }
        public string mesaj { get; set; }
        int _str = 0;
        public void Silme(int no, string dosya_yolu)
        {
            //var dosta değişkenine tüm satırları okuma metodu ile liste içerisine aktarım sağlandı
            var dosya = new List<string>(File.ReadAllLines(dosya_yolu));
            Listele listele = new Listele(dosya_yolu);
            dosya.RemoveAt(no - 1); //RemoveAt  satır silme işlemi yapacak // -1 dizilerdeki mantık gibi index no şeklinde
            // tüm satırları Ramden al kayıtlar dosyasına yaz removeat() silinen hariş bir dizi halinde aktar
            File.WriteAllLines(dosya_yolu, dosya.ToArray());
        }
        public void Guncelleme(string dosya_yolu)
        {
            try
            {
                Console.WriteLine("Güncellemek istediğiniz satir");
                int _strNo = int.Parse(Console.ReadLine());
                Silme(_strNo,dosya_yolu);
            }
            catch (Exception)
            {
                throw;
            }
            Yaz yaz = new Yaz();
            DateTime date = new DateTime();
#warning silme satır silinecek aynı yerine aynı no ile ekleme 

            yaz.DosyaYaz(dosya_yolu,date,baslik,mesaj);

        }               
    }
    class Sil
    {
        public Sil(string dosya_yolu)
        {
            try
            {
                Listele listele = new Listele(dosya_yolu);
                Console.WriteLine("Silmek istediğiniz satir");
                int _strNo = int.Parse(Console.ReadLine());
                Guncelle guncelle = new Guncelle();
                guncelle.Guncelleme(dosya_yolu);
                guncelle.Silme(_strNo, dosya_yolu);
            }
            catch (Exception)
            {
                throw;
            }
}
    }
    class Program : ITanimlama
    {
        public string dosya_yolu { get; set; }
        public string baslik { get; set; }
        public string mesaj { get; set; }        

        static void Main(string[] args)
        {
            string dosya_yolu = @"D:\VS_Projelerim\20181227_Smart-OOP\IO-girisCikisIslemleri\_kayitlar.txt"; //@ işareti string içerisindeki slashların aktif kullanılması için "/"

            string secim;
            ConsoleKeyInfo info;
            do
            {
                Console.Clear();
                Console.WriteLine("***************************************");
                Console.WriteLine("1 - Kayıt ekleme***");
                Console.WriteLine("2 - Kayı Listeleme***");
                Console.WriteLine("3 - Kayıt Güncelleme***");
                Console.WriteLine("4 - Kayıt Silme***");
                Console.WriteLine("5 - Çıkış***");
                Console.WriteLine("Seçiminiz: ");
                int islem = Convert.ToInt32(Console.ReadLine());

                switch (islem)
                {
                    case 1:
                        DateTime time = DateTime.Now;
                        Console.WriteLine("Kayıt Tarihi: " + time);
                        Console.Write("Başlık giriniz: ");
                        string _baslik = Console.ReadLine();
                        Console.Write("Mesajınızı giriniz: ");
                        string _mesaj = Console.ReadLine();
                        Yaz yaz = new Yaz();
                        yaz.DosyaYaz(dosya_yolu, time, _baslik, _mesaj);

                        break;
                    case 2: //listeleme 
                        Console.Write("Günlükteki kayıtlar\n");
                        Console.Write("No  tarih\t\tbaşlık\tmesaj\n");
                        Listele listele = new Listele(dosya_yolu);

                        break;
                    case 3://güncelleme
                        Guncelle guncelle = new Guncelle();
                        guncelle.Guncelleme(dosya_yolu);
#warning Güncelleme metodu eklenecek
                        break;
                    case 4: // silme
                        Sil sil = new Sil(dosya_yolu);                        
#warning silme metodu eklenece
                        break;
                    case 5: //çıkış
                        System.Environment.Exit(1);
                        string processName = "IO-girisCikisIslemleri"; // aranan exe
                        Process[] processes = Process.GetProcesses(); // tüm programlar listesi - görev yöneticisindeki
                        foreach (Process process in processes)
                        {
                            if (process.ProcessName == processName)
                            {
                                process.Kill();
                            }
                        }
                        break;
                    default:
                        break;
                }

                info = Console.ReadKey(true);
                if (ConsoleKey.Escape == info.Key)
                {
                    break;
                }

            } while (info.Key != ConsoleKey.Escape);
        }
    }
}
