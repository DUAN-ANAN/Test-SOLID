using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SOLID
{
    internal class DIP
    {
        /*
         * 依賴反轉原則:
         * 強調高層次的模組不應該依賴低層次的模組，而是兩者都應該依賴於抽象介面，抽象介面不應該依賴於具體實現。
         * 
         * 在此示例中，UserService是高層次的模組，它依賴ILogger介面而不是具體的實現。
         * 這樣做的好處是當需要更改ILogger的實現時，只需要新增另一個實現ILogger的類別即可，
         * 而不需要修改UserService。這種方式使程式碼更具彈性和可擴展性，並且符合DIP原則。
         */

        // 定義介面
        public interface ILogger
        {
            void Log(string message);
        }

        // 定義高層次的模組
        public class UserService
        {
            private readonly ILogger _logger;

            public UserService(ILogger logger)
            {
                _logger = logger;
            }

            public void CreateUser(string username, string password)
            {
                // 創建新用戶的邏輯
                _logger.Log($"Created new user: {username}");
            }
        }

        // 定義具體實現
        public class ConsoleLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }

        // 定義另一個具體實現
        public class DatabaseLogger : ILogger
        {
            public void Log(string message)
            {
                // 將日誌訊息寫入資料庫
            }
        }

        // 客戶端程式碼
        class Program
        {
            static void Main(string[] args)
            {
                // 依賴注入
                var logger = new ConsoleLogger();
                var userService = new UserService(logger);

                // 使用 UserService 創建新用戶
                userService.CreateUser("john", "123456");
            }
        }

    }
}
