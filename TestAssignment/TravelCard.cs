using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment
{
    public class TravelCard
    {
        public string DepartuePoint { get; private set; }
        public string DestinationPoint { get; private set; }

        public TravelCard(string from, string to)
        {
            if (String.IsNullOrEmpty(from) || String.IsNullOrEmpty(to))
            {
                throw new InvalidDataException("При создании карточки произошла ошибка: один из пунктов не указан");
            }
            DepartuePoint = from;
            DestinationPoint = to;
        }

        public string Print()
        {
            return String.Format("{0} > {1}", DepartuePoint, DestinationPoint);
        }
    }
}
