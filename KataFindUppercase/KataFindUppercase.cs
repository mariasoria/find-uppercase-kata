using System;
using System.Collections.Generic;

namespace KataFindUppercase
{
    public class KataFindUppercase
    {
        public static List<int> Execute(string text, List<int> indexes, int index)
        {
            var totalIndexes = text.Length - 1;
            if (totalIndexes > index)
            {
                if (Char.IsUpper(text[index]))
                {
                    indexes.Add(index);
                }
                return Execute(text, indexes, ++index);
            }
            return indexes;
        }
    }
}