package isolated;

import java.util.List;
import java.util.Map;

import com.sun.xml.internal.ws.util.StringUtils;

public class acronym {
	/**
	 * 1. Convert a phrase to its acronym. Techies love their TLA (Three Letter
	 * Acronyms)! Help generate some jargon by writing a program that converts a
	 * long name like Portable Network Graphics to its acronym (PNG).
	 * 
	 * @param phrase
	 * @return
	 */
	@SuppressWarnings("null")
	public static String acronym(String phrase) 
	{
		
		// TODO Write an implementation for this method declaration
		
		// sigla is acronym in Spanish
		// sigla will accumulate the first letters of each word to create the acronym
		String sigla = "";
		
		// splittedPhrase will store all the words found in phrase
		String[] splittedPhrase = phrase.split(" ");
		
        // totElements will store the number of words in the splittedPhrase array
        int totElements = splittedPhrase.length;
        
        // This for loop will go visiting each element of the array splittedPhrase
		for (int i = 0; i < totElements; i++)
			{
				// sigla will be adding the first letter in upper case
			    // of each word in the String array splittedPhrase
			
				sigla = sigla + splittedPhrase[i].substring(0,1).toUpperCase();				
			}
		

		// it returns the acronym of the phrase passed		
		return sigla;
		
	}
	
	
	/**
	 * 2. Given a word, compute the scrabble score for that word.
	 * 
	 * --Letter Values-- Letter Value A, E, I, O, U, L, N, R, S, T = 1; D, G = 2; B,
	 * C, M, P = 3; F, H, V, W, Y = 4; K = 5; J, X = 8; Q, Z = 10; Examples
	 * "cabbage" should be scored as worth 14 points:
	 * 
	 * 3 points for C, 1 point for A, twice 3 points for B, twice 2 points for G, 1
	 * point for E And to total:
	 * 
	 * 3 + 2*1 + 2*3 + 2 + 1 = 3 + 2 + 6 + 3 = 5 + 9 = 14
	 * 
	 * 
	 * @param string
	 * @return
	 */
	private static int getScrabbleScore(String string)
	{
		// TODO Write an implementation for this method declaration
		

		String onePt = "AEIOULNRSTaeioulnrst";		
		String twoPts = "DGdg";	
		String threePts = "BCMPbcmp";		
		String fourPts = "FHVWYfhvwy";		
		String fivePts = "Kk";		
		String eightPts = "JXjx";		
		String tenPts = "QZqz";     
		
		//  Score accumulator variable 
		int score = 0;
		//  Stores the length of the string passed
		int stringLen = string.length();
		//  It creates a variable to store the character to find
		char charToFind;
		//  for loop to travel the string to accumulate the points
		for (int i = 0; i < stringLen; i++)
		{
			// stores a character from the string passed, to look for in the other strings
			charToFind = string.charAt(i);
			// it checks if the char to find is in the string			
			if (onePt.indexOf(charToFind)>= 0)
			{
				// it accumulates points to the score variable
				score = score + 1;
			}
			if (twoPts.indexOf(charToFind)>= 0)
			{
				// it accumulates points to the score variable
				score = score + 2;
			}
			if (threePts.indexOf(charToFind)>= 0)
			{
				// it accumulates points to the score variable
				score = score + 3;
			}
			if (fourPts.indexOf(charToFind)>= 0)
			{
				// it accumulates points to the score variable
				score = score + 4;
			}
			if (fivePts.indexOf(charToFind)>= 0)
			{
				// it accumulates points to the score variable
				score = score + 5;
			}
			if (eightPts.indexOf(charToFind)>= 0)
			{
				// it accumulates points to the score variable
				score = score + 8;
			}
			if (tenPts.indexOf(charToFind)>= 0)
			{
				// it accumulates points to the score variable
				score = score + 10;
			}
		}
		
		// it returns the score calculated
		return score;

	}

