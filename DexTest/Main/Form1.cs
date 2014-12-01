using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using Entitys.Dashboard;
using System.Configuration;
using Dapper;

namespace Main
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string sqlTendency = "select mmr.CreateDate ,mmr.[Hour] ,SUM(mmr.DataValue) DataValue from M_MemberRegister mmr WITH(NOLOCK) group by mmr.CreateDate,mmr.[Hour] order by mmr.CreateDate,mmr.[Hour]";
        

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistersTendencyEntity registers = new RegistersTendencyEntity();
            const string str = "Data Source=10.1.249.63;User ID=sa;Password=htinns!2013;Initial Catalog=DMP;Pooling=true;MultipleActiveResultSets=true;Connection Timeout=30;min pool size=30;max pool size=60";



            using (var connection = new SqlConnection(str))
            {
                connection.Open();

                var dataRegistersTendency = connection.Query<RegistersTendencyEntity>(sqlTendency);
                var dataRegistersIncrease = new RegistersIncreaseEntity();
                var dataVNoHeadDistribution = new VNoHeadDistributionEntity();
                var dataVNoHeadTendency = new VNoHeadTendencyEntity();
                
                this.dashboardDesigner1.Dashboard.AddDataSource("first",dataRegistersTendency);
                this.dashboardDesigner1.Dashboard.AddDataSource("second",dataRegistersIncrease);
                this.dashboardDesigner1.Dashboard.AddDataSource("third",dataVNoHeadDistribution);
                this.dashboardDesigner1.Dashboard.AddDataSource("fourth",dataVNoHeadTendency);
            }

            
        }
    }
}
