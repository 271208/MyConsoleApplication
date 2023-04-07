var myArr = new string[]
{
   "hello",
    "2",
    "world",
    ":-)"
};
int count = 0;

for (int x = 0; x < myArr.Length; x++)
{
    if (myArr[x].Length < 4)
        count++;
}

var resultArr = new string[count];
int pos = 0;

for (int c = 0; c < myArr.Length; c++)
{
    if (pos == resultArr.Length)
    {
        break;
    }
    if (myArr[c].Length < 4)
    {
        resultArr[pos++] = $"\"{myArr[c]}\"";
    }
}

Console.Write($"[{string.Join(", ", resultArr)}]");