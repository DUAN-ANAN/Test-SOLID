using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SOLID
{
    public class SRP
    {
        /*
         * 單一責任原則:
         * 要求每個類別都應該只有一個職責。
         * 這樣做可以讓類別更容易維護，並且可以降低類別間的相依性。
         * 
         * 高聚合力，提升重用性質。
         */

        #region ex1
        public class User
        {
            public string Name = "";
            public string Password = "";
        }

        public class UserService
        {
            public void AddUser(User user)
            {
                // 檢查使用者資訊是否符合規定
                if (IsValidUser(user))
                {
                    // 將使用者加入資料庫
                    new UserRepository().Add(user);
                }
            }

            private bool IsValidUser(User user)
            {
                // 檢查使用者名稱、密碼等資訊是否符合規定
                // 如果資訊不符合規定，回傳 false
                // 如果資訊符合規定，回傳 true
                bool flag = false;
                return flag;
            }
        }

        public class UserRepository 
        {
            public void Add(User s)
            {
                //將使用者加到資料庫
            }
        }
        #endregion

        #region ex2
        public class Product
        {
            //處理產品相關
        }

        public class Order
        {
            //處理訂單相關
        }

        public class Sales
        {
            //處理業務相關
        }
        #endregion
    }
}
