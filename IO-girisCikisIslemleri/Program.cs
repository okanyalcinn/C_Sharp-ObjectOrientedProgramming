using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace IO_giriscikisislemleri
{
    //chalange // silme ilgili satur değişltirme
    //Guncelleme


    //dosya okuma yazma işlemleri 
    //system.IO kütüphanesinde bulunur 
    /*FileMode Enumeration Değerleri

-----FileMode Enumeration	
    

    Create:  FileMode.Create seçeneği ile yeni bir dosya oluşturulur, aynı dosya varsa üzerine yazılır.

    CreateNew:	Yeni bir dosya oluşturulur, eğer aynı dosya var ise IOException hatası alınır.

    Append:	Dosya açılarak sonundan başlayarak yazma işlemi yapılır. Eğer dosya yok ise oluşturulur. 
    Not:FileMode.Append seçeneği sadece FileAccess.Write seçeneği ile kullanılır diğer kullanımlarda ArgumentException hatası alınır.


    Open :Dosya belirtilen dizinde var ise açılır. Eğer dosya yoksa FileNotFoundException hatası alınır.

    OpenOrCreate:	Dosya belirtilen dizinde var ise açılır yok ise oluşturulur.

    Truncate	:Dosya açılır ve içerisi boşaltılıp boyutu 0 byte olarak güncellenir.
     * 
     * 
     * 
     *------FileAccess Enumeration Değerleri - 
     * FileShare Degerleri olaran sadece None: işlem yaptığımız kanldan erişim olur diğer kanlalardan erişim sağlanmaz. Geri kalan tüm özellikler FileAccess ile aynıdır.

     * 
     *- Read :Dosyaya sadece okum ayetkisi verir
     * 
     *- Write :Dosyaya sadece yazma erişimi verir
     * 
     *- ReadWrite :Hem okuma hem yazma yetkisi verir
     * 
     * -Delete: Silme yetkisi
     * 
     * -İnheritable: satır bazlı guncelleme
     * 
     * 
     * File okuma secenekleri
     * 
     * ReadAllLines:tüm metni satır satır okur
     * ReadAllText:Dosya tamımı okur sonrada streamı kapatır
     * 
     * ReadAllBytes: dat dosyaları acar byte dizilere akatarırı sonrada kapar
     * 
     *  TextReader tReader = new StreamReader("DosyaYoluVeAdı");
     *  string okunan = tReader.ReadToEnd();
     *  tReader.Close();
     *  okunan = okunan.Replace(comboBox1.Text, "");
     *  TextWriter tWriter = new StreamWriter("DosyaYoluVeAdı");
     *  tWriter.Write(okunan);
     *  tWriter.Flush();
     *  tWriter.Close(); 
     * 
     * */


    interface ITanimlama
    {

        string dosya_yolu { get; set; }
       


    }


    class Yaz
    {
        public int satirsayisi { get; set; }
        public void DosyaYaz(string dosyayolu, DateTime tarih, string baslik, string mesaj)
        {

            //tum saturları okuma
            satirsayisi = File.ReadAllLines(dosyayolu).Length + 1;


            //Filestremden nesne türettik 
            FileStream yaz = new FileStream(dosyayolu, FileMode.Append);
            try
            {
                using (StreamWriter stream = new StreamWriter(yaz))
                {
                    stream.Write(satirsayisi + " ");
                    stream.Write(tarih + "\t");
                    stream.Write(baslik + "\t");
                    stream.Write(mesaj + "\t");
                    stream.WriteLine("\t");
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
        public int toplammesaj { get; set; }
        public string dokuman { get; set; }
        public Listele(string dosya_yolu)
        {
            try
            {

                using (StreamReader reader = new StreamReader(dosya_yolu))
                {
                    dokuman = reader.ReadToEnd().ToString();
                    Console.WriteLine(dokuman);
                    toplammesaj = File.ReadAllLines(dosya_yolu).Length;
                    Console.WriteLine("Toplam:" + toplammesaj);
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
            }
        }
        ~Listele()
        {
            Console.WriteLine(toplammesaj + " Mesajlar listelendi");
        }
    }
    class Guncelle :ITanimlama
    {
        public string dosya_yolu { get; set; }
        //int _str = 0;
        public void Guncel(string dosya_yolu)
        {
            Console.WriteLine("Güncelemek istediğiniz satır");
            int _strNo = int.Parse(Console.ReadLine());
            Program silme = new Program();
            silme.Silme(_strNo, dosya_yolu);
            DateTime date = DateTime.Now;
            Console.WriteLine("Kayıt Tarihi:" + date);
            Console.Write("Başlık giriniz:");
            string _baslik = Console.ReadLine();
            Console.WriteLine("Mesajı giriniz");
            string _mesaj = Console.ReadLine();
            Yaz yaz1 = new Yaz();
            yaz1.DosyaYaz(dosya_yolu, date, _mesaj, _baslik);
        }
    }
    class Sil
    {
        public Sil(string dosya_yolu)
        {
            try
            {
                Listele listele = new Listele(dosya_yolu);
                Console.WriteLine("Silme istediğiniz satır");
                int _strNo = int.Parse(Console.ReadLine());
                Program guncelle = new Program();
                guncelle.Silme(_strNo, dosya_yolu);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    class Program : IDisposable, ITanimlama
    {
        public string dosya_yolu { get; set; }
        public string baslik { get; set; }
        public string mesaj { get; set; }
        public void Silme(int no, string dosya_yolu)
        {
            //var dosya değişkenine Tüm satırları okuma metodu ile string tipli liste içirisine aktarım sağlandı
            var dosya = new List<string>(File.ReadAllLines(dosya_yolu));
            Listele listele = new Listele(dosya_yolu);
            //satır sileme durumu elaman sayısı -1 yani index no şeklinde
            dosya.RemoveAt(no - 1);
            //Tüm saturları remden al kayıtlar dosyasına yaz removeat() silinen hariç bir dizi halinde aktar
            File.WriteAllLines(dosya_yolu, dosya.ToArray());
        }
        static void Main(string[] args)
        {
            string dosya_yolu = @"D:\VS_Projelerim\GitHub\20181227_Smart-OOP\IO-girisCikisIslemleri\_kayitlar.txt";
            //string secim;
            ConsoleKeyInfo info;
            do
            {
                Console.Clear();
                Console.WriteLine("**********************");
                Console.WriteLine("**Günlük Programı*****");
                Console.WriteLine("1-Kayıt Ekleme********");
                Console.WriteLine("2-Kayıt Listeleme*****");
                Console.WriteLine("3-Kayıt Guncellme*****");
                Console.WriteLine("4-Kayıt Silme*********");
                Console.WriteLine("5-Çıkış***************");
                Console.WriteLine("**********************");
                int islem = 0;
                Console.WriteLine("Seçiminiz");
                try
                {
                    islem = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (islem)
                {
                    case 1: //kayıt girme
                        DateTime tarih = DateTime.Now;
                        Console.WriteLine("Kayıt Tarihi:" + tarih);
                        Console.Write("Başlık giriniz:");
                        string _baslik = Console.ReadLine();
                        Console.WriteLine("Mesajı giriniz");
                        string _mesaj = Console.ReadLine();
                        Yaz yaz = new Yaz();
                        //dosya okuma yazma
                        yaz.DosyaYaz(dosya_yolu, tarih, _baslik, _mesaj);
                        break;
                    case 2: //listeleme
                        Console.WriteLine("Günlükteki kayıtlar");
                        Console.WriteLine("no------tarih ---------------- başlık  ---- mesaj---");
                        //yapıcımetotola halledildi
                        Listele listele = new Listele(dosya_yolu);
                        //Program program = new Program();
                        //program.Dispose();
                        break;

                    case 3:// Guncelleme
                        Guncelle guncelle = new Guncelle();
                        guncelle.Guncel(dosya_yolu);
                        break;

                    case 4: // silme
                        Sil sil = new Sil(dosya_yolu);
                        break;
                    case 5: //çık
                        System.Environment.Exit(1);
                        string processName = "IO-giriscikisislemleri";//aranan exe
                        Process[] processes = Process.GetProcesses(); //tüm programlar listeledi
                        foreach (Process process in processes)
                        {
                            if (process.ProcessName == processName)
                            {
                                process.Kill();//remde sonlandırma
                            }
                        }
                        break;
                }
                info = Console.ReadKey(true);
                if (ConsoleKey.Escape == info.Key)
                {
                    break;
                }
            } while (info.Key != ConsoleKey.Escape);
        }
        public void Dispose()
        {
            Dispose();

        }
    }
}
