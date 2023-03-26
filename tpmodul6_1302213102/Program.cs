using tpmodul6_1302213102;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design by Contract - Fahryan Anggriantaka");
            Console.WriteLine("Video ditonton sekali");
            video1.IncreasePlayCount(1);
            Console.WriteLine("Video ditonton dua kali");
            video1.IncreasePlayCount(1);
            video1.PrintVideoDetails();
            Console.WriteLine();

            Console.WriteLine("Video ditonton nyaris limit int");
            for (int i = 0; i < 214; i++)
            {
                video1.IncreasePlayCount(10000000);
            }
            video1.PrintVideoDetails();
            Console.WriteLine(); 

            Console.WriteLine("COBA DI OVRFLOWIN DENGAN DITAMBAH 10.000.000 lagi");
            video1.IncreasePlayCount(10000000);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow nih");
        }
    }
}