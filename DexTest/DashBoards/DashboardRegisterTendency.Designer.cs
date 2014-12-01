namespace DexTest.DashBoards
{
    partial class DashboardRegisterTendency
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardRegisterTendency));
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dataSource2 = new DevExpress.DashboardCommon.DataSource();
            this.dsRegister1 = new DexTest.DataSets.dsRegister();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegister1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // chartDashboardItem1
            // 
            dimension1.DataMember = "CreateDate";
            dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
            dimension2.DataMember = "Hour";
            this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1,
            dimension2});
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            measure1.DataMember = "DataValue";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.chartDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem2");
            this.chartDashboardItem1.DataSource = this.dataSource2;
            this.chartDashboardItem1.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "Chart 1";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure1);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.ShowCaption = false;
            // 
            // dataSource2
            // 
            this.dataSource2.ComponentName = "dataSource2";
            this.dataSource2.Data = null;
            this.dataSource2.DataMember = "RegistersTendency";
            this.dataSource2.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client;
            this.dataSource2.DataSchema = resources.GetString("dataSource2.DataSchema");
            this.dataSource2.Name = "Data Source 1";
            // 
            // dsRegister1
            // 
            this.dsRegister1.DataSetName = "dsRegister";
            this.dsRegister1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DashboardRegisterTendency
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {
            this.dataSource2});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem1.Weight = 100D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1});
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            this.Title.Visible = false;
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRegister1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
        private DevExpress.DashboardCommon.DataSource dataSource2;
        private DataSets.dsRegister dsRegister1;
    }
}
