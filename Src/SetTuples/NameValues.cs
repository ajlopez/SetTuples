namespace SetTuples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NameValues
    {
        private Dictionary<string, object> values = new Dictionary<string, object>();

        public NameValues()
        {
        }

        public Dictionary<string, object> Values { get { return this.values; } }

        public void Add(string name, object value)
        {
            values[name] = value;
        }
    }
}
