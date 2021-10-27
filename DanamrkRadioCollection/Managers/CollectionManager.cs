using System.Collections.Generic;
using DanamrkRadioCollection.Models;

namespace DanamrkRadioCollection.Managers
{
    public class CollectionManager
    {
        private static int _nextId = 1;
        private static readonly List<Collection> Data = new List<Collection>
        {
            new Collection {Id = _nextId++, Title = "Welcome to my life", Kunstner = "world", Genre = "Pop"},
            new Collection {Id=_nextId++, Title = "Python is even nicer", Price = 22.33}
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<Collection> GetAll()
        {
            return new List<Collection>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public Collection GetById(int id)
        {
            return Data.Find(bk => book.Id == id);
        }

        public Collection Add(Collection newBook)
        {
            newBook.Id = _nextId++;
            Data.Add(newBook);
            return newBook;
        }

        public Collection Delete(int id)
        {
            Collection book = Data.Find(book1 => book1.Id == id);
            if (book == null) return null;
            Data.Remove(book);
            return book;
        }

        public Collection Update(int id, Collection updates)
        {
            Collection book = Data.Find(book1 => book1.Id == id);
            if (book == null) return null;
            book.Title = updates.Title;
            book.Price = updates.Price;
            return book;
        }
    }
}
