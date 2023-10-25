using BATYAKINNORY_EX05;



    Audi car1 = new Audi();
    car1.DisplaySpeed();

    Console.Write("Enter acceleration for Audi: ");
    int audiAcceleration = int.Parse(Console.ReadLine());
    for (int i = 0; i < audiAcceleration; i++)
    {
        car1.Accelerate();
    }

    car1.DisplaySpeed();
    car1.Decelerate();
    car1.Decelerate();
    car1.DisplaySpeed();
    car1.Stop();

    Lexus car2 = new Lexus();
    car2.DisplaySpeed();

    Console.Write("Enter acceleration for Lexus: ");
    int lexusAcceleration = int.Parse(Console.ReadLine());
    for (int i = 0; i < lexusAcceleration; i++)
    {
        car2.Accelerate();
    }

    car2.DisplaySpeed();
    car2.StartPlayingSongs();
    car2.Decelerate();
    car2.Decelerate();
    car2.DisplaySpeed();
    car2.StopPlayingSongs();
    car2.Stop();

