namespace hierarchical_inheritance
{
    internal class Transport
    {
        static void Main(string[] args)
        {
            Truck tr1 = new Truck(50,"mahindra",200,50,10,60);
            tr1.display();
            int fNeed = tr1.fuelNeeded(100);
            Console.WriteLine("Fuel needed for 100 km"+fNeed);
            int totaldistance=tr1.distanceCovered(5);
            Console.WriteLine("___________________________________");
            Bus b1 = new Bus(100, "Eicher",100, 50, 5, 30);
            b1.display();  
           
        }
    }
}
