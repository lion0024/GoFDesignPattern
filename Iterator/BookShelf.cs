using System;
namespace GoFDesinPattern.Iterator
{
    public class BookShelf : IAggregate
    {
        private Book[] books;
        private int last = 0;

        public BookShelf(int maxsize)
        {
            books = new Book[maxsize];
        }

        public Book GetBookAt(int index)
        {
            return books[index];
        }

        public void AppendBook(Book book)
        {
            books[last] = book;
            last++;
        }

        public int GetLength()
        {
            return last;
        }

        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
