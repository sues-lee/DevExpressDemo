using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;

namespace DexTest.DashBoards
{
    public partial class DashboardRegister : DevExpress.DashboardCommon.Dashboard
    {
        public DashboardRegister()
        {
            InitializeComponent();
        }


        private string connectstring =
            "Data Source=10.1.249.63;User ID=sa;Password=htinns!2013;Initial Catalog=DMP;Pooling=true;MultipleActiveResultSets=true;Connection Timeout=30;min pool size=30;max pool size=60";
        private void DashboardRegister_DashboardLoading(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connectstring))
            {
                conn.Open();
                var result = conn.Query("select * from dbo.M_MemberRegister");
            }
            // chartDashboardItem1.DataSource=new 
        }
    }
}
