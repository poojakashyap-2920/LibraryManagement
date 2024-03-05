using System;
using System.Collections;
namespace traffic
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine(" ***********  library managment  ***********");
            ArrayList al = new ArrayList();

            al.Add("java");
            al.Add("python");
            al.Add("c#");
            al.Add("english");
            al.Add("hindi");
            al.Add("maths");
            al.Add("c++");
            al.Add("c");

            string retunbook = Console.ReadLine();
            al.Add(retunbook);
            Console.WriteLine("show all book  in library");
            foreach (string item in al)
            {
                Console.WriteLine(item);
            }
       while(true)
            {

                Console.WriteLine("option 1.check avability..\n" +
                    "2.reserve book..\n" +
                    "3.return book..");
                Console.WriteLine("enter option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter book name..");
                        string bookname = Console.ReadLine();
                        if (al.Contains(bookname))
                        {
                            Console.WriteLine($"{bookname} avaliable in library");
                        }
                        else
                        {
                            Console.WriteLine($"{bookname}  is not avaliable in library");

                        }
                        break;

                    case 2:
                        Console.WriteLine("enter book name which book you want");
                        string reserve_book = Console.ReadLine();
                        al.Remove(reserve_book);

                        foreach (string item in al)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine($"{reserve_book} is reserve");
                        break;

                    case 3:
                        Console.WriteLine("enter book name which book you want to return");
                        string returne_book = Console.ReadLine();
                        Console.WriteLine($"{returne_book} is return");
                        foreach (string item in al)
                        {
                            Console.WriteLine(item);
                        }
                        al.Add(returne_book);


                        foreach (string item in al)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine($"{returne_book} Added successfully.....");

                        break;
                }

            }


        }
    }
}
