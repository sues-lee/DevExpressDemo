using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DexTest.UserControls
{
    public partial class ItemSelectorControl : System.Web.UI.UserControl
    {
        public string Text { get; set; }            //说明字符
        public string CallbackPanelId { get; set; }
        private const string currentValue = "currentValue";
        public int CurrentValue                     //客户端状态值
        {
            get
            {
                if (!ListBoxHiddenField.Contains(currentValue))
                    ListBoxHiddenField.Add(currentValue, 0);
                return (int)ListBoxHiddenField[currentValue];
            }
            set { ListBoxHiddenField[currentValue] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}