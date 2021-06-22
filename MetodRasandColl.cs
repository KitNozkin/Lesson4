using System;

public static class StringExtension
{
    public static int CharCount(this string str, char c)
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
                counter++;
        }
        return counter;
    }

    public void Filtration()
    {
        IEnumerable<int> evens = from i in _numbers
                                 where i % 2 == 0 && i > 10
                                 select i;

        IEnumerable<int> evens1 = _numbers.Where(i => i % 2 == 0 && i > 10);

        foreach (int i in evens)
        {
            Debug.Log(i);
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine($"Целые числа");
            List<int> integerList = new List<int>() {
                2, 1, 2, 3, 4, 54, -12, 3, 4, 2, 1, 4, 7, 35, -16, 13, 4,
            };
            Dictionary<int, int> uniqInteger = new Dictionary<int, int>();

            foreach (int i in integerList)
            {
                if (uniqInteger.ContainsKey(i))
                {
                    uniqInteger[i]++;
                }
                else
                {
                    uniqInteger[i] = 1;
                }
            }

            foreach (KeyValuePair<int, int> p in uniqInteger)
            {
                Console.WriteLine($"Элемент {p.Key} встречается {p.Value} раз");
            }
            Console.WriteLine();

            
    