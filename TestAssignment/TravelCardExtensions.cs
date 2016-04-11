using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment
{
    public static class TravelCardExtensions
    {
        public static string Print(this IEnumerable<TravelCard> cardSet)
        {
            var result = new StringBuilder();
            foreach (var card in cardSet)
            {
                result.Append(String.Format("{0}, ", card.Print()));
            }

            return result.ToString().TrimEnd(' ', ',');
        }

        public static ICollection<TravelCard> SortCards(IEnumerable<TravelCard> cardSet)
        {
            var workSet = cardSet.ToList();
            //создаем массив указателей на следующую карточку в workSet`е 
            int[] pointerArray = new int[workSet.Count];
            //заполняем значением по умолчанию ("-1" - обозначает последнюю карточку маршрута)
            for (int i = 0; i < pointerArray.Length; i++)
            {
                pointerArray[i] = -1;
            }

            //заполняем ссылками (индекс - текущая карточка, значение - следующая)
            for (int i = 0; i < pointerArray.Length; i++)
            {
                if (pointerArray[i] == -1)
                {
                    for (int j = 0; j < pointerArray.Length; j++)
                    {
                        if (workSet.ElementAt(i).DestinationPoint.Equals(workSet.ElementAt(j).DepartuePoint))
                        {
                            pointerArray[i] = j;
                        }
                    }
                }
            }

            var result = new TravelCard[pointerArray.Length];

            //находим индекс максимального значения в массиве указателей - конечной карточки нашего пути
            int posEnd = Array.IndexOf(pointerArray, -1);

            //переходим на индекс, соответствующий предыдущей карточке и добавляем ее в итоговый массив
            //таким образом выстоится цепочка маршрута из конца в начало
            var current = posEnd;
            for (int i = 0; i < pointerArray.Length; i++)
            {
                result[i] = workSet.ElementAt(current);
                current = Array.IndexOf(pointerArray, current);
            }

            result = result.Reverse().ToArray();
            return result;
        }
    }
}
