//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Random r = new Random();
int numberOne = r.Next(1, 6);
int numberTwo = r.Next(1, 6);
int numberSum = numberOne + numberTwo;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Text;

namespace ConsoleApplication
{
   Class Program
   {
      static void Main(string[] args)
	  {
	     string fileName = "test.text";
		 string textToAdd = "Example text in file";
		 
		 using (StreamWriter writer = new StreamWriter(fileName))
		 {
		     writer.Write(textToAdd);
		 }
	  }

   }
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;

class Test
{
    public static void Main()
	{
	  	  
	  try
          {
		     // Create an instance of Streamreader to read from a file.
	         // the using statement also closes the StreamReader.
			 using (StreamReader sr = new StreamReader("TestFile.txt")
			 {
			     string line;
				 // Read and display lines from the file until the end of 
				 // the file is reached.
				 while ((line = sr.ReadLine()) != null)
                 {
				     Console.WriteLine(line);
                 } 				 
			 }
		  }
      catch (Exception e)
          {
		     // Let the user know what went wrong.
			 Console.WriteLine("The file could not be read:");
			 Console.WriteLine(e.Message);
		  }		  
	}
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

   
        


















