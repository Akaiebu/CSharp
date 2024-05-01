//List<int> ints = new List<int> { 1,2, 3 };
//int cem = 0;
//foreach (int i in ints)
//{
//    cem += i;
//}
//Console.WriteLine(cem);



internal class NumberSum<T>
{
    private List<int> numbers;

    public NumberSum(List<int> numbers)
    {
        this.numbers = numbers;
    }

    internal int CalculateSum()
    {
        throw new NotImplementedException();
    }
}