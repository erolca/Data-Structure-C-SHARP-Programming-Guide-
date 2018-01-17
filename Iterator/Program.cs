using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    // Item
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", ProductId.ToString(), Name, ListPrice.ToString("C2"));
        }
    }

    // Iterator
    // Nesne bütünü içerisindeki hareketlerin, yönlenmelerin gerçekleştirilebilmesi için gerekli operasyon arayüzünü tanımlar.
    interface IProductIterator
    {
        Product First();
        Product MoveNext();
        bool IsContinue { get; }
        Product Current { get; }
    }

    // Aggregate
    // Nesne bütününün, iterasyon için Concrete Iterator tipinden nesne örneği döndürecek bir metodunun olmasını söyler.
    interface IProductCollection
    {
        IProductIterator GetIterator();
    }

    // Concrete Aggregate
    // Nesne kümesini barındıran tipimiz.
    class ProductCollection
        : IProductCollection
    {
        // Product topluluğunu saklamak için generic bir List<T> koleksiyonundan yardım alıyoruz.
        private List<Product> list = new List<Product>();

        // Ürün sayısını dışarıya vermek için kullanılan bir özellik
        public int ProductCount
        {
            get { return list.Count; }
        }

        // Eleman eklemek ve okumak için kullanılan bir Indeksleyici
        public Product this[int index]
        {
            get { return list[index]; }
            set { list.Add(value); }
        }

        #region IProductCollection Members

        // Iterator nesnesini örnekler
        public IProductIterator GetIterator()
        {
            // Iterator nesnesi örneklenirken parametre olarak o andaki ProductCollection nesne örneği referans olarak gönderilir. 
            // Bu sayede ProductIterator isimli Concrete Iterator nesne örneği, çalışma zamanında hangi nesne bütününü dolaşacağını bilecektir.
            return new ProductIterator(this);
        }

        #endregion
    }

    // Concrete Iterator
    // Nesne bütününün bir ucundan diğerine hareket edilebilmesine olanak sağlayacak fonksiyonellikleri uygulayan asıl Iterator tipi
    class ProductIterator
        : IProductIterator
    {
        // Iterator nesne örneğinin, çalışma zamanında hangi nesne bütününü dolaşacağını bilmesi gerekmektedir. 
        private ProductCollection _books;
        private int _currentIndex = 0;
        // İstemci isterse adım sayısını değiştirebilir. Örneğin ikişer ikişer atlanarak gidilmesi sağlanabilir,
        public int StepSize { get; set; }

        // bu nedenle yapıcı metoda parametre olarak, ProductCollection(Concrete Aggregate) nesne örneğinin referansı gelir. Bu referansın GetIterator metodu içerisindeki çağrı ile gönderildiğini hatırlayalım.
        public ProductIterator(ProductCollection productCollection)
        {
            _books = productCollection;
        }
        #region IProductIterator Members

        // İlk elemana gidilmesini sağlayan metod
        public Product First()
        {
            // Nerede olunduğunun takibi için _currentIndex değeri set edilir
            _currentIndex = 0;
            return _books[0];
        }

        // Bir sonraki elemana geçilmesini sağlayan metod
        public Product MoveNext()
        {
            // Nerede olunduğunun takibi için _currentIndex değeri set edilir. Adım sayısı kadar arttırılır.
            _currentIndex += StepSize;
            if (IsContinue) // Eğer takip eden bir eleman var ise geri döndürülür
                return _books[_currentIndex];
            else
                return null;
        }

        // Takip eden ürün olup olmadığını belirten read-only özellik
        public bool IsContinue
        {
            get { return _currentIndex < _books.ProductCount; }
        }

        // O anki elemanı döndüren read-only özellik
        public Product Current
        {
            get { return _books[_currentIndex]; }
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection products = new ProductCollection();

            products[0] = new Product { ProductId = 1, Name = "330 ml Seramik Bardak", ListPrice = 12M };
            products[1] = new Product { ProductId = 2, Name = "1 Lt Cam Bardak", ListPrice = 12.5M };
            products[2] = new Product { ProductId = 3, Name = "50 cl Pet Şişe", ListPrice = 14.45M };

            // Iterator nesnesi products isimli koleksiyonu kullanmak üzere oluşturulur
            ProductIterator iterator = new ProductIterator(products);

            // Adım sayısı belirlenir
            iterator.StepSize = 1;

            // First ile ilk elemana konumlanılır.
            // Koşul olarak IsContinue değerine bakılır
            // İlerleme için MoveNext metodu kullanılır.
            for (
                Product product = iterator.First()
                    ; iterator.IsContinue
                    ; product = iterator.MoveNext()
                    )
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}