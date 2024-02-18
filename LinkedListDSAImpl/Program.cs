namespace LinkedListDSAImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add("Test1");
            list.Add("Test2");
            list.Add(1,"Test3");
            //for(int i =0; i<list.Count; i++)
            //{
            //    Console.WriteLine(list[KeyValuePair]);
            //}

            Console.WriteLine("Is it empty? -" + list.Empty);
            Console.WriteLine("Is it empty? -" + list.Count);
            //list.Remove(1);
            //object test = list.Get(1);
            //Console.WriteLine(test);

            Console.WriteLine("After removal-" + list.Count);

            Console.ReadLine();

        }
    }
}
