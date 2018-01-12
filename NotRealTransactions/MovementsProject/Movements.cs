using System;

namespace MovementsProject
{
    public abstract class Movements
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

        public virtual string showMessage()
        {
            return "I am a message";
        }

        public abstract string whatImI();

        public virtual string whatsMyName()
        {
            return "My name is Movement";
        }
    }
}