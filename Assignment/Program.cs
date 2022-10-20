
int update = 0;
Timer myTimer = new Timer(test, null, 0, 2000);

void test(object o)
{
    Console.WriteLine(update);
    update++;
}

Console.ReadKey();