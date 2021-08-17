using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryOOSmall
{
    class GetBookInfoCommand : ICommand
    {
        private Library _library;
        public GetBookInfoCommand(Library library)
        {
            _library = library;
        }

        public string Name { get; }
        public void ExecuteCommand()
        {
            var title = AskForBookInfo("title");
            var author = AskForBookInfo("author");
            var genre = AskForBookInfo("genre");
            var pageCount = Int32.Parse(AskForBookInfo("page count"));
            _library.CreateBook(title, author, genre, pageCount);
        }
        public string AskForBookInfo(string info)
        {
            Console.WriteLine($"Which {info} would you like to add?");
            return Console.ReadLine();
        }
    }
}
