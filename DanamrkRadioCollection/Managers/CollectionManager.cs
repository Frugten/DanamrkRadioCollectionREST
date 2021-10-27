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
            new Collection {Id = _nextId++, Title = "Welcome to my life", Kunstner = "world", Genre = "Pop"}
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
            return Data.Find(song => song.Id == id);
        }

        public Collection Add(Collection newSong)
        {
            newSong.Id = _nextId++;
            Data.Add(newSong);
            return newSong;
        }

        public Collection Delete(int id)
        {
            Collection song = Data.Find(song1 => song1.Id == id);
            if (song == null) return null;
            Data.Remove(song);
            return song;
        }

        public Collection Update(int id, Collection updates)
        {
            Collection song = Data.Find(book1 => book1.Id == id);
            if (song == null) return null;
            song.Title = updates.Title;
            song.Kunstner = updates.Kunstner;
            song.Genre = updates.Genre;

            return song;
        }
    }
}
