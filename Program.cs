using System;
using GoFDesignPattern.Adapter.InheritancePattern;
using GoFDesinPattern.Iterator;


// Iteratorパターン
/*namespace GoFDesinPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("Around the World in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Daddy-Lnog-Legs"));

            IIterator it = bookShelf.Iterator();
            while (it.IsNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.GetName());
            }
        }
    }
}*/

// Adapterパターン
namespace GoFDesinPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}
