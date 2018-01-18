using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Regular
{
    class Program
    {
        static void Main(string[] args)
        {
            string Desen = @"FTR.";
     
            string[] words = Regex.Split("FTRdfdfd", @"FTR.");
            // Regular Expression için bir desen (pattern) tanımlıyoruz :

            string tarihDeseni = @"(?((0?[1-9])|([12][0-9])|(3[01]))(/)(0?[1-9]|1[0-2])(/)([12][0-9][0-9][0-9]))";

            // Regular Expressionumuzu tanımlıyoruz :

            Regex benimRegex = new Regex(tarihDeseni);

            // Kullanıcıdan tarih içeren metni talep ediyoruz :

            Console.WriteLine("Lütfen içinde tarih olan bir metin giriniz :");

            // Tarih arayacağımız metni konsoldan alıyoruz :

            string metin = Console.ReadLine();

            // Metin içerisindeki tarihleri (birden fazla olabilir) Collection nesnesine atıyoruz :

            MatchCollection benimMatchCollection = benimRegex.Matches(metin);

            // Metin içindeki herbir tarihi ekrana yazdırıyoruz :

            foreach (Match benimMatch in benimMatchCollection)

            {

                Console.WriteLine(benimMatch.Groups["tarih"]);

            }

            Console.Read();

        }
    }
}
