using Abstract_classes;


Vehicle[] transport =
{
    new Car(120),
    new Train(80)
};

foreach (var vehicle in transport)
{
    Console.Write(vehicle.GetCurrentSpeed() + " ");
    vehicle.Move();
}