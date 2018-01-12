using System;
using System.Threading.Tasks;

namespace MovementsProject
{
    public abstract class Movements : IMovement
    {
        protected Movements()
        {
        }

        public DateTime dateTimePadrao { get; set; }
        public decimal decimnalPadrao { get; set; }
        public double doublePadrao { get; set; }
        public long longPadrao { get; set; }
        public Object objectPadrao { get; set; }
        public String stringPadrao { get; set; }
        public int value { get => value; set => this.value = value; }

        public async Task<int> CalculateMovemntValue()
        {
            await Task.Delay(1000); // 1 second delay
            return 1;
        }

        public async Task DisplayMovementValue()
        {
            var movementResult = await Task.Run(() => CalculateMovemntValue().ConfigureAwait(false));
            Console.WriteLine("\n\nThe Movement result is: " + movementResult);
        }

        public abstract void sayHello();

        public virtual string showMessage()
        {
            return "I am a message";
        }

        public abstract string whatImI();

        public virtual string whatsMyName()
        {
            return "My name is Movement";
        }

        // Declare the generic class.
        public class GenericList<T>
        {
            private void Add(T input)
            {
                // Method intentionally left empty.
            }
        }
    }
}