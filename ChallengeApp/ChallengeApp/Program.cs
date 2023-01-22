int number = 5129;

string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

List<char> numbers = new List<char>();
numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

foreach(var digit in numbers)
{
    int count = 0;
    foreach (var letter in letters)
    { 
        if(digit == letter)
        {
            count++;
        }
    
    }
    Console.WriteLine(digit + "=>" + count);
}









// int[] grades = new int[365];

// List<string> daysOfWeeks = new List<string>();
// daysOfWeeks.Add("poniedziałek");
// daysOfWeeks.Add("wtorek");
// daysOfWeeks.Add("środa");
// daysOfWeeks.Add("czwartek");
// daysOfWeeks.Add("piątek");
// daysOfWeeks.Add("sobota");
// daysOfWeeks.Add("niedziela");

// foreach(var day in daysOfWeeks)
{
   // Console.WriteLine(day);
}




// for (var i=0; i<daysOfWeeks.Count; i++)
{
   // Console.WriteLine(daysOfWeeks[i]);
}








