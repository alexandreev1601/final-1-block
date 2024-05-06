using System;

string[] array = { "a", "bb", "ccc", "dddd", "eeeee", "z" }; 
var result = new string[array.Length];

var realSize = 0;

foreach (var value in array) {

  if (value.Length <= 3) {

    result[realSize] = value;

    realSize++;

  }

}

for(int i = 0; i < result.Length; i++)
{
    System.Console.Write(result[i] + " ");
}