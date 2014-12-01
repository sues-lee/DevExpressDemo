using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxCallback;
using DevExpress.Web.ASPxEditors;

namespace DexTest.UserControls
{
    public partial class SelectorControl : System.Web.UI.UserControl
    {
        public string Text { get; set; }                             //说明字符
        public string CallbackPanelId { get; set; }
        public Dictionary<string, int> DisplayList { get; set; }     //数据源 
        public CallBackDashBoard CallBack { get; set; }
        protected string str;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ASPxComboBox1.Items.Count == 0)
            {
                ListEditItem list = new ListEditItem();
                foreach (var item in DisplayList)
                {
                    ASPxComboBox1.Items.Add(item.Key, item.Value);
                }
            }
            str = "function(s, e) { var item = ASPxComboBox1.GetSelectedItem(); " + CallbackPanelId + ".PerformCallback(item.value)}";  

        }

        protected void SelectedIndexChanged(object sender, EventArgs e)
        {
            //var args = new CallbackEventArgs(ASPxComboBox1.SelectedIndex.ToString());
            //CallBack.ASPxCallbackPanel1_Callback(this, args);
            
        }

    }
}