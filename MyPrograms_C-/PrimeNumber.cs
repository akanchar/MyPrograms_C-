using System.Collections;

/// <summary>
/// The Prime number class has functions that can return the first N prime numbers, 
/// prime numbers between range 'a' and 'b', check if a number is prime or not.
/// </summary>
namespace MyPrograms_C_
{
  class PrimeNumber
  {
    /// <summary>
    /// Checks if the passed numbner is prime or not and returns boolean value.
    /// </summary>
    /// <param name="numberToCheck">Pass the number to checked for primeness</param>
    /// <returns>True or false based on whether the parameter received is Prime or not</returns>
    internal bool checkPrime(int numberToCheck)
    {
      // Returns false if the number if less than or equal to '1'
      // Returns true if the number is equal to '2' as it is the starting prime number
      if (numberToCheck <= 1)
        return false;
      else if (numberToCheck == 2)
        return true;
      // If number greater than '2', loops from '2' to 'number/2' to see if there are any
      // factors of the number. If yes, returns false as the number is not a prime.
      for (int i = 2; i < numberToCheck; i++)
      {
        if (numberToCheck % i == 0)
          return false;
      }
      // Returns true if none of the 'if' conditions are executed in the above for loop
      return true;
    }

    /// <summary>
    ///  Returns the first N prime numbers
    /// </summary>
    /// <param name="numberOfPrimes">Number of primes needed</param>
    /// <returns>Array of ints which consisting of first N prime numbers</returns>
    internal int[] first_N_Primes(int numberOfPrimes)
    {
      int count = 0, startingNumber = 2;
      int[] firstNPrimes = new int[numberOfPrimes];
      // Return NULL on a negative parameter.
      if (numberOfPrimes <= 0)
        return null;

      while (count < numberOfPrimes)
      {
        // Count variable also acts as indexer to the firstNPrimes array as well as
        // keeping track of the total primes added to the array.
        if (checkPrime(startingNumber))
        {
          firstNPrimes[count] = startingNumber;
          count++;
        }
        startingNumber++;
      }
      return firstNPrimes;
    }

    /// <summary>
    /// Returns the total prime numbers present in the given range of numbers (included).
    /// </summary>
    /// <param name="rangeStart">Starting number range</param>
    /// <param name="rangeEnd">Ending number range</param>
    /// <returns>Total prime numbers in between the given range of numbers as an array of ints</returns>
    internal int[] rangedPrimes(int rangeStart, int rangeEnd)
    {
      int[] primeNumbers;
      ArrayList primeNumbersList = new ArrayList();

      // Returns NULL if either is negative OR if rangeEnd is less than rangeStart
      if (rangeEnd < 0 || rangeStart < 0 || rangeEnd < rangeStart)
        return null;

      for (int i = rangeStart; i <= rangeEnd; i++)
        if (checkPrime(i))
          primeNumbersList.Add(i);

      // Initialize the Array
      primeNumbers = new int[primeNumbersList.Count];
      for (int i = 0; i < primeNumbersList.Count; i++)
        primeNumbers[i] = int.Parse(primeNumbersList[i].ToString());
      return primeNumbers;
    }

  }
}