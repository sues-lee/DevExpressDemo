using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dapper;
using DexTest.DataSets;
using DexTest.UserControls;
using Entitys.Dashboard;

namespace DexTest
{
    public partial class UserControlTest : System.Web.UI.Page
    {
        const string StrConn = "Data Source=10.1.249.63;User ID=sa;Password=htinns!2013;Initial Catalog=DMP;Pooling=true;MultipleActiveResultSets=true;Connection Timeout=30;min pool size=30;max pool size=60";
        private DataTable dataSourse;
        private Dictionary<string,string> display1; 
        protected void Page_Load(object sender, EventArgs e)
        {
            display1 = new Dictionary<string, string> {{"24小时", "-24"}, {"48小时", "-48"}};
            CallBackDashBoard1.Text = "选择时间范围：";
            CallBackDashBoard1.DisplayList = display1;
            CallBackDashBoard1.Fresh += new CallBackDashBoard.UserEvent(OnDashBoard1Fresh);
            CallBackDashBoard2.Text = "选择时间范围";
            CallBackDashBoard2.DisplayList = display1;
        }

        protected void OnDashBoard1Fresh(object sender, UserEventArgs e)
        {
          
            using (var connection = new SqlConnection(StrConn))
            {
                var registersTendency = new dsRegister.RegistersTendencyDataTable();
                connection.Open();
                string sqlRegistersTendency = String.Format("select mmr.CreateDate ,mmr.[Hour] ,SUM(mmr.DataValue) DataValue " +
                                                                 "from M_MemberRegister mmr WITH(NOLOCK) " +
                                                                 "where mmr.ModifyTime >DATEADD(hour, {0}, GETDATE()) " +
                                                                 "group by mmr.CreateDate,mmr.[Hour] order by mmr.CreateDate,mmr.[Hour]",
                                                                 e.Value);

                var result = connection.Query<RegistersTendencyEntity>(sqlRegistersTendency);
                foreach (var item in result)
                {
                    registersTendency.AddRegistersTendencyRow(item.CreateDate, item.Hour, item.DataValue);
                }

                dataSourse = result;
            }

            CallBackDashBoard1.DataSourse = dataSourse;
        }

        protected void OnDashBoard2Fresh(object sender, UserEventArgs e)
        {

            using (var connection = new SqlConnection(StrConn))
            {
                var registersTendency = new dsRegister.RegistersTendencyDataTable();
                connection.Open();
                string sqlRegistersTendency = String.Format("select  mmr.CreateDate ,mmr.[Hour] ,mmr.MemberLevel,mmr.DataValue DataValue " +
                                                                 "from M_MemberRegister mmr WITH(NOLOCK) " +
                                                                 "where mmr.ModifyTime >DATEADD(hour, {0}, GETDATE()) " +
                                                                 "order by mmr.CreateDate,mmr.[Hour]",
                                                                 e.Value);

                var result = connection.Query<RegistersTendencyEntity>(sqlRegistersTendency);
                foreach (var item in result)
                {
                    registersTendency.AddRegistersTendencyRow(item.CreateDate, item.Hour, item.DataValue);
                }

                dataSourse = registersTendency;
            }

            CallBackDashBoard2.DataSourse = dataSourse;
        }
    }
}