string MakeStringToPrintArray(string[] arr)
{
  string strPrn = string.Empty;
  for (int i = 0; i < arr.Length - 1; i++) strPrn += $"\"{arr[i]}\", ";
  strPrn = strPrn + "\"" + arr.Last() + "\"";
  return $"[ {strPrn} ]";
}

string[] MakeFilteredArr(string[] arr)
{
  string[] arr2 = new string[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= 3)
    {
      Array.Resize(ref arr2, arr2.Length + 1);
      arr2[arr2.Length - 1] = arr[i];
    }
  }
  return arr2;
}

string[] MakeFilteredArrPoorMemoryUsage(string[] arr)
{
  string[] arr2 = new string[arr.Length];
  int doubleI = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= 3)
    {
      arr2[doubleI] = arr[i];
      doubleI++;
    }
  }
  return arr2;
}


string[] array = new string[] { "1234", "cx21", "x", "4c", "eee", "1", "888", "d345fvaqs", "dd", "s" };

Console.WriteLine(MakeStringToPrintArray(array));
string[] array2 = MakeFilteredArr(array);
Console.WriteLine(MakeStringToPrintArray(array2));
Console.WriteLine(MakeStringToPrintArray(MakeFilteredArrPoorMemoryUsage(array)));