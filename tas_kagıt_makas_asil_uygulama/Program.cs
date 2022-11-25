using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tas_kagıt_makas_asil_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tas-kağıt ve makas oyunu
            //kullanıcı vs bilgisayar
            //el bittiği zaman kazananı yazdırın. 
            //tekrar oynanmak isteyip istemediğini sorunuz.
            //skor tutunuz.
            //oyun sürdükçe skoru güncelleyiniz. 
            int kullaniciskor = 0;
            int bilgisayarskor = 0;
            Console.WriteLine("###################################");
            Console.WriteLine("TAŞ KAĞIT MAKAS OYUNUNA HOŞGELDİN!");
            Console.WriteLine("bAKALIM BENİ YENEBİLECEK MİSİN?!");
            Console.WriteLine("###################################");

            while (true)
            {
                Console.WriteLine("Taş/Kağıt/Makas?");
                string kullanıcı = Console.ReadLine();

                Random rnd = new Random();
                int el = rnd.Next(0, 3);
                string bilgisayar = el == 0 ? "Taş" : el == 1 ? "Kağıt" : "Makas";
                Console.WriteLine(bilgisayar);


                if (kullanıcı.ToLower() == bilgisayar.ToLower())
                {
                    Console.WriteLine("Berabere!");
                    kullaniciskor++;
                    bilgisayarskor++;
                    


                }

                else if (kullanıcı.ToLower() == "taş" && bilgisayar.ToLower() == "kağıt")
                {
                    Console.WriteLine("Kaybettin!");
                    bilgisayarskor++;
                    



                }
                else if (kullanıcı.ToLower() == "makas" && bilgisayar.ToLower() == "taş")
                {
                    Console.WriteLine("Kaybettin!");
                    bilgisayarskor++;
                    
                }
                else if (kullanıcı.ToLower() == "kağıt" && bilgisayar.ToLower() == "makas")
                {
                    Console.WriteLine("Kaybettin!");
                    bilgisayarskor++;
                    
                }


                else if (kullanıcı.ToLower() == "kağıt" && bilgisayar.ToLower() == "taş")
                {
                    Console.WriteLine("Kazandın!");
                    kullaniciskor++;
                    
                }
                else if (kullanıcı.ToLower() == "taş" && bilgisayar.ToLower() == "makas")
                {
                    Console.WriteLine("Kazandın!");
                    kullaniciskor++;
                    
                }
                else if (kullanıcı.ToLower() == "makas" && bilgisayar.ToLower() == "kağıt")
                {
                    Console.WriteLine("Kazandın!");
                    kullaniciskor++;
                   
                }
                else
                {
                    Console.WriteLine("Kafan mı karıştı? En iyisi tekrar dene.");
                    continue;
                }

                Console.WriteLine("Devam etmek istiyor musun? Evet/Hayır");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() == "evet")
                {
                    continue;
                }
                else if (cevap.ToLower() == "hayır")
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Karar veremedin mi? Tekrar dene bakalım :)");
                    continue;
                }
            }
            Console.WriteLine($"Sen: {kullaniciskor},Ben:{bilgisayarskor}");
            if (kullaniciskor>bilgisayarskor)
            {
                Console.WriteLine("KAZANDIN. TAMAM PATRON SENSİN!!!!!");
            }
            else if (kullaniciskor < bilgisayarskor)
            {
                Console.WriteLine("KAYBETTİN. HA HA HAAAA!!!!!");
            }
            else if (kullaniciskor == bilgisayarskor)
            {
                Console.WriteLine("BERABERE!!!!!");
            }



            Console.ReadLine();
        }
    }
}
