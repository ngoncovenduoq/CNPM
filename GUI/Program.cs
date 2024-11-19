using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DTO.Account account = BLL.Login.Load();
            if (account != null)
            {
                char x = account.getTaiKhoan()[0];
                DTO.User user = BLL.User.GetUser(account.getTaiKhoan());
                Static.changeUser(user);
                if (x == 'B' || x == 'b')
                {
                    Application.Run(new Doctor());
                }
                else if (x == 'L' || x == 'l')
                {
                    Application.Run(new Receptionist());
                }
                else
                {
                    Application.Run(new Owner());
                }
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}
