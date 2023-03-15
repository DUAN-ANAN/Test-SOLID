using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SOLID
{
    internal class IPS
    {
        /*
        * 介面隔離原則:
        * 應該根據使用者的需求來設計介面，而不是將所有的方法都放在一個大型的介面中
        */
        #region ex1
        public interface IWorker
        {
            void Work();
            void TakeBreak();
            void AttendMeeting();
        }
        public class Manager : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Managing employees...");
            }

            public void TakeBreak()
            {
                Console.WriteLine("Taking a break...");
            }

            public void AttendMeeting()
            {
                Console.WriteLine("Attending a meeting...");
            }
        }
        public class Programmer : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Writing code...");
            }

            public void TakeBreak()
            {
                Console.WriteLine("Taking a break...");
            }

            public void AttendMeeting()
            {
                // Programmer 不需要參加會議
                throw new NotSupportedException();
            }
        }
        #endregion

        // 1. 因為Programmer不用開會，所以把他隔離開。
        // 2. 因為Managa不用coding，所以隔離開。

        #region ex2
        public interface IWorker_v2
        {
            void Work();
            void TakeBreak();
        }

        public interface IManage : IWorker_v2
        {
            void AttendMeeting();
        }

        public interface IProgram : IWorker_v2
        {
            void Coding();
        }

        public class Manager_v2 : IManage
        {
            public void Work()
            {
                Console.WriteLine("Managing employees...");
            }

            public void TakeBreak()
            {
                Console.WriteLine("Taking a break...");
            }

            public void AttendMeeting()
            {
                Console.WriteLine("Attending a meeting...");
            }
        }

        public class Programmer_v2 : IProgram
        {
            public void Work()
            {
                Console.WriteLine("Writing code...");
            }

            public void TakeBreak()
            {
                Console.WriteLine("Taking a break...");
            }
          
            public void Coding()
            {
                //......
            }
        }


        #endregion
    }
}
