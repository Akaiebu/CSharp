//List<int> ints = new List<int> { 1,2, 3 };
//int cem = 0;
//foreach (int i in ints)
//{
//    cem += i;
//}
//Console.WriteLine(cem);

//int unum = Convert.ToInt32(Console.ReadLine());
//List<int> ints = new List<int> { };
//double cem = 0.0;

//for (int i = 0; i <= unum; i++)
//{
//    ints.Add(i);
//}
//foreach (int i in ints)
//{
//    cem += i;
//}
//Console.WriteLine(cem / unum);

//List<string> list = new List<string>();
//for (int i = 0; i < 5 ; i++)
//{
//    string soz = Console.ReadLine();
//    list.Add(soz);
//}
//foreach (string s in list)
//{ Console.WriteLine(s.Length); }

//Stack<int> stack = new Stack<int>();
//stack.Push(20);
//stack.Push(30);
//stack.Push(40);
//stack.Push(50);
//stack.Push(60);
//foreach (var item in stack.Reverse())
//{
//    Console.Write($"{item},");
//}

//Queue<string> customerQueue = new Queue<string>();
//customerQueue.Enqueue("Jhon");
//customerQueue.Enqueue("David");
//customerQueue.Enqueue("Laura");
//customerQueue.Enqueue("Arthur");
//string FirstElement = customerQueue.Peek();

//foreach (var item in customerQueue)
//{
//    if(item == FirstElement)
//    {
//        continue;
//    }
//    Console.WriteLine(item);
//}