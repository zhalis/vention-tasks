namespace LINQHomeWork;

public static class ListOperator
{
    public static List<int> GetListDividedByNumberWithoutRemainder(List<int> numbers, int divider) =>
        numbers.Where(number => number % divider == 0).ToList();


    /**
     * Filters collection by range (rangeFrom - inclusively, rangeTo - exclusively)
     */
    public static List<int> FilterByRange(List<int> numbers, int rangeFrom, int rangeTo) =>
        numbers.Where(number => number >= rangeFrom && number < rangeTo).ToList();


    public static Dictionary<int, int> SquareNumbers(List<int> numbers) =>
        numbers.ToDictionary(num => num, num => num * num);

    public static Dictionary<int, int> CalculateFrequencyOfNumbers(List<int> numbers)
    {
        Dictionary<int, int> frequency = numbers
            .GroupBy(num => num)
            .ToDictionary(group => group.Key, group => group.Count());

        return frequency;
    }

    public static List<string> FilterByStartAndEndCharacters(List<string> values, char start, char end) =>
        values.Where(value => value.StartsWith(start) && value.EndsWith(end)).ToList();

    public static List<int> GetGreatestElements(List<int> values, int limit)
    {
        values.Sort((int firstNum, int secondNum) => secondNum.CompareTo(firstNum));
        
        return values.GetRange(0, limit);
    }

    public static List<string> SortByLengthThenByAlphabet(List<string> values)
    {
        values.Sort((string1, string2) => string1.Length.CompareTo(string2.Length) == 0
            ? string1.CompareTo(string2)
            : string1.Length.CompareTo(string2.Length));
        
        return values;
    }

    public static List<string> GetDistinctElementsInAscOrder(List<string> values)
    {
        values.Sort();
        
        return values.Distinct().ToList();
    }
}