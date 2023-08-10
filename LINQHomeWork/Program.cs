namespace LINQHomeWork;

class Program
{
    public static void Main(string[] args)
    {
        Func<string, int, string> concatIntToString = (acc, next) => acc + $" {next}";

        Console.WriteLine("_________________________Task1_________________________________");
        List<int> task1Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int divider = 2;
        Console.WriteLine(ListOperator.GetListDividedByNumberWithoutRemainder(task1Numbers, divider)
            .Aggregate($"The numbers which produce the remainder 0 after divided by {divider} are:",
                concatIntToString));

        Console.WriteLine("_________________________Task2_________________________________");
        List<int> task2Numbers = new List<int> { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
        int rangeFrom = 1;
        int rangeTo = 11;
        Console.WriteLine(string.Join(" ", ListOperator.FilterByRange(task2Numbers, rangeFrom, rangeTo)));


        Console.WriteLine("_________________________Task3_________________________________");
        List<int> task3Numbers = new List<int> { 9, 8, 6, 5 };
        foreach (var keyValuePair in ListOperator.SquareNumbers(task3Numbers))
        {
            Console.WriteLine($"Number = {keyValuePair.Key}, SqrNo = {keyValuePair.Value}");
        }


        Console.WriteLine("_________________________Task4_________________________________");
        List<int> task4Numbers = new List<int> { 1, 2, 3, 1, 2, 1, 3, 7, 3, 8 };
        foreach (var keyValuePair in ListOperator.CalculateFrequencyOfNumbers(task4Numbers))
        {
            Console.WriteLine($"Number {keyValuePair.Key} appears {keyValuePair.Value} times");
        }


        Console.WriteLine("_________________________Task5_________________________________");
        List<string> task5And7Cities = new List<string>
        {
            "ZURICH", "LONDON", "NAIROBI", "ROME", "CALIFORNIA", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"
        };
        char start = 'A';
        char end = 'M';
        ListOperator.FilterByStartAndEndCharacters(task5And7Cities, start, end)
            .ForEach(Console.WriteLine);


        Console.WriteLine("_________________________Task6_________________________________");
        List<int> task6Numbers = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };
        int limit = 3;
        Console.WriteLine(ListOperator.GetGreatestElements(task6Numbers, limit)
            .Aggregate($"The top {limit} records from the list are:", concatIntToString));


        Console.WriteLine("_________________________Task7_________________________________");
        ListOperator.SortByLengthThenByAlphabet(task5And7Cities)
            .ForEach(Console.WriteLine);


        Console.WriteLine("_________________________Task8_________________________________");
        List<string> task8Words = new List<string>
        {
            "Butter", "Biscuit", "Brade", "Biscuit", "Honey", "Brade", "Biscuit", "Honey", "Butter"
        };
        ListOperator.GetDistinctElementsInAscOrder(task8Words)
            .ForEach(Console.WriteLine);
    }
}