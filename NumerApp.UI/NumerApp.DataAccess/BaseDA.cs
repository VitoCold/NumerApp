using System.Configuration;

namespace NumerApp.DataAccess
{
    public class BaseDA
    {
        public string GetCnxStringCartaDB
        {
            get { return ConfigurationManager.ConnectionStrings["CartasCnxString"]
                        .ConnectionString;
            }
        }


    }
}
