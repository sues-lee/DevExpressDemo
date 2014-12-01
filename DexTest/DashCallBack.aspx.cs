using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dapper;
using DevExpress.DataAccess.Native.DB;
using DexTest.DataSets;
using Entitys.Dashboard;

namespace DexTest
{
    public partial class DashCallBack : System.Web.UI.Page
    {
        const string StrConn = "Data Source=10.1.249.63;User ID=sa;Password=htinns!2013;Initial Catalog=DMP;Pooling=true;MultipleActiveResultSets=true;Connection Timeout=30;min pool size=30;max pool size=60";
        private const string TendencyHour = "TendencyHour";
        private const string IncreaseHour = "IncreaseHour";
        public int tendencyHour         //注册趋势图-时间范围
        {
            get
            {
                if (!ListBoxHiddenField.Contains(TendencyHour))
                    ListBoxHiddenField.Add(TendencyHour, -48);
                return (int)ListBoxHiddenField[TendencyHour];
            }
            set { ListBoxHiddenField[TendencyHour] = value; }
        }
        public int increaseHour         //注册增长图-时间范围
        {
            get
            {
                if (!ListBoxHiddenField.Contains(IncreaseHour))
                    ListBoxHiddenField.Add(IncreaseHour, -48);
                return (int)ListBoxHiddenField[IncreaseHour];
            }
            set { ListBoxHiddenField[IncreaseHour] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {

            //MultiView01.ActiveViewIndex = Convert.ToInt32(e.Parameter);
            SetTendencyDate(Convert.ToInt32(e.Parameter));
        }
        protected void ASPxDashboardViewer1_DataLoading(object sender, DevExpress.DashboardWeb.DataLoadingWebEventArgs e)
        {
            using (var connection = new SqlConnection(StrConn))
            {
                var  registersTendency = new dsRegister.RegistersTendencyDataTable();
                connection.Open();
                string sqlRegistersTendency =String.Format("select mmr.CreateDate ,mmr.[Hour] ,SUM(mmr.DataValue) DataValue " +
                                                                 "from M_MemberRegister mmr WITH(NOLOCK) " +
                                                                 "where mmr.ModifyTime >DATEADD(hour, {0}, GETDATE()) " +
                                                                 "group by mmr.CreateDate,mmr.[Hour] order by mmr.CreateDate,mmr.[Hour]",
                                                                 tendencyHour);
                var result = connection.Query<RegistersTendencyEntity>(sqlRegistersTendency);
                foreach (var item in result)
                {
                    registersTendency.AddRegistersTendencyRow(item.CreateDate, item.Hour, item.DataValue);
                }

                e.Data = registersTendency;
            }   
        }

        void SetTendencyDate(int i)
        {
            if (i == 0)
            {
                tendencyHour = -24;
            }else if (i == 1)
            {
                tendencyHour = -48;
            }
        }
    }
}