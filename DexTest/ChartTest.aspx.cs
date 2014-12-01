using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxCallbackPanel;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
using Series = DevExpress.Charts.Model.Series;

namespace DexTest
{
    public partial class ChartTest : System.Web.UI.Page
    {
        public string panelId;
        protected void Page_Load(object sender, EventArgs e)
        {
            panelId = ASPxCallbackPanel1.ClientID;
            //ASPxButton1.Attributes["onclick"] = "function(s, e) " +
            //                                                  "{"+panelId+".PerformCallBack(1);}";
            Button.Attributes["onclick"] = "function(s, e) " +
                                                              "{CallbackPanel.PerformCallback(-1);}";
        }

        protected void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            //WebChartControl wbc = new WebChartControl();

            //wbc.Series.Add("Series", ViewType.Line);
            //wbc.Series[0].ArgumentScaleType = ScaleType.DateTime;
            //wbc.Series[0].ValueScaleType = ScaleType.Numerical;

            //Random r = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    wbc.Series[0].Points.Add(new SeriesPoint(DateTime.Today.AddDays(i),
            //        ((int)((r.NextDouble() * 100) * 10)) / 10.0));
            //}

            //wbc.Width = ((ASPxCallbackPanel)sender).Width;
            //((ASPxCallbackPanel)sender).Controls.Add(wbc);
            MultiView01.ActiveViewIndex = Convert.ToInt32(e.Parameter);  
        }
    }
}