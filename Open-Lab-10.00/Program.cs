﻿using System;
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
                LOTR.Author = "J. R. R Tolkien";
                LOTR.ReleaseDate = 1954;
                Console.WriteLine(LOTR.ToString());

            }
        }
    }
}
