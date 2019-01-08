using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_kapsulleme
{
    /* Kapsülleme (Encapsulation)
     *
     * Bu özellik / prensib oluşturulan sınıf içerisinde bazı alanların dışarıdan erişimini kısıtlamak için kullanılır
     * 
     * Oluşturulan bir sınıf -class içerisinde kullanıcının daha kolay işlem 
     *     gerçekleştirebilmesi için bazı işlemleri birleştirererk tek bir işlem gibi gösterebiliriz bu işleme kapsülleme adı verilir.
     * 
     * Erişim belirleyiciler (access modifier) sayesinde kapsülleme prensibinin temel mimarıdır.
     * 
     * */
    class Ozellikler
    {
        //private sadece kendi sınıfında çağrılıp kullanılabilir 
        // | yanlış anlamadıysam kapsülleme için çok gerekli. Kapsülleme mantığında dışarıdan istenen dışında 
        //   yanlış veri girişi yapılırsa eğer bu alanda field da değişiklik yapılmamasını veya istenen değere atanmasını sağlamak temel amaç
        //   Tabi bu örnekte dışarıdan (dış sınıf, farklı sınıf) verilen değeri direkt get set ediyoruz. değer direkt olarak 20 olarak girildiyse eğer private tanımlı no 'ya 20 değeri tanımlanmış oluyor
        private int no { get; set; }

        //bu yöntemle program sınıfından 25. satırdaki private no ya erişim sağlayabiliriz
        public int NO
        {
            get { return no; } // if kullanılabilir
            set { no = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ozellikler ozellikler = new Ozellikler();
            ozellikler.NO = 20;
        }
    }
}
