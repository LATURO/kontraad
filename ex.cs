using System;

namespace ееее
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int size;
			double summ = 0;
			Console.Write("Введите размер массива:");
			size = int.Parse(Console.ReadLine());
			double[] array = new double[size];
			double[] array2 = new double[size + 1];
			for (int i = 0; i < size; i++) {
				Console.Write("Элемент номер {0}:",i+1);
				array[i] = double.Parse(Console.ReadLine());
				array2[i] = array[i];
			}
			foreach (double i in array) {
				summ += i;
			}
			array2[size] = summ;
			Console.WriteLine("\r\nПоследний элемент это сумма массива:");
			foreach (double i in array2) {
				Console.Write("{0} ", i);
			}
		}
	}
}
