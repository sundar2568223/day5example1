using System;
namespace example1
{
    class program
    {
        static void Main(string[] args)
        {
            int noc, nos;
            Console.WriteLine("Enter Number of classes");
            noc = int.Parse(Console.ReadLine());
            string[][] students = new string[noc][];
            for(int i = 0; i < noc; i++)
            {
                Console.WriteLine("Enter Number of student in class " + (i + 1));
                nos = int.Parse(Console.ReadLine());
                students[i] = new string[nos];
                for( int j = 0; j < nos; j++)
                {
                    Console.WriteLine($"Enter student {j+1}\'s name");
                    students[i][j] = Console.ReadLine();
                }
            }
            for(int i = 0;i < students.Length; i++) 
            {
                Console.WriteLine($" Students list of class {i + 1}");
                Console.WriteLine("********************************");
                for(int j = 0;j < students[i].Length; j++)
                {
                    Console.WriteLine(students[i][j] );
                }
                Console.WriteLine("****************************");
            }
            Console.ReadKey();
        }
    }
}