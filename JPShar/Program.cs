using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPShar
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string serverName;
                string serverP;

                StreamReader reader = new StreamReader("S_N.ems");
                serverName = reader.ReadLine();
                reader.Close();

                StreamReader reader2 = new StreamReader("S_S.ems");
                serverP = reader2.ReadLine();
                serverP = serverP.Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "")
                    .Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace(" ", "");
                reader2.Close();             


                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["JBSharEntities"].ConnectionString = string.Format(@"
                    metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string='data source={0};initial catalog={2};user id=sa;password={1};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework'"
                , serverName, serverP, "JBShar");
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

            }
            catch (Exception)
            {
               
            }

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-SA");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCaseRecord());
        }
    }
}
