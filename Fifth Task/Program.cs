internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write("Введите элементы массива через пробел: ");

		string[] elements = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

		if (elements.Length == 0)
		{
			Console.WriteLine("Нет элементов для сортировки");
		}
		else
		{
			int[] mass = new int[elements.Length];
			for (int i = 0; i < elements.Length; i++)
			{
				bool isParsed = int.TryParse(elements[i], out mass[i]);
				if (isParsed == false)
				{
					Console.WriteLine("Введено некорректное значение в элементе " + i + ", он будет отображен как 0");
				}
			}

			Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", Sort(mass)));
		}
	}
	private static int[] Sort(int[] mass)
	{
		int length = mass.Length;
		for (int i = 1; i < length; i++)
		{
			for (int j = 0; j < length - i; j++)
			{
				if (mass[j] > mass[j + 1])
				{
					(mass[j], mass[j + 1]) = (mass[j + 1], mass[j]);
				}
			}
		}

		return mass;
	}
}