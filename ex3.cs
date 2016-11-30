using System;

namespace ееее
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] array = new int[100];
			for (int i = 0,j=1; i < 100; i+=2,j++){
				array[i] = j;
				array[i+1] = -j;
			}

			foreach (int i in array) {
				Console.WriteLine("{0}", i);
			}
		}
	}
}
