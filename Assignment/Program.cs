
//Basic Timer example
/*
int update = 0;
Timer myTimer = new Timer(carCreate, null, 0, 1500);

void carCreate(object o)
{
    cars();
}
/
int carUpdate = 0;
Timer timer2 = new Timer(updateCar, null, 0, 1500);


void updateCar(object o)
{
    update++;
}
*/

/*
Timer carFuel = new Timer(carLeave, null, 0, 8000);

void carLeave(object o)
{
    pumpQuestion();
}
*/

static void pumps()

{
    string[] pumpsAvailable = new string[9] { "open", "open", "open", "open", "open", "open", "open", "open", "open" };
    Console.WriteLine("Pump 1: " + pumpsAvailable[0] + "        Pump 2: " + pumpsAvailable[1] + "          Pump 3: " + pumpsAvailable[2]);
    Console.WriteLine("Pump 4: " + pumpsAvailable[3] + "        Pump 5: " + pumpsAvailable[4] + "          Pump 6: " + pumpsAvailable[5]);
    Console.WriteLine("Pump 7: " + pumpsAvailable[6] + "        Pump 8: " + pumpsAvailable[7] + "          Pump 9: " + pumpsAvailable[8]);
    Console.WriteLine("Current Cars: ");
    cars();
    pumpQuestion();

}

pumps();





static void cars()
{
    string[] carsQueue = new string[1];

    for (int i = 0; i < carsQueue.Length; i++)
    {
        carsQueue[i] = "1";
        Console.WriteLine(carsQueue[0]);
    }
}



static void pumpQuestion()
{
    string[] pumpsAvailable = new string[9] { "open", "open", "open", "open", "open", "open", "open", "open", "open" };
    int carSend;
    int i = 0;
    do
    {
        Console.WriteLine("Please choose a free pump");
        carSend = Convert.ToInt32(Console.ReadLine());

        if (carSend == 1)
        {
            if (pumpsAvailable[0] == "open")
            {
                Console.WriteLine("The car has been sent to pump 1");
                pumpsAvailable[0] = "Closed";
                Console.WriteLine("Pump 1: " + pumpsAvailable[0] + "        Pump 2: " + pumpsAvailable[1] + "          Pump 3: " + pumpsAvailable[2]);
                Console.WriteLine("Pump 4: " + pumpsAvailable[3] + "        Pump 5: " + pumpsAvailable[4] + "          Pump 6: " + pumpsAvailable[5]);
                Console.WriteLine("Pump 7: " + pumpsAvailable[6] + "        Pump 8: " + pumpsAvailable[7] + "          Pump 9: " + pumpsAvailable[8]);
                pumpQuestion();
                Timer carFuel = new Timer(carLeave, null, 8000, 8000);

                void carLeave(object o)
                {
                    pumpsAvailable[0] = "open";
                }
            }
            else if (pumpsAvailable[0] == "Closed")
            {
                Console.WriteLine("That pump is occupied");
                pumpQuestion();
            }
        }
        if (carSend == 2)
        {
            if (pumpsAvailable[1] == "open")
            {
                Console.WriteLine("The car has been sent to pump 2");
                pumpsAvailable[1] = "Closed";
                Timer carFuel = new Timer(carLeave, null, 8000, 8000);

                void carLeave(object o)
                {
                    pumpsAvailable[1] = "open";
                    Console.WriteLine(pumpsAvailable[1]);
                }
            }
            else
            {
                Console.WriteLine("That pump is occupied");
            }
        }
        if (carSend == 3)
        {
            if (pumpsAvailable[2] == "open")
            {
                Console.WriteLine("The car has been sent to pump 3");
                pumpsAvailable[2] = "Closed";
                Timer carFuel = new Timer(carLeave, null, 8000, 8000);

                void carLeave(object o)
                {
                    pumpsAvailable[2] = "open";
                    Console.WriteLine(pumpsAvailable[2]);
                }
            }
            else
            {
                Console.WriteLine("That pump is occupied");
            }
        }
        if (carSend == 4)
        {
            if (pumpsAvailable[3] == "open")
            {
                Console.WriteLine("The car has been sent to pump 4");
                pumpsAvailable[3] = "Closed";
                Timer carFuel = new Timer(carLeave, null, 8000, 8000);

                void carLeave(object o)
                {
                    pumpsAvailable[3] = "open";
                    Console.WriteLine(pumpsAvailable[3]);
                }
            }
            else
            {
                Console.WriteLine("That pump is occupied");
            }
        }
        if (carSend == 5)
        {
            if (pumpsAvailable[4] == "open")
            {
                Console.WriteLine("The car has been sent to pump 5");
                pumpsAvailable[4] = "Closed";
                Timer carFuel = new Timer(carLeave, null, 8000, 8000);

                void carLeave(object o)
                {
                    pumpsAvailable[4] = "open";
                    Console.WriteLine(pumpsAvailable[4]);
                }
            }
            else
            {
                Console.WriteLine("That pump is occupied");
            }
        }
        if (carSend == 6)
        {
            if (pumpsAvailable[5] == "open")
            {
                Console.WriteLine("The car has been sent to pump 6");
                pumpsAvailable[5] = "Closed";
                Timer carFuel = new Timer(carLeave, null, 8000, 8000);

                void carLeave(object o)
                {
                    pumpsAvailable[5] = "open";
                    Console.WriteLine(pumpsAvailable[5]);
                }
            }
            else
            {
                Console.WriteLine("That pump is occupied");
            }
        }
        if (carSend == 7)
        {
            if (pumpsAvailable[6] == "open")
            {
                Console.WriteLine("The car has been sent to pump 7");
                pumpsAvailable[6] = "Closed";
                Timer carFuel = new Timer(carLeave, null, 8000, 8000);

                void carLeave(object o)
                {
                    pumpsAvailable[6] = "open";
                    Console.WriteLine(pumpsAvailable[6]);
                }
            }
            else
            {
                Console.WriteLine("That pump is occupied");
            }
        }
        if (carSend == 8)
        {
            if (pumpsAvailable[7] == "open")
            {
                Console.WriteLine("The car has been sent to pump 8");
                pumpsAvailable[7] = "Closed";
                Timer carFuel = new Timer(carLeave, null, 8000, 8000);
                void carLeave(object o)
                {
                    pumpsAvailable[7] = "open";
                    Console.WriteLine(pumpsAvailable[7]);
                }
            }

            else
            {
                Console.WriteLine("That pump is occupied");
            }
        }
        if (carSend == 9)
        {
            if (pumpsAvailable[8] == "open")
            {
                Console.WriteLine("The car has been sent to pump 9");
                pumpsAvailable[8] = "Closed";
                Timer carFuel = new Timer(carLeave, null, 8000, 8000);

                void carLeave(object o)
                {
                    pumpsAvailable[8] = "open";
                    Console.WriteLine(pumpsAvailable[8]);
                }
            }
            else
            {
                Console.WriteLine("That pump is occupied");
            }
        }
    }
    while (i < 5);

}








Console.ReadKey();
