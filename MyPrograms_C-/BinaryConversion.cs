/// <summary>
/// This class has functions that return the bitwise of the String passed
/// </summary>
namespace MyPrograms_C_
{
  /// <summary>
  /// 
  /// </summary>
  class BinaryConversion
  {
    /// <summary>
    /// Update the string variable using the ref/out parameter in the caller function with the 
    /// binary format of the passed string.
    /// </summary>
    /// <param name="str">The string to be converted to bits.</param>
    /// <param name="bitsPerChar">Number of bits needed for a single char, zeros will be padded if 
    /// the converted bit string is less than the given number.</param>
    /// <param name="bitString">Ref parameter string variable, updates the resultant string directly.
    /// </param>
    internal void stringToBits(string str, int bitsPerChar, out string bitString)
    {
      bitString = "";
      foreach(char ch in str.ToCharArray())
      {
        bitString = singleCharToBits(ch, bitsPerChar) + bitString;
      }
    }
    /// <summary>
    /// Returns the bits of the character in string format.
    /// </summary>
    /// <param name="char">Current character that needs to converted to bits</param>
    /// <param name="bitsPerChar">Number of bits for each character</param>
    /// <returns>The passed characted in bits in string format </returns>
    internal string singleCharToBits(char @char, int bitsPerChar)
    {
      int i = (int)@char;
      string bitString = "";
      while(i > 0)
      {
        int temp = i % 2;
        bitString = temp + "" + bitString;
        i = i / 2;
      }
      if (bitsPerChar > bitString.Length)
        bitString = bitString.PadLeft(bitsPerChar, '0');
      return bitString;
    }
  }
}