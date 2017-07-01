using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 0,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Hello Description</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "John", Role = "Support" },
                    new Artist() { Name = "Bob", Role = "Doodler" },
                    new Artist() { Name = "Ross", Role = "Painter" }
                }
            },
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p>Hello Description</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "John", Role = "Support" },
                    new Artist() { Name = "Bob", Role = "Doodler" },
                    new Artist() { Name = "Ross", Role = "Painter" }
                }
            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p>Hello Description</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "John", Role = "Support" },
                    new Artist() { Name = "Bob", Role = "Doodler" },
                    new Artist() { Name = "Ross", Role = "Painter" }
                }
            }
        };

        public int GetLength()
        {
            return _comicBooks.Length;
        }

        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach(var comicBook in _comicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            
            return comicBookToReturn;
        }
    }
}