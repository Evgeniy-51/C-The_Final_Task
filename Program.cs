string[] array = { "hello", "2", "world", ":-)" };
// string[] array = { "1234", "1567", "-2", "computer science" };
// string[] array = { "Russia", "Denmark", "Kazan" };
int index = 0;
string[] newArr = new string[0];

void pushFunction(int index, string elem)
{
    string[] tempArr = new string[index];
    tempArr[index - 1] = elem;
    for (int i = 0; i < newArr.Length; i++)
    {
        tempArr[i] = newArr[i];
    }
    newArr = tempArr;
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        index++;
        pushFunction(index, array[i]);
    }
}

Console.WriteLine(String.Join(",  ", newArr));