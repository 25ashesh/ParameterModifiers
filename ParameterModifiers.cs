
class ParamterModifiers
    {
        static void Add(int x, int y, out int result)
        {
            result = x + y;
        }
        public static void Main(string[] args)
        {
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("The result is: "+ans);
        }
    }
