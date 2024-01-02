using WebApiToAzure.Repository;

namespace WebApiToAzure.Data
{
    public static class AddBooks
    {
        public static void AddBookInfo()
        {
            BookRepo.AddBook(new Models.Book { Id = 0, Author = "Teszt_1", Title = "Teszt 1", Description = "Leírás 1", Example = "szöveg", Genre = "fantasy" });
            BookRepo.AddBook(new Models.Book { Id = 1, Author = "Teszt 2", Title = "Teszt 2", Description = "Leírás 2", Example = "szöveg", Genre = "Thriller" });
            BookRepo.AddBook(new Models.Book { Id = 2, Author = "Teszt 3", Title = "Teszt 3", Description = "Leírás 3", Example = "szöveg", Genre = "History" });
            BookRepo.AddBook(new Models.Book { Id = 3, Author = "Teszt 4", Title = "Teszt 4", Description = "Leírás 4", Example = "szöveg", Genre = "Adult" });
            BookRepo.AddBook(new Models.Book { Id = 4, Author = "Teszt 5", Title = "Teszt 5", Description = "Leírás 5", Example = "szöveg", Genre = "Nature" });
            BookRepo.AddBook(new Models.Book { Id = 5, Author = "Teszt 6", Title = "Teszt 6", Description = "Leírás 6", Example = "szöveg", Genre = "Sci-fi" });

        }

    }
}
