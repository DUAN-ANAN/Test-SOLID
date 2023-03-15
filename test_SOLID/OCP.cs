using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SOLID
{
    internal class OCP
    {
        /*
       * 開放封閉原則:
       * 簡單來說 : 當對原有程式進行擴展時，在不更動到原始碼的前提完成擴展。
       * 開 : 開放擴展
       * 閉 : 封閉修改
       */

        #region ex1
        public class Triangle
        {
            public void show() { Console.WriteLine("三角形"); }
        }

        public class Square
        {
            public void show() { Console.WriteLine("正方形"); }
        }

        //實作方法
        public class Display
        {
            public void ShowSharp(string sharp)
            {
                if (sharp == "三角形")
                {
                    Triangle triangle = new Triangle();
                    triangle.show();
                }
                else if (sharp == "正方形")
                {
                    Square square = new Square();
                    square.show();
                }
                // else if ( sharp == "梯形")
                // else if ( sharp == "八角形")
                // else if ( sharp == "矩形")
                //每增加一種形狀就要實作一次
            }
        }
        #endregion

        #region ex2
        public abstract class Sharp
        {
            public virtual void show() { }
        }

        public class Triangle_v2 : Sharp
        {
            public override void show() { Console.WriteLine("三角形"); }
        }
        public class Square_v2 : Sharp
        {
            public override void show() { Console.WriteLine("正方形"); }
        }

        public class Trapezoidal : Sharp
        {
            public override void show() { Console.WriteLine("正方形"); }
        }

        public class Display_v2
        {
            public Sharp _sharp;

            //依賴注入
            public void SetSharp(Sharp sharp)
            {
                _sharp = sharp;
            }

            public void ShowSharp()
            {
                _sharp.show();
            }
        }

        //呼叫
        public class CallOCP
        {
            public void RunDemoOCP()
            {
                Display_v2 demo = new Display_v2();
                demo._sharp = new Square_v2();
                demo.ShowSharp();
            }
        }
        #endregion
    }
}
