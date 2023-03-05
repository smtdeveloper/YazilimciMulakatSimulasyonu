using System.Diagnostics.Metrics;
using System;
using System.Numerics;
using YazilimciMulakatSimulasyonu;
using System.Text;

Console.WriteLine("Yazılımcı Mülakat Simülasyonu");


Console.WriteLine("1.SORU : Kendini tanıt ?");
// cevap  : Merhaba ben samet, aydında adnan menderes üniversitesi, bilgisayar proğramcılığından mezun oldum,
// DGS ile Anadolu üniversitesi, açık öğretim Yönetim Bilişim sistemlerine geçiş  yaptım,
// bundan önce üniversite dönemlerimde .net full stack developer olarak çalişma fırsatım oldu, java script ,
// c# ve back end teknolojilerinde deneyim kazandım. 2 yılı aşkın süredir instagramda yazılım alanında içerikler üretiyorum ve
// öğrendikerimi paylaşıyorum,  backend alanında bir çok  projeler geliştirdim hepsini github profilimde paylaşıyorum,
// bu projeler beni iyi bir yazılımcı olma yolunda destekledi


Console.WriteLine("2.Soru : neden bizi tercih ediyorsun ?");
// izmir gibi güzel bir sehirde yasamak ve .net alanında calişmak istediğim için bu fırsatı değerlendirmek istiyorum
// Not : eski iş yerindeki çalıstığın firma isimlerini verme !
// eski iş yerine gömme, düzgünce daha iyi iş arayısını geçtiğimi belirt, maaş ödenmedi olabilir


Console.WriteLine("3.SORU OOP ilkileri nelerdir açıkla, faydaları nedir ?");
// Nesneler, gerçek hayatta bulunan varlıkları (araba, müşteri, banka hesabı vb.) temsil ederken,
// sınıflar ise nesnelerin tasarım şablonlarını sağlar.
// OOP'nin temel ilke ve kavramları şunlardır:
// 1. Kalıtım (Inheritance) : sınıflar arası miras alma olayı, miras alan sınıf base sınıfdaki tüm kodları erişebilir.
// 2. Polimorfizm (Polymorphism)  : Bir nesnenin birçok şekle sahip olabilme yeteneği. Bu, nesnelerin farklı sınıflardan türetilebileceği anlamına gelir ve aynı yöntemlerin farklı nesne türleri için farklı şekillerde davranmasına izin verir.
// 3. Soyutlama (Abstraction : Karmaşık bir nesneyi basit ve anlaşılabilir parçalara ayırma yöntemidir.
// 4. Kapsülleme (Encapsulation) :  Nesnelerin iç yapısını gizleyerek, nesnelere yönelik işlemlerin sadece ilgili yöntemler tarafından gerçekleştirilmesini sağlar.


Console.WriteLine("4.SORU SOLID NEDİR ?");
// SOLID, şu beş temel ilkeyi ifade eder:
// 1. Single Responsibility Principle (Tek Sorumluluk Prensibi): Bir sınıfın veya fonksiyonun sadece bir sorumluluğu olmalıdır.
// 2. Open/Closed Principle (Açık/Kapalı Prensibi): Bir sınıfın veya fonksiyonun kaynak kodu değiştirilmeden genişletilebilir olması gerektiği prensibidir. Bu prensip, yeni özellikler eklemek için mevcut kodu değiştirmek yerine, mevcut kodu kullanarak yeni özellikler eklemenin mümkün olması gerektiğini ifade eder.
// 3. Liskov Substitution Principle (Liskov Yerine Geçme Prensibi): Bir sınıfın, türetilen sınıflar tarafından yerine konulabileceği prensibidir. Bu prensip, bir sınıfın, üst sınıfının yerine kullanılabilecek alt sınıfları desteklemesi gerektiğini ifade eder.
// 4. Interface Segregation Principle (Arayüz Ayrımı Prensibi): Kullanılmayan arayüzlerin sınıflara yüklenmemesi gerektiği prensibidir. Bu prensip, bir sınıfın, kullanmadığı özellikleri içermemesi gerektiğini ifade eder.
// 5. Dependency Inversion Principle (Bağımlılık Tersine Çevirme Prensibi): Yüksek seviyeli modüllerin düşük seviyeli modüllere bağlı olmaması gerektiği prensibidir. Bu prensip, bir yazılım bileşeninin diğer bileşenlerin detaylarına bağımlı olmaması gerektiğini ifade eder.
// sürdürebilirilik kod yazmak için  SOLID prensipleri, yazılım mühendisliği alanında kaliteli, esnek ve kolay bakım yapılabilir kod yazmak için temel ilkelerdir. 


