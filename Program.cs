using System.Runtime.Intrinsics.X86;

namespace Assignment_3._2._4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program average = new Program();
            
            average.AverageCal();
        }
        public void AverageCal()
        {
            Console.WriteLine("Lets get the total/average of some grades.");

            Console.Write("\tEnter grade 1: ");
            double grade1 = int.Parse(Console.ReadLine());
            Console.Write("\tEnter grade 2: ");
                double grade2 = int.Parse(Console.ReadLine());
            Console.Write("\tEnter grade 3: ");
                double grade3 = int.Parse(Console.ReadLine());
            Console.Write("\tEnter grade 4: ");
                double grade4 = int.Parse(Console.ReadLine());

            double sum = grade1 + grade2 + grade3 + grade4;
            double average = (grade1 + grade2 + grade3 + grade4) / 4;

            Console.WriteLine($"For grades:" +
                $"\n1) {grade1}" +
                $"\n2) {grade2}" +
                $"\n3) {grade3}" +
                $"\n4) {grade4}" +
                $"\nTotal: {sum}" +
                $"\nAverage: {average}");

            
        }

    }
}
