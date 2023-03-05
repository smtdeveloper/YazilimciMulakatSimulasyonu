using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimciMulakatSimulasyonu
{
    // 9.SORU kod Satırını Azalt ! 
    // Dip not : Direk kod yazma, soruyu iyi anladığına emin ol ve soru sor !
    // örn : sayıları kullanıcıdan mı almalıyım yoksa belirli bir sayı aralığına kadar mı yapmalıyım.
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
            private DataProvider1() { }

        }

        //9.Soru Cevap 2 - Doğru
        public class DataProvider2
        {
            private static DataProvider2 instance;
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

    }