Console.WriteLine("5.SORU En son ne öğrendin ?");
// I Unit Of Work Tasarım Deseni öğrendim.


Console.WriteLine("6.SORU Design pattern nedir ve neden kullanılır ?");
//Design pattern (tasarım deseni), yazılım tasarımı sırasında karşılaşılan tekrar eden problemlere yönelik genel çözüm önerileridir.
//Bu genel çözüm önerileri, yazılımın yeniden kullanılabilirliğini arttırarak, kodun daha okunaklı, anlaşılır ve sürdürülebilir olmasına
//katkı sağlar.



Console.WriteLine("7.Soru : sealed  anahtar kelimesi nedir");
// 'sealed' anahtar kelimesi, bir sınıfın başka bir sınıf tarafından kalıtım alınmasını engellemek için kullanılır.
// Bir sınıf sealed olarak tanımlandığında, bu sınıfın alt sınıfları (inheritance) oluşturulamaz.
// Yani, bir sealed sınıfı, başka bir sınıf tarafından miras alınamaz ve alt sınıflar türetilemez.
// sealed anahtar kelimesi, sınıf, metod veya özellikler için kullanılabilir. sealed anahtar kelimesi,
// bir sınıfın veya metodun değiştirilemez olduğunu ve başka bir sınıf veya metod tarafından
// yeniden yazılamayacağını belirtmek için de kullanılabilir.



Console.WriteLine("8.Soru Value ve Referans typler nelerdir. ");
//C# programlama dilinde, iki temel veri türü vardır: değer tipleri (value types) ve referans tipleri (reference types).
//Değer tipleri, bellekte bir değer olarak saklanır ve doğrudan erişilebilirler. Bu türlerin örnekleri, tamsayılar (int), kayan nokta sayıları (float),
//mantıksal değerler(bool), karakterler(char) vb.gibi basit tiplerdir. Değer tipleri, bellekte bir yığın (stack) bölgesinde saklanır.

//Referans tipleri, bellekte bir nesnenin adresi olarak saklanır ve dolaylı olarak erişilebilirler. Bu türlerin örnekleri, sınıflar (class),
//yapılar(struct), arayüzler(interface), diziler(array) ve delegeler(delegate) gibi daha karmaşık tiplerdir. Referans tipleri,
//bellekte bir heap bölgesinde saklanır.

// istisna String değişkenleri, diğer referans türleri gibi davranır ve bellekte bir heap bölgesinde saklanır.

//Bellekte saklanma şekilleri nedeniyle, değer tipleri genellikle daha hızlıdır ve daha az bellek kullanırlar. Ancak, referans tipleri,
//daha dinamik ve esnek bir yapıya sahip olduklarından, daha karmaşık uygulamalar için daha uygundur.


Console.WriteLine("9.SORU kod Satırını Azalt ! ");
// DataProvider classında yazdık !
DataProvider dataProvider = new DataProvider();

// Dip not : Direk kod yazma, soruyu iyi anladığına emin ol ve soru sor !
// örn : sayıları kullanıcıdan mı almalıyım yoksa belirli bir sayı aralığına kadar mı yapmalıyım.


Console.WriteLine("10. Soru FizzBuzz oyunu");
// Belirli bir sayı aralığındaki sayılar ekrana yazdırırken,
// eğer sayı 3'ün katı ise 'Fizz'.
// eğer sayı 5'im katı ise 'Buzz'.
// her ikisinin katı ise 'FizzBuzz' yazdıracağız.
FizzBuzzApp FizzBuzzApp = new FizzBuzzApp();
// FizzBuzzApp clasında yazdık !

Console.WriteLine("11. isimlendirmenin önemi ");
// 1. Kodun anlaşılabilirliğini artırır: İsimlendirme, kodun okunabilirliğini artırır ve
// kodun ne yaptığını anlamak için daha az zaman harcamamızı sağlar.
// Ayrıca, doğru bir şekilde isimlendirilmiş kod, diğer geliştiricilerin kodu daha
// kolay anlamalarını ve sürdürmelerini sağlar.
// 2. Hataları azaltır
// 3. Kodun yeniden kullanılabilirliğini artırır
// 4. Kodun bakımını kolaylaştırır
// 5. Kodun genel kalitesini artırır
// Bu, kodun daha kolay okunmasını ve anlaşılmasını sağlar,
// bu da daha az hata yapmamızı ve daha iyi bir kod yazmamızı sağlar.

