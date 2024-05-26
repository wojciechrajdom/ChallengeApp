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

foreach (var item in numbers)
{
    int count = 0;
    foreach (var letter in letters)
    {
        if(item == letter)
        {
            count++;
        }
    }
    Console.WriteLine(item + "=>" + count);
}

