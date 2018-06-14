 class test
   {
       public void print()
       {
           Console.WriteLine("Hi everyone!");
		   Console.WriteLine("Conflict changes");
       }
   }
   class Program
   {
       static void Main(string[] args)
       {
           test t;
           t.print();
           Console.ReadLine();
       }
   }
 }