namespace CSharReflection.Models
{
    public class Car
    {
        private int _speed;

        private Car() { }

        public void Accelerate()
        {
            _speed += 10;

            Console.WriteLine($"Car accelerated to {_speed} km/s");
        }

        private void AddNitro()
        {
            _speed += 100;

            Console.WriteLine($"Injected some nitro, speed = {_speed} km/s");
        }
    }
}
