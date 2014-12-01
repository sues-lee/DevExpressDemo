using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dapper;
using DevExpress.Web.ASPxEditors;
using DexTest.DataSets;
using Entitys.Dashboard;

namespace DexTest.UserControls
{
    public partial class CallBackDashBoard : System.Web.UI.UserControl
    {
        private const string CurrentKey = "currentValue";
        public string panelId;
        protected string panelName;
        public string CurrentValue                                       //客户端状态值
        {
            get
            {
                if (!ASPxHiddenField1.Contains(CurrentKey))
                    ASPxHiddenField1.Add(CurrentKey, InitValue);
                return (string)ASPxHiddenField1[CurrentKey];
            }
            set { ASPxHiddenField1[CurrentKey] = value; }
        }
        public Dictionary<string, string> DisplayList { get; set; }       //comboBox数据源 
        public DataTable DataSourse { get; set; }                         //dashBoard数据源
        public string Text { get; set; }                                  //说明字段
        public string InitValue { get; set; }                             //value的默认值
        public string DashBoardSource { get; set; }                       //dashboard文件路径
        public delegate void UserEvent(object sender, UserEventArgs e);   //
        public event UserEvent Fresh;                                     //当CallBack事件被触发时引发
        //TODO:
        public bool IsNeedComboBox { get; set; }                          //是否需要下拉框
        protected void Page_Load(object sender, EventArgs e)
        {
            panelId = ASPxCallbackPanel1.ClientID;
            ASPxCallbackPanel1.ClientInstanceName = ASPxCallbackPanel1.ClientID;
            if (DisplayList != null)
            {
                ASPxComboBox1.Items.Clear();
                foreach (var item in DisplayList)
                {
                    ASPxComboBox1.Items.Add(item.Key, item.Value);
                }
                ASPxComboBox1.SelectedIndex = 0;
            }
            
            ASPxDashboardViewer1.DashboardSource = DashBoardSource;     //绑定dashBoard数据源
        }

        public void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            CurrentValue = e.Parameter;
            //UserEventArgs args = new UserEventArgs() { Value = CurrentValue };
            //Fresh(sender, args);
            
        }

        protected void ASPxDashboardViewer1_DataLoading(object sender, DevExpress.DashboardWeb.DataLoadingWebEventArgs e)
        {
            if (Fresh == null)
            {
                return;
            }
            UserEventArgs args = new UserEventArgs(){Value = CurrentValue};
            Fresh(sender, args);
            e.Data = DataSourse;
        }
    }

    public class UserEventArgs : EventArgs
    {
        public string Value { get; set; }
    }

}