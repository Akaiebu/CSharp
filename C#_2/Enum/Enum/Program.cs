//foreach(Days day in Enum.GetValues(typeof(Days)))
//{
//    Console.WriteLine(day);
//}

//foreach(Colors colors in Enum.GetValues(typeof(Colors)))
//{
//    Console.WriteLine(colors.ToString().Length);
//}

//foreach(Animals animal in Enum.GetValues(typeof(Animals)))
//{
//    if (animal.ToString().ToLower().Contains("a"))
//    {
//        Console.WriteLine(animal);
//    }
//}

//enum Days
//{
//    BazarErtesi = 1,
//    CersenbeAxsami,
//    Cersenbe,
//    CumeAxsami,
//    Cume,
//    Senbe,
//    Bazar
//}

//enum Colors
//{
//    Red, 
//    Orange, 
//    Black, 
//    Purple
//}

//enum Animals
//{
//    Dog, 
//    Elephant, 
//    Monkey, 
//    Cat, 
//    Bear
//}

using Enum.Classes;

double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Toplamaq istediyiniz ededlerin cemi : {Operations.Toplama(x, y)}");
Console.WriteLine($"Cixmaq istediyiniz ededlerin ferqi : {Operations.Cixma(x, y)}");
Console.WriteLine($"Vurmaq istediyiniz ededlerin hasili : {Operations.Vurma(x, y)}");
Console.WriteLine($"Bolmek istediyiniz ededlerin qismeti : {Operations.Bolme(x, y)}");