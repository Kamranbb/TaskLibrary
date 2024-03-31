using TaskLibrary.Entities;

namespace TaskLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskLibrary.Entities.Library library = new TaskLibrary.Entities.Library();


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
                            library.AddBook(name, authorName, pageCount);   
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                            goto Again;
                        }  
                        break;
                        case 2:
                        foreach (var item in library.GetBook()) Console.WriteLine(item);
                        break;   
                        
                }


            }

         
        }
    }
}
