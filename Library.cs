using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekApp
{
    internal class Library
    {
        public List<Books> bookList = new();

        public Library()
        {

        }

        public void AddBooksHardcoded()
        {
            Books book1 = new Books("Elendig Hjem", "Henry Elendheim", 2026);
            Books book2 = new Books("Deep Dive", "John Doe", 2022);
            Books book3 = new Books("The Elemental", "Jane Doe", 2015);

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
        }

        public void AddBooksUser()
        {
            Console.WriteLine("\nWrite the title.\n");
            Console.Write("> ");
            string inputTitle = Console.ReadLine();

            Console.WriteLine("\nWrite the author.\n");
            Console.Write("> ");
            string inputAuthor = Console.ReadLine();

            Console.WriteLine("\nWrite the year of release.\n");
            Console.Write("> ");
            var inputReleaseYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\nYou've added:\n" +
                $"Title: {inputTitle}\n" +
                $"Author: {inputAuthor}\n" +
                $"Year of Release: {inputReleaseYear}\n\n");

            Books customBook = new Books(inputTitle, inputAuthor, inputReleaseYear);

            bookList.Add(customBook);
        }

        public void ListBooks()
        {
            foreach (Books book in bookList)
            {
                Console.WriteLine($"\nTitle: {book.Title}\n" +
                    $"Author: {book.Author}\n" +
                    $"Year of Release: {book.ReleaseYear}\n\n");
            }
        }

        public void SearchBooks()
        {
            Console.Write("\n> ");
            var input = Console.ReadLine();

            foreach (Books book in bookList)
            {
                if (input.ToLower() == book.Title.ToLower())
                {
                    Console.WriteLine($"Found a book with the title: {book.Title}\n");
                }
            }
        }

        public void RemoveBooks()
        {
            Console.Write("\n> ");
            var input = Console.ReadLine();

            for (int i = 0; i < bookList.Count; i++)
            {
                Books book = bookList[i];
                if (input.ToLower() == book.Title.ToLower())
                {
                    Console.WriteLine($"Found a book with the title: {book.Title}\n" +
                        $"Are you sure you want to remove it? (Y/N)");
                    Console.Write("\n> ");
                    var inputRemove = Console.ReadLine();

                    if (inputRemove.ToLower() == "y")
                    {
                        Console.WriteLine($"\nRemoved book named: {book.Title}");

                        Console.WriteLine($"Book index is: {i}");

                        bookList.RemoveAt(i);
                    }
                    else
                    {
                        Console.WriteLine("\nYou chose not to remove a book.");
                    }
                }
            }
        }
    }
}
