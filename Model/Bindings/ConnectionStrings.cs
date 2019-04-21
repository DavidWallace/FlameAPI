using System;
using Microsoft.Extensions.Configuration;

namespace FlameAPI.Model.Bindings
{
    public class ConnectionStrings
    {
        public string Datasource { get; set; }
        public string Database { get; set; }
        public string IntegratedSecurity { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

        // Computed property that constructs database connection string
        public string DefaultConnection
        {
            get
            {
                var str =
                       $"Data Source = { Datasource };" +
                       $"Database = { Database };" +
                       $"Integrated Security = { IntegratedSecurity };" +
                       $"User ID = { UserId };" +
                       $"Password = { Password };";

                return str;
            }
        }
        public static ConnectionStrings ConnectionStringConstructor(IConfigurationRoot config)
        {

            var conStr = new ConnectionStrings();
            conStr.Datasource = config["ConnectionStrings:Datasource"];
            conStr.Database = config["ConnectionStrings:Database"];
            conStr.UserId = config["ConnectionStrings:UserId"];
            conStr.Password = config["ConnectionStrings:Password"];
            conStr.IntegratedSecurity = config["ConnectionStrings:IntegratedSecurity"];

            return conStr;
        }
    }
}
