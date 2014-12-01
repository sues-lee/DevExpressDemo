using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = ConfigurationManager.ConnectionStrings["DMP"].ConnectionString;


            using (var connection = new SqlConnection(str))
            {
                connection.Open();


                var result = connection.Query<MemberRegister>("select * from dbo.M_MemberRegister");
                result.ToList().ForEach(a => Console.WriteLine(a.Id));
                 Console.ReadLine();

                //Console.WriteLine(re);
            }

        }
    }

    public class MemberRegister
    {
        public int Id { get; set; }

        public string MemberLevel { get; set; }

        public int DataValue { get; set; }
    }
}
