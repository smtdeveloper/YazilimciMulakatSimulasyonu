using System.Diagnostics.Metrics;
using System;

Console.WriteLine("1. Yazılımcı Mülakat Simülasyonu");


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
public class DataProvider
{
    private static DataProvider instance;
    public static DataProvider Instance
    {
        get
        {
            if (instance is null)
            {
                instance = new DataProvider();
                return instance;
            }
            else 
            {
                return instance;
            }
        }
    }
}

//9.Soru Cevap 1 - Doğru
public sealed class DataProvider1
{
    private static readonly DataProvider1 instance = new DataProvider1();
    public static DataProvider1 Instance => instance; //public static DataProvider Instance { get { return instance; } }
    private DataProvider1() {}

}

//9.Soru Cevap 2 - Doğru
public class DataProvider2
{
    private static  DataProvider2 instance; 
    public static DataProvider2 Instance => instance ?? (instance = new DataProvider2());  // ?? null kontrolü yapar null ise sag değilse sol calısır.
}


// 9.Soru CAVAP 3 - YANLIŞ :  BU KOD AYNI İŞE YARAR MI ?
// Hayır, bu kod instance alanına hiçbir değer atanmadığından, Instance özelliği her zaman null dönecektir.
// Bu nedenle, DataProvider sınıfının yalnızca bir örneğini tutmak için kullanılan bir özellik veya alan yoktur ve her çağrıda
// yeni bir örnek oluşturulur.
//Singleton tasarım deseni, sınıfın yalnızca bir örneğini oluşturmak ve buna erişimi sağlamak için kullanılır.
//İkinci örneği önlemek için sınıfın yalnızca bir kez örneklendirilmesi gerekir. Bu kod, Singleton tasarım desenini uygulamaz ve
//yalnızca bir örnek oluşturma işlevselliği sağlamaz.
public class DataProvider3
{
    private static DataProvider3 instance;
    public static DataProvider3 nstance { get; set; }

}


// Dip not : Direk kod yazma, soruyu iyi anladığına emin ol ve soru sor !

// örn : sayıları kullanıcıdan mı almalıyım yoksa belirli bir sayı aralığına kadar mı yapmalıyım.

// 10. Soru FizzBuzz oyunu
// Belirli bir sayı aralığındaki sayılar ekrana yazdırırken,
// eğer sayı 3'ün katı ise 'Fizz'.
// eğer sayı 5'im katı ise 'Buzz'.
// her ikisinin katı ise 'FizzBuzz' yazdıracağız.

// Cevap:
public class FizzBuzzApp 
{
    // kullanıcıdan alınan başlangıc ve bitiş sayılarına göre ekrana
    // Fizz, Buzz veya FizzBuzz yazdıran app.
    public string FizzBuzz(int beginning, int finish) 
    {
        string result = "";
        for (int i = beginning; i <= finish; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result += "FizzBuzz ";
            }
            else if (i % 3 == 0)
            {
                result += "Fizz ";
            }
            else if (i % 5 == 0)
            {
                result += "Buzz ";
            }
            else
            {
                result += i.ToString() + " ";
            }
        }

        return result;
    }
}



