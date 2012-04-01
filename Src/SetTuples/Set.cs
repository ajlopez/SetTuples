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
        private IList<Tuple> tuples;

        public Set(IEnumerable<Column> columns)
        {
            this.columns = columns.ToArray();
            this.positions = new Dictionary<string, int>();

            for (int k = 0; k < this.columns.Length; k++)
                this.positions[this.columns[k].Name] = k;

            this.tuples = new List<Tuple>();
        }

        private Set(Set set)
        {
            this.columns = set.columns;
            this.positions = set.positions;
            this.tuples = new List<Tuple>(set.tuples);
        }

        public IEnumerable<Tuple> Tuples { get { return this.tuples; } }

        public IEnumerable<Column> Columns { get { return this.columns; } }

        public Set AddTuple(NameValues values)
        {
            Set set = new Set(this);
            Tuple tuple = new Tuple(this.columns.Length);
            
            foreach (string name in values.Values.Keys)
                tuple[this.positions[name]] = values.Values[name];

            set.tuples.Add(tuple);

            return set;
        }
    }
}
