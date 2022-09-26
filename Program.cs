internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Let's calculate room details :)");

		Console.Write("Enter Length: ");
		float length = float.Parse(Console.ReadLine());
		Console.Write("Enter Width: ");
		float width = float.Parse(Console.ReadLine());

		Console.WriteLine("If you'd like the volume of the room, please enter a height. If not, enter 0.");

		Console.Write("Enter Height: ");
		float height = float.Parse(Console.ReadLine());

		float area = length * width;
		float perimeter = 2 * (length + width);
		float volume = length * width * height;
		float surface = 2 * (length*width) + 2 * (width*height) + 2 * (length*height);
		
		Console.WriteLine("----------------------------");
		Console.WriteLine("Area: "+ area);
		Console.WriteLine("Perimeter: " + perimeter);
		if (area <= 250)
		{
			Console.WriteLine("This is a smaller room.");
		} else if (area >= 650)
		{
			Console.WriteLine("This is a Larger room.");
		} else
		{
			Console.WriteLine("This is a medium-sized room.");
		}

		if (height > 0)
		{
			Console.WriteLine("Volume: " + volume);
			Console.WriteLine("Surface Area: " + surface);
		}
	}
}