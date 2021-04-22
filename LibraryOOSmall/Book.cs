using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LibraryOOSmall
{
    class Book
    {
        public int _id = IdGenerator.Generate();
        public string _title { get; }
        private string _author;
        private string _genre;
        private int _pageCount;

        public Book(string title, string author, string genre, int pageCount)
        {
            _title = title;
            _author = author;
            _genre = genre;
            _pageCount = pageCount;
        }

        public string GetDescription()
        {
            return $"ID: {_id} Title: {_title}\nAuthor: {_author}\nGenre: {_genre}\nNumber of pages: {_pageCount}\n";
        }


    }
}