Console.WriteLine("12. Delegate nedir ?");
// Delegate, C# ve diğer programlama dillerinde kullanılan bir kavramdır.
// Bir delegate, bir metodu veya yöntemi temsil eder. Bu, başka bir kod bloğuna, metoda veya
// fonksiyona, kendi belirleyeceği parametreleri ve geri dönüş değerini kullanarak bir metodu
// çağırma yetkisi verir.
// asenkron işlemlerde ve çoklu thread programlamada sıklıkla kullanılır.
// Bir delegate, olayların tetiklenmesini sağlayabilir veya birden fazla iş parçasını aynı anda
// çalıştırabilir.

Console.WriteLine("13. Big int nedir ?");
// C# System.Numerics adlı bir isim alanı içinde BigInteger sınıfını sağlar.
// BigInteger sınıfı, işlem belleği sınırlamaları olmadan tam sayılarla çalışmanızı sağlar ve böylece
// çok büyük veya çok küçük sayıları temsil edebilirsiniz.

///// c# big int değer aralığın ?
// BigInteger.MinValue, sınırsız negatif tam sayıları temsil ederken,
// BigInteger.MaxValue sınırsız pozitif tam sayıları temsil eder.

///// c# big int ramde kapladığı alan ?
// C# BigInteger sınıfı, işlem belleği sınırlamaları olmadan tam sayılarla çalışmanızı sağlar.
// Bu nedenle, BigInteger nesneleri oldukça büyük olabilir ve daha fazla bellek kullanabilirler.

Console.WriteLine("14. Thread nedir ?");
// Thread sınıfı, bir iş parçacığı oluşturmanıza, başlatmanıza ve yönetmenize olanak tanır.
// Ayrıca, ThreadPool sınıfı da bir dizi iş parçacığı oluşturmanıza ve bunları iş kuyruklarına eklemenize olanak tanır.
// Thread'lerin doğru bir şekilde yönetilmesi, uygulamanın performansını artırabilir.
// Ancak, thread'lerin yanlış kullanımı, uygulamanın kararlılığını ve performansını olumsuz etkileyebilir. 


Console.WriteLine("15. unit test nedir ?");
// Unit testlerinin yazılması, yazılımın kalitesini artırabilir ve hataların erken tespit edilmesine yardımcı olabilir. Bu testler, yazılımın bütünlüğünü ve işlevselliğini sağlamaya yardımcı olan bir güvenlik ağı sağlayabilir. Ayrıca, testlerin otomatik olarak çalıştırılması, manuel testlerin tekrarlanması için zaman ve maliyet tasarrufu sağlayabilir.
// Unit testler, birim testi yazılımı için çeşitli kütüphaneler ve çerçeveler kullanılarak yazılabilir. Örneğin, C# için NUnit, xUnit.net, MSTest ve Java için JUnit ve TestNG, popüler birim testi kütüphaneleridir.

Console.WriteLine("16. Encoding nedir ?");
// Encoding, karakter dizilerini bayt dizilerine ve bayt dizilerini karakter dizilerine dönüştürmek
// için kullanılan bir işlemdir. Bir karakter dizisi, bir dizi karakterden oluşurken, bir bayt dizisi,
// bir dizi bitlerden oluşur. Encoding işlemi, karakter dizilerinin bayt dizilerine dönüştürülmesi veya
// bayt dizilerinin karakter dizilerine dönüştürülmesi için kullanılan bir algoritma setidir.

// C# programlama dilinde, Encoding işlemleri için System.Text.Encoding sınıfı kullanılır.
// Bu sınıf, ASCII, UTF-8, UTF-16 ve diğer popüler kodlama sistemlerinin yanı sıra özel kodlama
// sistemlerini de destekler.

Console.WriteLine("17. Soru çıktısı ne olur ?");

List<int> results = new List<int>();

var val = 10;
var res = Calc(val);

var min = results.Min();
var avg = results.Average();
var max = results.Max();
var sum = results.Sum();

Console.WriteLine("\n Min :" + min + "\n Avg : " + avg + "\n Max : " + max + "\n Sum : " + sum);

