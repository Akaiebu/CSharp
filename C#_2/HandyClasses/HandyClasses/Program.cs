//Random random = new Random();
//int[] numbers = new int[8];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(10, 31);
//}
//int maxNumber = numbers[0];
//int minNumber = numbers[0];
//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] > maxNumber)
//    {
//        maxNumber = numbers[i];
//    }
//    else if (numbers[i] < minNumber)
//    {
//        minNumber = numbers[i];
//    }
//}
//int result = maxNumber * minNumber;
//Console.WriteLine("En böyük eded: " + maxNumber);
//Console.WriteLine("En kiçik eded: " + minNumber);
//Console.WriteLine("Hasil: " + result);

//Random random = new Random();
//char[] letters = new char[3];
//for (int i = 0; i < letters.Length; i++)
//{
//    letters[i] = (char)random.Next('A', 'M' + 1);
//}
//int totalUnicode = 0;
//foreach (char letter in letters)
//{
//    totalUnicode += (int)letter;
//}
//Console.WriteLine("Secilmis herfler: " + string.Join(", ", letters));
//Console.WriteLine("Herflerin Unicode cemi: " + totalUnicode);

//Random random = new Random();
//int[] numbers = new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(1,100);
//}
//int sum = 0;
//foreach (int number in numbers)
//{
//    sum += number;
//}
//double average = (double)sum / numbers.Length;
//Console.WriteLine("Yaradılmış ededler: " + string.Join(", ", numbers));
//Console.WriteLine("ededlerin ortası: " + average);

//List<string> cities = new List<string>() { "Baku","Sumqayit","Abseron","Gence" };
//int totalLength = 0;
//foreach (string city in cities)
//{
//    totalLength += city.Length;
//}
//int squaredResult = totalLength * totalLength;
//Thread.Sleep(5000);
//Console.WriteLine("Elementlerin uzunluqlarının cemi: " + totalLength);
//Console.WriteLine("Neticenin kvadratı: " + squaredResult);

//DateTime birthday = new DateTime(1999, 10, 30);
//DateTime today = DateTime.Today;
//int age = today.Year - birthday.Year;
//if (today < birthday.AddYears(age))
//{
//    age--;
//}

//// Yaşını ekrana çıxar
//Console.WriteLine("Sizin yaşınız: " + age);

//Random random = new Random();
//int[] numbers  = new int[10];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(1,20);
//}
//int sum = 0;
//foreach (int number in numbers)
//{
//    if (number >= 10 && number <= 21)
//    {
//        sum += number;
//    }
//}
//Console.WriteLine("2 reqemli olan ededlerin cemi: " + sum);

//Random random = new Random();
//int[] numbers = new int[20];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(100, 1001);
//}
//Console.WriteLine("10-a tam bolunen ededler:");
//foreach (int number in numbers)
//{
//    if (number % 10 == 0)
//    {
//        Console.Write(number + " ");
//    }
//}
//Console.WriteLine();
//int maxNumber = numbers[0];
//foreach (int number in numbers)
//{
//    if (number > maxNumber)
//    {
//        maxNumber = number;
//    }
//}
//int maxCube = maxNumber * maxNumber * maxNumber;
//Console.WriteLine("En boyuk ededin kubu: " + maxCube);