using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dapper;
using DevExpress.DataAccess.ConnectionParameters;
using Entitys.Dashboard;

namespace DexTest
{
    public partial class Viewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        const string strConn = "Data Source=10.1.249.63;User ID=sa;Password=htinns!2013;Initial Catalog=DMP;Pooling=true;MultipleActiveResultSets=true;Connection Timeout=30;min pool size=30;max pool size=60";
             
        protected void ConfigureDataConnection(object sender, DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs e)
        {
            //var parameters = e.ConnectionParameters as MsSqlConnectionParameters;
            //if (parameters != null)
            //{
            //    parameters.AuthorizationType = MsSqlAuthorizationType.SqlServer;
            //    parameters.UserName = "sa";
            //    parameters.Password = "htinns!2013";
            //}
        }

        protected void ASPxDashboardViewer1_DataLoading(object sender, DevExpress.DashboardWeb.DataLoadingWebEventArgs e)
        {
            if (e.DataSourceName == "first")
            {
              
                using (var connection = new SqlConnection(strConn))
                {
                    connection.Open();
                    const string sqlRegistersTendency = "select mmr.CreateDate ,mmr.[Hour] ,SUM(mmr.DataValue) DataValue from M_MemberRegister mmr WITH(NOLOCK) group by mmr.CreateDate,mmr.[Hour] order by mmr.CreateDate,mmr.[Hour]";

                    var result = connection.Query<RegistersTendencyEntity>(sqlRegistersTendency);
                    e.Data = result;
                }      
            }

            if (e.DataSourceName == "second")
            {
                using (var connection = new SqlConnection(strConn))
                {
                    connection.Open();
                    const string sqlRegistersIncrease = "select mmr.CreateDate ,mmr.[Hour] ,mmr.MemberLevel , mmr.DataValue  from M_MemberRegister mmr WITH(NOLOCK) order by mmr.CreateDate, mmr.[Hour]";
                    var result = connection.Query<RegistersIncreaseEntity>(sqlRegistersIncrease);
                    e.Data = result;
                }
            }
            if (e.DataSourceName == "third")
            {
                using (var connection = new SqlConnection(strConn))
                {
                    connection.Open();
                    const string sqlVNoHeadDistribution = "select TOP 10 M_VNoHead.VNoHead as VNoHead,SUM(M_VNoHead.DataValue) as DataValue  from M_VNoHead M_VNoHead group by M_VNoHead.VNoHead,M_VNoHead.DataValue order by SUM(M_VNoHead.DataValue)";
                    var result = connection.Query<VNoHeadDistributionEntity>(sqlVNoHeadDistribution);
                    e.Data = result;
                }
            }
            if (e.DataSourceName == "fourth")
            {
                using (var connection = new SqlConnection(strConn))
                {
                    connection.Open();
                    const string sqlVNoHeadTendency = "select  mvh.VNoHead  , SUM(mvh.DataValue) DataValue ,mvh.[Hour], mvh.CreateDate from M_VNoHead mvh WITH(NOLOCK) group by mvh.VNoHead, mvh.[Hour], mvh.CreateDate order by SUM(mvh.DataValue) desc";
                    var result = connection.Query<VNoHeadTendencyEntity>(sqlVNoHeadTendency);
                    e.Data = result;
                }
            }
        }
    }
}