using System.Data.SqlClient;
using System.Web.Services;
using System;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Vendas
{
    /// <summary>
    /// Descrição resumida de ProductService
    /// </summary>
    [WebService(Namespace = "http://www.estgp.pt/Vendas")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : System.Web.Services.WebService
    {
        string connectionString =
        "data source=10.30.21.100; initial catalog=Vendas; uid=aluno; pwd=sqlserver";

        //string connectionString =
        //"Server=localhost;Database=master;Trusted_Connection=True;";
        //string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vendas;Integrated Security=True;uid=oo; pwd=root";

        public ProductService()
        {

            //Remova os comentários da linha a seguir se usar componentes designados 
            //InitializeComponent(); 
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }

        [WebMethod]
        public decimal HowMuchWillCost(string productName, int howMany)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(connectionString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandText = "select ListPrice from Product where Name = '" + productName + "'";
                //sqlCmd.CommandText = "select * from ";
                sqlCmd.Connection = sqlConn;
                sqlConn.Open();

                decimal price = (decimal)sqlCmd.ExecuteScalar();

                return price * howMany;
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e.Message);
            }
        }

    }
}