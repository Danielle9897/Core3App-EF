using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProfilerWithCore3
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();
            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
                                                     Application.EnableVisualStyles();
                                                     Application.SetCompatibleTextRenderingDefault(false);
                                                     Application.Run(new Form1());
        }
    }
}
