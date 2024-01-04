using WebApiToAzure.Repository;

namespace WebApiToAzure.Data
{
    public static class AddBooks
    {
        public static void AddBookInfo()
        {
            BookRepo.AddBook(new Models.Book { Id = 0, Author = "Terry Pratchett", Title = "Örség, örség", Description = "Korongvilág regény", Example = "Ez az a hely, ahová a sárkányok távoztak.\r\nCsak hevernek itt, és… nem holtak, nem is álmodnak, csupán …szunnyadnak. És noha a tér, amelyet elfoglalnak, nem közönséges tér, ettől még alaposan összezsúfolódtak benne. Akár szardíniákhoz is hasonlíthatnánk őket, már amennyiben elfogadjuk, hogy létezhetnek ilyen óriási, pikkelyes, gőgös és arrogáns szardíniák.\r\nÉs feltehetően létezik valahol egy konzervnyitó.", Genre = "fantasy" });
            BookRepo.AddBook(new Models.Book { Id = 1, Author = "Agatha Christie", Title = "Adventi krimik", Description = "Klasszikus krimi", Example = "Egy bögre forró tea, egy puha takaró és egy kötetre való Agatha Christie-novella. Mi más kell még a téli estékre, amikor egyre rövidebbek a nappalok és sötétebbek az éjszakák?\r\n\r\nTomboló hóviharok, veszélyes ajándékok, méreg a portóiban és egy váratlan látogató… Ezekben az advent és újév között játszódó novellákban Agatha Christie minden híres nyomozójával találkozhatunk. Miss Marple egy gyógyszállóban tölti a karácsonyt, Hercule Poirot vidéken, Parker Pyne Mallorcán, Mr. Quin és Mr. Satterthwaite egy kastélyban, Tommy és Tuppence pedig egy vidéki fogadóban – a nyomukban pedig ott jár a halál…", Genre = "Thriller" });
            BookRepo.AddBook(new Models.Book { Id = 2, Author = "Györfy György", Title = "István király és műve", Description = "Honfoglalástól a királyság megszilárdításáig", Example = "szöveg", Genre = "History" });
            BookRepo.AddBook(new Models.Book { Id = 3, Author = "Teszt 4", Title = "Teszt 4", Description = "Leírás 4", Example = "szöveg", Genre = "Adult" });
            BookRepo.AddBook(new Models.Book { Id = 4, Author = "Teszt 5", Title = "Teszt 5", Description = "Leírás 5", Example = "szöveg", Genre = "Nature" });
            BookRepo.AddBook(new Models.Book { Id = 5, Author = "Teszt 6", Title = "Teszt 6", Description = "Leírás 6", Example = "szöveg", Genre = "Sci-fi" });

        }

    }
}
