

//String:
//IsNumber() - ფუნქციამ უნდა დააბრუნოს true, თუ string არის რიცხვი
/*
string stringToCheck = "text1";
string[] stringArray = { "text1", "testtest", "test1test2", "test2text1" };
foreach (string x in stringArray)
{
    if (stringToCheck.Contains(x))
    {
        Console.WriteLine(true);
    }
    else 
    { 
        Console.WriteLine(false); }
}
*/
//IsDate() -ფუნქციამ უნდა დააბრუნოს true, თუ string არის თარიღი

/*string inputString = "2000-02-02";
DateTime dDate;
if(DateTime.TryParse(inputString, out dDate))
{
    string.Format("{0:d/MM/yyyy}", dDate);
}
else
{
    Console.WriteLine("Invalid");
}
*/

//ToWords() -ფუნქციამ უნდა დააბრუნოს string[] მასივი, რომლის თითოეულ ელემენტში იქნება ერთი სიტყვა (მაგ. “extension methods”.ToWords() უნდა დააბრუნოს[”extension”, “methods”]

/*
internal class Program
{
    private static void Main(string[] args)
    {
         static string[] ToWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            return words;
        }
        string sentence = "This is a sample sentence.";
        string[] wordArray = ToWords(sentence);
        foreach (string word in wordArray)
        {
            Console.WriteLine(word);
        }
    }
}

*/


//double:
//ToPercent() - უნდა დააბრუნოს რიცხვის პროცენტული მნიშვნელობა (მაგ. 0.5.ToPercent() უნდა დააბრუნოს 50)


//RoundDown() - რიცხვი უნდა დაამრგვალოს უახლოს მცირე მთელ რიცხვამდე (მაგ. 36.7.RoundDown() უნდა დააბრუნოს 36)
/*using System.Threading.Channels;
double number = 36.7;
int roundNumber= (int)Math.Round(number);
Console.WriteLine(roundNumber);
*/
//ToDecimal() - რიცხვი უნდა დააბრუნოს decimal ტიპად
/*
int val = 15;
decimal decVal = Convert.ToDecimal(val);
Console.WriteLine("Converted Int32 {0} to decimal {1:N2} value ", val, decVal);
*/

//IsGreater(double number) -უნდა დააბრუნოს true, თუ რიცხვი მეტია number-ზე
/*
int i = 10;
int number = 8;
if (i > number)
{
    Console.WriteLine(true);
}
else if (i < number)
{
    Console.WriteLine(false);
}
*/
//IsLess(double number) - უნდა დააბრუნოს true, თუ რიცხვი ნაკლებია number-ზე
/*
int i = 5;
int number = 8;
if  (i > number)
{
    Console.WriteLine(false);
}  
else if (i < number)
        { 
    Console.WriteLine(true);
}
*/

// DateTime

//1.Min(DateTime date) - უნდა დააბრუნოს ორ თარიღს შორის რომელიც მცირეა
/*
DateTime date1 = new DateTime(2000, 1, 1);
DateTime date2 = new DateTime(2001, 1, 1);
DateTime minresult = new[] { date1, date2 }.Min();
Console.WriteLine(minresult);
*/
//2.Max(DateTime date) - უნდა დააბრუნოს ორ თარიღს შორის რომელიც მეტია
/*
DateTime date_1 = new DateTime(2000, 1, 1);
DateTime date_2 = new DateTime(2001, 1, 1);
DateTime maxresult = new[] { date1, date2 }.Max();
Console.WriteLine(maxresult); 
*/
//3.BeginingOfMonth() - უნდა დააბრუნოს თარიღის თვის დასაწყისი. მაგ. var date = new DateTime(2022, 11, 23);
//date.BeginingOfMonth() → უნდა დააბრუნოს DateTime(2022, 11, 01)
/*
DateTime now = new DateTime(2023, 06, 06);
var BeginingOfMonth = new DateTime(now.Year, now.Month, 1);
Console.WriteLine($"Begining day of month = {BeginingOfMonth:yyyy-MM-dd}");
*/



/*var today = DateTime.Today;
var monthStart = new DateTime(today.Year, today.Month, 1);
var monthEnd = monthStart.AddMonths(1).AddDays(-1);
var lastMonthStart = monthStart.AddMonths(-1);
var lastMonthEnd = monthStart.AddDays(-1);
Console.WriteLine("Current month start date is: {0}, end date is: {1}", monthStart, monthEnd);
Console.WriteLine("Last month start date is: {0}, end date is: {1}", lastMonthStart, lastMonthEnd);*/

//4.EndOfMonth() - უნდა დააბრუნოს თარიღის თვის ბოლო. მაგ. var date = new DateTime(2022, 11, 23);
//date.BeginingOfMonth() → უნდა დააბრუნოს DateTime(2022, 11, 30)
/*
int daysInMonth = DateTime.DaysInMonth(year: 2023, month: 6);
var lastDayOfMonth = new DateTime(2022, 15, daysInMonth);
Console.WriteLine($"Last day of month = {lastDayOfMonth:yyyy-MM-dd}");
*/