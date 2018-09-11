using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_Creating_Structs
{
    class Program
    {
        public struct bookStruct
        {
            string title;
            string category;
            string author;
            int numberOfPages;
            int currentPage;
            string ISBN;
            string coverStyle;

            public bookStruct(string title, string category, string author, int numPages, int curPage, string ISBN, string covStyle)
            {
                this.title = title;
                this.category = category;
                this.author = author;
                this.numberOfPages = numPages;
                this.currentPage = curPage;
                this.ISBN = ISBN;
                this.coverStyle = covStyle;

            }
            public void displayBook()
            {
                Console.WriteLine("Details on the current title \n\t" +
                                "Title: {0} \n\t Category:{1} \n\t Author: {2}\n\t Pages: {3} \n\t Current: {4} \n\t" +
                                "ISBN:{5} \n\t Cover:{6} ",
                                 this.title, this.category, this.author, this.numberOfPages, this.currentPage, this.ISBN, this.coverStyle);
            }
            public void nextPage()
            {
                if(this.currentPage != numberOfPages)
                {
                     
                    Console.WriteLine("Current Page changed from {0} to {1}", this.currentPage++, this.currentPage);
                }
                else
                {
                    Console.WriteLine("Currently at end of Title");
                }
                
            }
            public void prevPage()
            {
                if(this.currentPage > 0)
                {
                    Console.WriteLine("Current page changed from {0} to {1}", this.currentPage--, this.currentPage);
                }
                else
                {
                    Console.WriteLine("Currently at beginning of book");
                }
            }
        }

        static void Main(string[] args)
        {
            bookStruct newBook = new bookStruct("The joys of programming", "programming", "Pro Grammer", 234, 57, "789476", "paperback" );
            newBook.displayBook();
            newBook.nextPage();
            newBook.nextPage();
            newBook.prevPage();


        }
    }
}
