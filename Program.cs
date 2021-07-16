using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractsV4._0
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Entities.MyDBContext c = new Entities.MyDBContext();

            //c.Users.Add(new Entities.User() { Name = "1", Surname = "2" });
            //c.SaveChanges();
            
            Application.Run(new SelectForm());
        }
    }
}
