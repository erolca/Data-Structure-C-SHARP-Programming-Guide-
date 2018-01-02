using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://www.gencayyildiz.com/blog/cta-ienumerable-ve-ienumerator-interfaceleri-nedir-ve-nasil-kullanilir/

class Program
    {
        static void Main(string[] args)
        {
        /* List<string> Isimler = new List<string>();
         Isimler.Add("Gençay");
         Isimler.Add("Nurgül");
         Isimler.Add("Ayşe");
         Isimler.Add("Fatih");
         Isimler.Add("Ilgaz");

         foreach (var isim in Isimler)
             Console.WriteLine(isim);

         Console.Read();*/

        Personeller personeller = new Personeller();
        personeller.Add(new Personel { Id = 1, Adi = "Gençay", SoyAdi = "Yıldız" });
        personeller.Add(new Personel { Id = 2, Adi = "Aslı", SoyAdi = "Cambaz" });
        personeller.Add(new Personel { Id = 3, Adi = "Elif", SoyAdi = "Gök" });
        personeller.Add(new Personel { Id = 4, Adi = "Aykız", SoyAdi = "Yıldız" });
        personeller.Add(new Personel { Id = 5, Adi = "Erol", SoyAdi = "Burçak" });
        foreach (Personel personel in personeller)
            Console.WriteLine($"ID : {personel.Id}\nAdı : {personel.Adi}\nSoyadı : {personel.SoyAdi}\n*****");
        Console.Read();

    }
    }


class Personel
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string SoyAdi { get; set; }
}

class PersonelEnumerator : IEnumerator<Personel>
{
    List<Personel> Kaynak;
    int currentIndex = -1;
    public PersonelEnumerator(List<Personel> Kaynak) => this.Kaynak = Kaynak;
    public Personel Current => Kaynak[currentIndex];
    object IEnumerator.Current => Kaynak[currentIndex];
    public void Dispose() => Console.WriteLine("İterasyon bittiii...");
    public bool MoveNext() => ++currentIndex < Kaynak.Count;
    public void Reset() => currentIndex = 0;
}


class Personeller : IEnumerable<Personel>
{

    List<Personel> PersonelListesi = new List<Personel>();
    public void Add(Personel p) => PersonelListesi.Add(p);
    public IEnumerator<Personel> GetEnumerator() => new PersonelEnumerator(PersonelListesi);
    IEnumerator IEnumerable.GetEnumerator() => new PersonelEnumerator(PersonelListesi);

    /* public void Add(Personel p)
     {
         PersonelListesi.Add(p);
     }*/

   /* public IEnumerator<Personel> GetEnumerator()
    {
        return PersonelListesi.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return PersonelListesi.GetEnumerator();
    }
    */
   /* public IEnumerator GetEnumerator()
    {
        return PersonelListesi.GetEnumerator();
    }*/

    //   Eğer ki siz “var” kullanmak istiyorsanız GetEnumerator
    //  metodunun geri dönüş tipini aşağıdaki gibi generic IEnumerator 
    //olarak tanımlamanız gerekmektedir.

  /*  public IEnumerator<Personel> GetEnumerator()
    {
        return PersonelListesi.GetEnumerator();
    }*/


}


 