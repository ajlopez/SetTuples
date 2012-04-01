namespace SetTuples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Tuple
    {
        private object[] values;

        public Tuple(int size)
        {
            this.values = new object[size];
        }

        public object this[int index] 
        {
            get { return this.values[index]; }

            set { this.values[index] = value; }
        }

        public Tuple AddColumns(int incsize)
        {
            Tuple tuple = new Tuple(this.values.Length + incsize);
            Array.Copy(this.values, tuple.values, this.values.Length);
            return tuple;
        }
    }
}