	/**
	 * 3. Clean up user-entered phone numbers so that they can be sent SMS messages.
	 * 
	 * The North American Numbering Plan (NANP) is a telephone numbering system used
	 * by many countries in North America like the United States, Canada or Bermuda.
	 * All NANP-countries share the same international country code: 1.
	 * 
	 * NANP numbers are ten-digit numbers consisting of a three-digit Numbering Plan
	 * Area code, commonly known as area code, followed by a seven-digit local
	 * number. The first three digits of the local number represent the exchange
	 * code, followed by the unique four-digit number which is the subscriber
	 * number.
	 * 
	 * The format is usually represented as
	 * 
	 * 1 (NXX)-NXX-XXXX where N is any digit from 2 through 9 and X is any digit
	 * from 0 through 9.
	 * 
	 * Your task is to clean up differently formatted telephone numbers by removing
	 * punctuation and the country code (1) if present.
	 * 
	 * For example, the inputs
	 * 
	 * +1 (613)-995-0253 613-995-0253 1 613 995 0253 613.995.0253 should all produce
	 * the output
	 * 
	 * 6139950253
	 * 
	 * Note: As this exercise only deals with telephone numbers used in
	 * NANP-countries, only 1 is considered a valid country code.
	 */
	public static String cleanPhoneNumber(String string) 
	{
		// TODO Write an implementation for this method declaration
		
		char currentChar;
		String phoneNum = "";
		int lenParam = string.length();
		int i;
		for (i = 0; i < lenParam; i++)
		{
			currentChar = string.charAt(i);
			if (Character.isDigit(currentChar))
			{
				phoneNum = phoneNum + currentChar;
			}			
		 }
		if (phoneNum.length() == 11)
		{
			phoneNum = phoneNum.substring(1); 
		}
		return phoneNum;
	}
	/**
	 * 4. Given a phrase, count the occurrences of each word in that phrase.
	 * 
	 * For example for the input "olly olly in come free" olly: 2 in: 1 come: 1
	 * free: 1
	 * 
	 * @param string
	 * @return
	 */
	public Map<String, Integer> wordCount(String string) 
	{
		// TODO Write an implementation for this method declaration
		
		
		return null;
	}
	
	/**
	 * 6. An Armstrong number is a number that is the sum of its own digits each
	 * raised to the power of the number of digits.
	 * 
	 * For example:
	 * 
	 * 9 is an Armstrong number, because 9 = 9^1 = 9 10 is not an Armstrong number,
	 * because 10 != 1^2 + 0^2 = 2 153 is an Armstrong number, because: 153 = 1^3 +
	 * 5^3 + 3^3 = 1 + 125 + 27 = 153 154 is not an Armstrong number, because: 154
	 * != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190 Write some code to determine whether
	 * a number is an Armstrong number.
	 * 
	 * @param input
	 * @return
	 */
	public static boolean isArmstrongNumber(int input) 
	{
		// TODO Write an implementation for this method declaration
		// Converting to integer and storing for convenient string manipulation
		String stringInput = Integer.toString(input);
		// calculating the length of the integer to use it for powering the base
		int numOfDigits = stringInput.length();
		// number to compare to the input parameter to determine if it is an Armstrong number or not
		int total = 0;
		// variable to use with the for loop
		int i = 0;
		// integer variable to store each digit in the input parameter
		int numAux = 0;
		// integer to store the result of elevating numAux to the numOfDigits power
		int numElevated = 0;
		// for loop to travel the input number and acumulating the numElevated
		for ( i = 0; i < numOfDigits; i++)
		{
		    // converting the integer and storing each digit in input	
			numAux = Character.getNumericValue(stringInput.charAt(i));
			// elevating the digit to the numOfDigits power
			numElevated = (int) Math.pow(numAux, numOfDigits);
			// accumulating the total to compare to the input parameter 
			total = total + numElevated;		
		}
		// if total equals input then it is an Armstrong number
		if (total == input) {
			return true;
		}
		// otherwise it is not an Armstrong number
		else {
			return false;
		}
	}

