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
            Book LOTR = new Book();
            {
                LOTR.Title = "Lord of the rings";
                LOTR.Pages = 450;
                LOTR.Category = "Fantasy";
                LOTR.Author = "J. R. R. Tolkien";
                LOTR.ReleaseDate = 1954;
                Console.WriteLine(LOTR.ToString());
                Console.WriteLine();

            }

            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine();


            Book LOTR3 = new Book("Lord of the rings 3", 416);
            Console.WriteLine(LOTR3.ToString());
            Console.WriteLine();

            Book HOBIT = new Book("Hobit", 310," ", "J. R. R. Tolkien", 1937);
            HOBIT.Category = Book.categoryList[5];
            Console.WriteLine(HOBIT.ToString());

            



        }
    }
}
