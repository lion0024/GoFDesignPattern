namespace GoFDesinPattern.Iterator
{
    internal class BookShelfIterator : IIterator
    {
        private BookShelf bookShelf;
        private int index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            index = 0;
        }

        public bool IsNext()
        {
            if (index < bookShelf.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            Book book = bookShelf.GetBookAt(index);
            index++;
            return book;
        }
    }
}