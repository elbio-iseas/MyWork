
public class ReverseNo 
{
	static int reverseNum(int num)
	{
		int inverted = 0;
				
		while (num != 0)
		{
			inverted = inverted * 10;
			inverted = inverted + num%10;
			num = num/10;
		}
		return inverted;
	}
	public static void main(String[] args)
	{
		System.out.println(reverseNum(136529));
	}
}
