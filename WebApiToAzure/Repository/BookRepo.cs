using WebApiToAzure.Models;

namespace WebApiToAzure.Repository
{
    public static class BookRepo
    {
        private static List<Book> _books = new List<Book>();

        public static IEnumerable<Book> _Books
        {

            get { return _books; }

        }

        public static void AddBook(Book book)
        {
            _books.Add(book);
        }
    }
}
