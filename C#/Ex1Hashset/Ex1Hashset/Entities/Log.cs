using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Hashset.Entities
{
    internal class Log
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Log (string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Log))
            {
                return false;
            }
            Log other = obj as Log;
            return Name.Equals(other.Name);
        }
    }
}
