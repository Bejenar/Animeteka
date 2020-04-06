using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animeteka.Forms;

namespace Animeteka
{
    static class Program
    {
        public static AnimetekaContext db;
        public static bool is_admin = true;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            db = new AnimetekaContext();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new AdvancedSearch().Show();
            Application.Run();
        }

        public static void CloseAllButSearch()
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    Console.WriteLine(form.Name);
                    if (form.Name == "AdvancedSearch")
                        form.Show();
                    else if (form.Name != "WelcomePage" && form.Name != "Authorization")
                    {
                        form.Close();                      
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
