namespace P02_Lake;
class Program
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();
        Lake l = new Lake(nums);

        foreach (var num in l)
        {
            Console.WriteLine(num + " ") ;
        }
 
    }
}

