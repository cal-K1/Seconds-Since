long seconds = 0;

while (true)
{
    seconds++;
    Thread.Sleep(1000);

    Console.Clear();
    Console.WriteLine(seconds.ToString());
}
