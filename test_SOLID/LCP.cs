using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SOLID
{
    internal class LCP
    {
        /*
         * 里氏替換原則:
         * 要求子類別能夠完全替換父類別，並且不會影響系統的正確性。
         * 
         * 在這個範例中，我們使用抽象基類 Vehicle 來表示交通工具，
         * 並讓 Car 和 Truck 類別繼承自 Vehicle，並實作 Drive 方法以表示駕駛該交通工具。
         * 
         * 我們還創建了一個 Driver 類別，可以讓駕駛者駕駛任何一種交通工具，因為 Car 和 Truck 類別都能夠替換 Vehicle 類別。
         */

        #region ex
        public abstract class Vehicle
        {
            public abstract void Drive();
        }
        public class Car : Vehicle
        {
            public override void Drive()
            {
                Console.WriteLine("Driving a car...");
            }
        }
        public class Truck : Vehicle
        {
            public override void Drive()
            {
                Console.WriteLine("Driving a truck...");
            }
        }

        public class Driver
        {
            public void DriveVehicle(Vehicle vehicle)
            {
                vehicle.Drive();
            }
        }


        #endregion
    }
}
