namespace HW16
{
    internal class Program
    {

        static void Main(string[] args)
        {

            _ = PrintAsync(1000, "one");
            _ = PrintAsync(2000, "two");
            _ = PrintAsync(1500, "Three");
            Console.ReadLine();

        }


        static async Task PrintAsync(int delay, string text)
        {
            await Task.Run(() =>
            {
                for(int i = 0; i < 100; i++)
                {
                    Thread.Sleep(delay);
                    Console.WriteLine($"{text} Поток: {Thread.CurrentThread.ManagedThreadId}");
                   
                }
            });
        }


    }
}