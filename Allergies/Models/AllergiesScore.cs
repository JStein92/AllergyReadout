using System;
using System.Collections.Generic;

namespace Allergies.Models
{
  public class AllergiesScore
  {
    private int _userScore;
    private List<string> _allergyList = new List<string>{"cats","pollen","chocolate","tomatoes","strawberries","shellfish","peanuts","eggs"};
    private List<string> _userAllergies = new List<string>{};

    public AllergiesScore(int score)
    {
      _userScore = score;
    }

    public string ConvertToBinary(int binary)
    {
      string newBinary = Convert.ToString(binary, 2);
      Console.WriteLine(newBinary);
      return newBinary;
    }

    public List<string> ReadBinary()
    {
      string binaryString = ConvertToBinary(_userScore);

      int compensator = (_allergyList.Count - binaryString.Length);
      for (int i= 0 ; i < binaryString.Length; i++)
      {
        if (binaryString[i] == '1')
        {
          _userAllergies.Add(_allergyList[i + compensator]);
        }
      }
      // foreach (string s in _userAllergies)
      // {
      //   Console.WriteLine(s);
      // }
      return _userAllergies;
    }
  }
}
