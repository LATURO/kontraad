using System;

namespace ееее
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int size;
			Console.Write("Введите размер массива:");
			size = int.Parse(Console.ReadLine());
			double[] array = new double[size];
			int[] array1 = new int[size];
			double[] array2 = new double[size];
			for (int i = 0; i < size; i++)
			{
				Console.Write("Элемент номер {0}:", i + 1);
				array[i] = double.Parse(Console.ReadLine());
				array1[i] = (int)array[i];
				array2[i] = array[i]-Math.Truncate(array[i]);
			}
			Console.WriteLine("Массив:");
			foreach (double i in array) {
				Console.Write("{0} ",i);
			}
			Console.WriteLine("\r\nЦелые:");
			foreach (int i in array1)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine("Дробные:");
			foreach (double i in array2)
			{
				Console.Write("{0} ", i);
			}
		}
	}
}
