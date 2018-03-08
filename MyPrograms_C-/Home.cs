using System;

namespace MyPrograms_C_
{
  class Home
  {
    public static void Main(String[] args)
    {
      BinaryConversion binaryConversion = new BinaryConversion();
      string str;
      binaryConversion.stringToBits("aA", 8, out str);
      Console.WriteLine(str);
    }
  }
}