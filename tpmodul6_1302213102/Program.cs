using tpmodul6_1302213102;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design by Contract - Fahryan Anggriantaka");
        Console.WriteLine("Video ditonton sekali");
        video1.IncreasePlayCount(1);
        Console.WriteLine("Video ditonton dua kali");
        video1.IncreasePlayCount(1);
        video1.PrintVideoDetails();
    }
}