int Calc(int count = 50)
{
    results.Add(count);

    if (count < 0)
        return -1;
    count--;

    if (count % 2 == 00)
    {
        count -= 2;
        return Calc(count);
    }
    else
    {
        return Calc(count - 2);
    }

}

// results : 10, 7, 4, 1, -2
// min : -2
// avg : 4
// max : 10
// sum : 20



Console.WriteLine("18. Soru Bu metota iki pozitif tam sayı, string olarak gönderilecektir ve " +
    "bu sayıların toplamıp geri gönderilmesi gerekiyor.");
string Sum1(string val1, string val2)
{
    var number1 = Convert.ToInt32(val1);
    var number2 = Convert.ToInt32(val2);
    var result = number1 + number2;
    string stringResult = result.ToString();
    return stringResult;
}

// val 1 : 48715159489484894000000000000000000000000000000000000000000000000000000000
// val 2 : 64545454548484848488948948000000000000000000000000000000000000000000000000
// olabilir o zaman ne yaparsın
// 1.cevap;
string Sum2(string val1, string val2)
{
    BigInteger number1 = BigInteger.Parse(val1);
    BigInteger number2 = BigInteger.Parse(val2);
    BigInteger result = number1 + number2;
    string stringResult = result.ToString();
    return stringResult;
}

// 2.cevap;
string Sum3(string val1, string val2)
{
    int carry = 0;
    int len1 = val1.Length;
    int len2 = val2.Length;
    int maxLen = Math.Max(len1, len2);
    // Bu kod, sonucun oluşturulması için bir StringBuilder nesnesi oluşturur.
    // StringBuilder nesnesi, performansı artırmak için, string manipülasyonu yaparken daha iyi bir seçenektir.
    // StringBuilder nesnesi, oluşturulduğunda, içinde hiçbir karakter yoktur. Bu nedenle, oluşturduğumuz StringBuilder nesnesinin, sonuç string'inin uzunluğunu aşacak kadar büyük olmasını sağlamalıyız. Bu nedenle, StringBuilder'ın kapasitesi, maxLen + 1 olarak ayarlanır.
    StringBuilder result = new StringBuilder(maxLen + 1);

    for (int i = 0; i < maxLen; i++)
    {
        //  digit1 değişkeni, val1 stringinin len1 - 1 - i indisindeki karakteri alır.
        //  Bu karakterin sayı değeri hesaplanarak digit1 değişkenine atanır. Ancak,
        //  val1 stringi, val2 stringinden daha kısa olabilir. Bu durumda, val1 stringinin sonuna
        //  sıfır (0) karakterleri ekleyerek, val1 ve val2 stringlerinin uzunluğunu eşitlemek gerekir.
        //  Bu işlem, i < len1 koşulunun kontrol edilmesiyle yapılır. Eğer i, len1'den küçükse,
        //  val1 stringinin i'inci basamağındaki rakam alınır. Aksi takdirde, digit1 değişkenine sıfır atanır.

        // Bu kodda, '0' karakterinin ASCII değeri, string olarak verilen sayının her bir rakamının ASCII değerinden çıkarılarak gerçek sayısal değeri elde edilir.
        // Örneğin, eğer val1 değişkeni içindeki string olarak verilen sayı 1234 ise, bu sayının ilk rakamı 1'dir ve ASCII kodlamasına göre 49'dur. Bu nedenle, "val1[len1 - 1 - i] - '0'" işlemi yaparak, rakamın ASCII değerinden '0' karakterinin ASCII değerini çıkararak gerçek sayısal değeri olan 1'i elde ederiz.
        int digit1 = i < len1 ? val1[len1 - 1 - i] - '0' : 0;
        int digit2 = i < len2 ? val2[len2 - 1 - i] - '0' : 0;

        int sum = digit1 + digit2 + carry;
        carry = sum / 10;
        // Bu kod, iki rakamın toplamının sonucunun 10'a bölümünden kalanı (modulus) hesaplayarak, toplama işleminin sonucunun sadece bir rakam olmasını sağlar.
        // Örneğin, 7 + 9 işlemi yapılırken, toplam 16 olacaktır. Ancak, bu işlemin sonucu sadece bir rakam olmalıdır. Bu nedenle, bu kod, toplamın 10'a bölümünden kalanı hesaplar ve sonucu result değişkenine ekler.
        //
        sum %= 10;
        result.Append(sum);
    }

    if (carry > 0)
    {
        result.Append(carry);
    }

    char[] charArray = result.ToString().ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);

}

