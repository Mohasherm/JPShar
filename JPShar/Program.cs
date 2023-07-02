using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
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
                    metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string='data source={0};initial catalog={2};user id=sa;password={1};MultipleActiveResultSets=True;App=EntityFramework'"
                , serverName, serverP, "JBShar");
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");



                //string providerName = "System.Data.SqlClient";
                //string databaseName = "JBShar";
                //SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder
                //{
                //    // Set the properties for the data source.
                //    DataSource = serverName,
                //    InitialCatalog = databaseName,
                //    IntegratedSecurity = true,
                //    UserID = "sa",
                //    Password = serverP
                //};

                //// Build the SqlConnection connection string.
                //string providerString = sqlBuilder.ToString();

                //// Initialize the EntityConnectionStringBuilder.
                //EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder
                //{
                //    //Set the provider name.
                //    Provider = providerName,

                //    // Set the provider-specific connection string.
                //    ProviderConnectionString = providerString,

                //    // Set the Metadata location.
                //    Metadata = @"res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl"
                //};

                //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                //connectionStringsSection.ConnectionStrings["JBSharEntities"].ConnectionString = entityBuilder.ToString();
                //  config.Save();
                // ConfigurationManager.RefreshSection("connectionStrings");



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
