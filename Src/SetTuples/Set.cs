namespace SetTuples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Set
    {
        private Column[] columns;
        private Dictionary<string, int> positions;
        private IEnumerable<Tuple> tuples;

        public Set(IEnumerable<Column> columns)
        {
            this.columns = columns.ToArray();
            this.positions = new Dictionary<string, int>();

            for (int k = 0; k < this.columns.Length; k++)
                this.positions[this.columns[k].Name] = k;

            this.tuples = new List<Tuple>();
        }

        public IEnumerable<Tuple> Tuples { get { return this.tuples; } }

        public IEnumerable<Column> Columns { get { return this.columns; } }
    }
}
