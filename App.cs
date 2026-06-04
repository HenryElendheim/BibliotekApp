using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekApp
{
    internal class App
    {        
        public App()
        {

        }

        public void Run()
        {
            var library = new Library();
            library.AddBooksHardcoded();

            bool running = true;

            while (running)
            {
                Console.WriteLine("1 - View Books | 2 - Add Books | 3 - Remove Books | 4 - Search Books | 'exit' to leave\n");
                Console.Write("> ");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    library.ListBooks();
                }
                else if (input == "2")
                {
                    library.AddBooksUser();
                }
                else if (input == "3")
                {
                    library.RemoveBooks();
                }
                else if (input == "4")
                {
                    library.SearchBooks();
                }
                else if (input.ToLower() == "exit")
                {
                    running = false;
                }
            }
        }
    }
}
