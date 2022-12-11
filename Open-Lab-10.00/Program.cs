using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //commented old code

            //Book LOTR = new Book();
            //{
            //    LOTR.Title = "Lord of the rings";
            //    LOTR.Pages = 450;
            //    LOTR.Category = "Fantasy";
            //    LOTR.Author = "J. R. R. Tolkien";
            //    LOTR.ReleaseDate = 1954;
            //    Console.WriteLine(LOTR.ToString());
            //    Console.WriteLine();

            //}

            
            //Book LOTR2 = new Book();
            //Console.WriteLine(LOTR2.ToString());
            //Console.WriteLine();


            //Book LOTR3 = new Book("Lord of the rings 3", 416);
            //Console.WriteLine(LOTR3.ToString());
            //Console.WriteLine();


            //Book HOBIT = new Book("Hobit", 310, Book.categoryList[4], "J. R. R. Tolkien ", 1937);
            //Console.WriteLine(HOBIT.ToString());
            

            Library schoolLibrary = new Library();
            {

                schoolLibrary.StudentsList.Add("John");
                schoolLibrary.StudentsList.Add("Poul");


                Book ucebnicaSlovenčiny = new Book("Slovenčina", 189, Book.categoryList[2], "Peter Klinec", 2018);
                Book ucebnicaMatematiky = new Book("Matematika", 232, Book.categoryList[2], "Peter Kytaš", 2020);
                Book ucebnicaAngličtiny = new Book("Angličtina", 192, Book.categoryList[2], "Peter Kutka", 2021);
                Book ucebnicaFyziky = new Book("Fyzika", 156, Book.categoryList[2], "Ján Kaňake", 1976);
                

                schoolLibrary.BookList.Add(ucebnicaSlovenčiny);
                schoolLibrary.BookList.Add(ucebnicaMatematiky);
                schoolLibrary.BookList.Add(ucebnicaAngličtiny);
                schoolLibrary.BookList.Add(ucebnicaFyziky);
                
                schoolLibrary.NumberOfBooks = 4;
                schoolLibrary.NumberOfStudents = 2;


                Console.WriteLine(schoolLibrary.ToString());
                






            }

            



        }
    }
}
