Bus bus = new Bus();
bus.stream = StreamDriving;
Task tasBus = new Task(bus.Driving);
tasBus.Start();

Truck truck = new Truck();
truck.stream = StreamDriving;
Task taskTruck = new Task(truck.Driving);
taskTruck.Start();


Console.ReadLine();


void StreamDriving(string Vehicle, int Speed, int PassedRoute, int RemainedRoute)
{
    Console.WriteLine($"{Vehicle} with {Speed} speed passed {PassedRoute} of route. now {RemainedRoute} remains.");
}

abstract class Vehicle
{
    public delegate void Stream(string VehicleTyle, int Speed, int PassedRoute, int RemainedRoute);
    public Stream? stream;

    public virtual int SpeadIncreasement { get; set; }
    public virtual int Route { get; set; } = 5000;

    public virtual void Driving()
    { }
}

sealed class Bus : Vehicle
{
    public override int SpeadIncreasement { get; set; } = 7;

    public override void Driving()
    {
        int CurrentSpeed = 0;
        int MaximumSpeed = 170;

        int PassedRoute = 0;
        int RemainedRoute = 0;

        do
        {
            Thread.Sleep(1000);
            if(CurrentSpeed <= MaximumSpeed) 
                CurrentSpeed += SpeadIncreasement;

            PassedRoute += CurrentSpeed;
            RemainedRoute = Route - PassedRoute;
            base.stream!(nameof(Bus), CurrentSpeed, PassedRoute, RemainedRoute);
        } while (PassedRoute < base.Route);
    }
}


sealed class Truck : Vehicle
{
    public override int SpeadIncreasement { get; set; } = 5;

    public override void Driving()
    {
        int CurrentSpeed = 0;
        int MaximumSpeed = 170;

        int PassedRoute = 0;
        int RemainedRoute = 0;

        do
        {
            Thread.Sleep(1000);
            if(CurrentSpeed <= MaximumSpeed) 
                CurrentSpeed += SpeadIncreasement;

            PassedRoute += CurrentSpeed;
            RemainedRoute = Route - PassedRoute;
            base.stream!(nameof(Truck), CurrentSpeed, PassedRoute, RemainedRoute);
        } while (PassedRoute < base.Route);
    }
}
