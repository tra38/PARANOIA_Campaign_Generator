using System;
using System.Collections.Generic;

public static class SectorGenerator
{
  public static string Generate()
  {
    return $"{RandomLetter()}{RandomLetter()}{RandomLetter()}";
  }
 
  public static Func<string> RandomLetter = Generator.GenerateRule<string>(
    new List<string>
    {
      "A",
      "B",
      "C",
      "D",
      "E",
      "F",
      "G",
      "H",
      "I",
      "J",
      "K",
      "L",
      "M",
      "N",
      "O",
      "P",
      "Q",
      "R",
      "S",
      "T",
      "U",
      "V",
      "W",
      "X",
      "Y",
      "Z"
    });
}