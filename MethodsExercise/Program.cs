namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("what's your name?");

            string name = Console.ReadLine();

            Console.WriteLine("how old are you? ");

            string old = Console.ReadLine();

            Console.WriteLine("what's your favorite day?");
            
            string day = Console.ReadLine();

            Console.WriteLine("what's youe favorite food?");
            
            string favorite = Console.ReadLine();

            Console.WriteLine($"a women named {name} was celebrating her {old} birthday on {day} eating {favorite}");
            


        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo; 
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        static void Main(string[] args)
        {
            //Madlib();
           // Console.WriteLine(Add(1, 5));
           // Console.WriteLine(Subtract(3, 2));
           //Console.WriteLine(Multiply(2, 2));
           //Console.WriteLine(Divide(5, 1));
        }
    } 
}
