namespace _06032025
{
    public delegate int MathDelegate(int No1, int No2);
    internal class Program
    {
        public static int M { get; set; }
        public static int Add(int x, int y)
        {

            M = 0;
            M += (x + y);

            Console.WriteLine("THE SUM IS : " + (x + y));

            return M;

        }
        public static int Sub(int x, int y)
        {

            M -= (x - y);

            Console.WriteLine("THE SUB IS : " + (x - y));

            return M;

        }
        public int Mul(int x, int y)
        {

            M *= (x * y);

            Console.WriteLine("THE MUL IS : " + (x * y));

            return M;

        }
        public int Div(int x, int y)
        {

            M += (x / y);

            Console.WriteLine("THE DIV IS : " + (x / y));

            return M;

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            MathDelegate del1 = new MathDelegate(Add);
            MathDelegate del2 = new MathDelegate(Program.Sub);
            MathDelegate del3 = p.Mul;
            MathDelegate del4 = new MathDelegate(p.Div);
            //In this example del5 is a multicast delegate. We can use +(plus)
            // operator to chain delegates together and -(minus) operator to remove.
            MathDelegate del5 = del1 + del2 + del3 + del4;
            Console.WriteLine("GRAND TOTAL : " + del5.Invoke(5, 6));
            Console.WriteLine();
            del5 -= del2;
            Console.WriteLine("GRAND TOTAL : " + del5(5, 6));
            Console.ReadKey();
            Console.WriteLine("Saraiya rishi");
            Console.WriteLine("Saraiya rishi1");
        }
    }
}
