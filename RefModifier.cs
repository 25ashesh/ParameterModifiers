    class RefModifier
    {
        public static void Swapper(ref string fname, ref string lname)
        {
            string temp = fname;
            fname = lname;
            lname = temp;
        }
        static void Main(string[] args)
        {
            Console.Write("First Name: ");
            string str1 = Console.ReadLine();
            Console.Write("Last Name: ");
            string str2 = Console.ReadLine();
            Console.WriteLine("Originally : {0} {1}", str1 , str2);
            Swapper(ref str1, ref str2);
            Console.WriteLine("After swapping: {0} {1}", str1, str2);

        }
    }
