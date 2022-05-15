using System;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            building.SetDataBuild(12, 5, 40, 4);
            Console.WriteLine(building);

            
            building.CulculateHeigthFloors();
            building.CulculateApartmentsInEntrance();
            building.CulculateApartmentsInFloor();
            
            Console.WriteLine();

            Building building2 = new Building();
            building2.SetDataBuild(40, 6, 48, 5);
            Console.WriteLine(building2);

            building2.CulculateHeigthFloors();
            building2.CulculateApartmentsInEntrance();
            building2.CulculateApartmentsInFloor();

            Console.WriteLine();

            Building building3 = new Building();
            building.ChangeBuildingNumber();
            Console.WriteLine(building3);

            Console.ReadKey();
        }
    }
}
