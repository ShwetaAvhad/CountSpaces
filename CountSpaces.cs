using System;
public class CountSpaces
{
  public static int CountSpacesInString(string inputString)
  {
	int count=0;
	for (int iterate=0;iterate<inputString.Length;iterate++)
	{
		if(inputString[iterate]==' ')
			count++;
	}
	return count;
  }

  static void Main(String [] args)
  {
	Console.WriteLine("Enter Sentence : ");
	string inputString=Console.ReadLine();
	Console.WriteLine("Total spaces : "+CountSpacesInString(inputString));
  }
}