
namespace interfaces.Class
{
    internal class Dog : Interfaces.IAnimal, Interfaces.IMoveable
    {
        public void GetEat()
        {
            Console.WriteLine("Dog is eating");
        }

        public void GetMove()
        {
            Console.WriteLine("Dog is sleeping");
        }
    }
}
