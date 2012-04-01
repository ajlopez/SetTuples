namespace SetTuples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Column
    {
        private string name;
        private ColumnType type;

        public Column(string name, ColumnType type)
        {
            this.name = name;
            this.type = type;
        }

        public string Name { get { return this.name; } }

        public ColumnType Type { get { return this.type; } }
    }
}
