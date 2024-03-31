using TaskLibrary.Entities;

namespace TaskLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            while (true) 
            
            {
                Console.WriteLine("1 Add Book ");
                Console.WriteLine("2 Butun Kitablar");


                int command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        Again:
                        try
                        {
                            Console.WriteLine("Kitab adi daxil et ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Author add daxil et ");
                            string authorName = Console.ReadLine();
                            Console.WriteLine("Kitab Sehifesi Daxil et ");
                            int pageCount = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                            goto Again;
                        }  
                        break;
                        case 2:

                        foreach (var item in Book.)
                        {
                            
                        }
                }


            }

         
        }
    }
}
