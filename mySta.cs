using System;

public class myStack<T>
{
	 int position;  
	 T[] numbers;
	int maxSize;

	public myStack(int size)
	{
			maxSize = size;
			position = 0;
			numbers = new T[size];
	}

	public void myPush(T a)
	{
		if (position + 1 == maxSize)
		{
			Console.WriteLine("your stack full");
			System.Environment.Exit(0);
		}
		else
		{
			numbers[position] = a;
			position++;
		}	
	}
	
	public T myPop()
	{
		
		if (position + 1 == maxSize)
		{
			Console.WriteLine("your stack full");
			//System.Environment.Exit(0);
		}
			position--;
			return numbers[position + 1];
		
	}
	
	public T myTop()
	{
		return numbers[position-1];
	}

	public int staSize() 
	{
		return position;
	}
}
