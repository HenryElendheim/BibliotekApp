using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekApp
{
    internal class Books
    {
        public string Title;
        public string Author;
        public int ReleaseYear;

        public Books(string title, string author, int releaseYear)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseYear;
        }
    }
}
