using System.Collections.Generic;

namespace _9_4
{
    public static class ListManipulator
    {

        public static List<int> SortAscending(List<int> intList)
        {
            var sortedList = new List<int>(intList);
            int temp;
            for (int write = 0; write < sortedList.Count; write++)
            {
                for (int sort = 0; sort < sortedList.Count - 1; sort++)
                {
                    if (sortedList[sort] > sortedList[sort + 1])
                    {
                        temp = sortedList[sort + 1];
                        sortedList[sort + 1] = sortedList[sort];
                        sortedList[sort] = temp;
                    }
                }
            }

            return sortedList;
        }

        public static List<int> SortDescending(List<int> intList)
        {
            var sortedList = new List<int>(intList);
            int temp;
            for (int write = 0; write < sortedList.Count; write++)
            {
                for (int sort = 0; sort < sortedList.Count - 1; sort++)
                {
                    if (sortedList[sort] < sortedList[sort + 1])
                    {
                        temp = sortedList[sort + 1];
                        sortedList[sort + 1] = sortedList[sort];
                        sortedList[sort] = temp;
                    }
                }
            }

            return sortedList;
        }

        public static List<int> SumTwoListsWithSameLength(List<int> intListA, List<int> intListB)
        {
            var sumedList = new List<int>();
            for (int i = 0; i < intListA.Count; i++)
            {
                sumedList.Add(intListA[i] + intListB[i]);
            }

            return sumedList;
        }

        public static int FindMaxValue(List<int> intList)
        {
            var maxValue = intList[0];
            for (int i = 1; i < intList.Count; i++)
            {
                if (maxValue < intList[i])
                {
                    maxValue = intList[i];
                }
            }

            return maxValue;
        }

    }

}