	/**
	 * 10. Parse and evaluate simple math word problems returning the answer as an
	 * integer.
	 * 
	 * Add two numbers together.
	 * 
	 * What is 5 plus 13?
	 * 
	 * 18
	 * 
	 * Now, perform the other three operations.
	 * 
	 * What is 7 minus 5?
	 * 
	 * 2
	 * 
	 * What is 6 multiplied by 4?
	 * 
	 * 24
	 * 
	 * What is 25 divided by 5?
	 * 
	 * 5
	 * 
	 * @param string
	 * @return
	 */
	public static int solveWordProblem(String string) 
	{
		// TODO Write an implementation for this method declaration
		
		int mark = string.indexOf('?'); 
		
		System.out.println("mark = " + mark);
		
		String anotherString = string.substring(0,mark);
		
		System.out.println("anotherString = " + anotherString);
				
		String[] paramWords = anotherString.split(" ");
		
		boolean addition = false;

		boolean subtraction = false;
		
		boolean multiplication = false;
		
		boolean division = false;
		
		int result = 0;
			
		if (string.indexOf("plus")>-1) 
		{
			addition = true;
		}
		else if (string.indexOf("minus")>-1)
		{
			subtraction = true;
		}
		else if (string.indexOf("multiplied")>-1)
		{
			multiplication = true;
		}
		else if (string.indexOf("divided")>-1)
		{
			division = true;
		}
		
		System.out.println(paramWords[(paramWords.length-1)]);
		
		int[] numbers = new int[2];	
		
		int i;
		
		int j = 0;
		
		for (i = 0; i < paramWords.length -1; i++)
		{
			if (StringUtils.(paramWords[i]))
				{
				   numbers[j] = Integer.valueOf(paramWords[i]);
				   System.out.println(paramWords[i]);
				   j++;
				}
		}
		
		if (addition) 
		{
			result = numbers[0] + numbers[1];
		}
		else if (subtraction) 
		{
			result = numbers[0] - numbers[1];
		}
		else if (multiplication) 
		{
			result = numbers[0] * numbers[1];
		}
		else if (division) 
		{
			result = numbers[0] / numbers[1];
		}
		
		System.out.println(numbers[0]);
		
		System.out.println(numbers[1]);
		
		return result;
	}


	public static void main(String[] args)
	{
		System.out.println(acronym("Portable Network Graphics"));
		System.out.println(acronym("First In, First Out"));
		System.out.println(acronym("Last In, First Out"));
		System.out.println(acronym("GNU Image Manipulation Program"));
		
		System.out.println("The Scrabble score for 'f' is " + getScrabbleScore("f"));
		System.out.println("The Scrabble score for 'zoo' is " + getScrabbleScore("zoo"));
		System.out.println("The Scrabble score for 'street' is " + getScrabbleScore("street"));
		System.out.println("The Scrabble score for 'quirky' is " + getScrabbleScore("quirky"));
		System.out.println("The Scrabble score for 'OxyphenButazone' is " + getScrabbleScore("OxyphenButazone"));
		
		System.out.println("The phone number is " + cleanPhoneNumber("(801) 245-1803"));
		System.out.println("The phone number is " + cleanPhoneNumber("1 (800) 245-1803"));
		System.out.println("The phone number is " + cleanPhoneNumber("aK!2899-3189"));
		System.out.println("The phone number is " + cleanPhoneNumber("801   253-1600!"));
		System.out.println("The phone number is " + cleanPhoneNumber("1 (800) 245-1803"));
		
		System.out.println("The Armstrong number 153 is " + isArmstrongNumber(153));
		System.out.println("The Armstrong number 1 is " + isArmstrongNumber(1));
		System.out.println("The Armstrong number 370 is " + isArmstrongNumber(370));
		System.out.println("The Armstrong number 0 is " + isArmstrongNumber(0));
		System.out.println("The Armstrong number 371 is " + isArmstrongNumber(371));
		System.out.println("The Armstrong number 407 is " + isArmstrongNumber(407));
		System.out.println("The Armstrong number 18 is " + isArmstrongNumber(18));
		System.out.println("The Armstrong number 26 is " + isArmstrongNumber(26));
		System.out.println("The Armstrong number 129 is " + isArmstrongNumber(129));
			
		System.out.println("The result of adding 5 + 13 is " + solveWordProblem("What is 5 plus 13?"));
		System.out.println("The result of adding -1 + -10 is " + solveWordProblem("What is -1 plus -10?"));
		System.out.println("The result of adding 4 + -12 is " + solveWordProblem("What is 4 plus -12?"));
		System.out.println("The result of adding 7 - 5 is " + solveWordProblem("What is 7 minus 5?"));
		System.out.println("The result of adding 6 * 4 is " + solveWordProblem("What is 6 multiplied by 4?"));
		System.out.println("The result of adding 25 / 5 is " + solveWordProblem("What is 25 divided by 5?"));
	}
}



