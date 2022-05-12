Console.Write("Enter string: ");
string? str = Console.ReadLine();
if (str == null)
{
    Console.WriteLine("empty");
    return;
}
int maxCount = 0;
for (int i = 0; i < str.Length; i++)
{
    int letterCounter = 1;
    for (int j = i; j < str.Length - 1; j++)
    {
        if (str[j] != str[j + 1])
        {
            letterCounter++;
        }
        else
        {
            i = j;
            if (letterCounter > maxCount)
            {
                maxCount = letterCounter;
            }
            break;
        }
        if (j == str.Length - 2)
        {
            if (letterCounter > maxCount)
            {
                maxCount = letterCounter;
            }
        }
    }
}
Console.WriteLine("Maximum number of unequal consecutive characters in a string: " + maxCount.ToString());