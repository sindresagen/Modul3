using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOO
{
    class Book
    {
        private int _pageCount;
        private string _author;
        private string _title;
        private string _genre;

        public Book(int pageCount, string author, string title, string genre)
        {
            _pageCount = pageCount;
            _author = author;
            _title = title;
            _genre = genre;
        }

        public string GetDescription()
        {
            return $"Title: {_title}\nAuthor: {_author}\nGenre: {_genre}\nNumber of pages: {_pageCount}\n";
        }

        public string GetTitle()
        {
            return _title;
        }
    }
}
