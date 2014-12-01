namespace DexTest.DashBoards
{
    partial class DashboardRegister
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
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.ChartPane chartPane2 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension8 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension9 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane3 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries3 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dataSource1 = new DevExpress.DashboardCommon.DataSource();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            this.dataSource3 = new DevExpress.DashboardCommon.DataSource();
            this.chartDashboardItem2 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dataSource2 = new DevExpress.DashboardCommon.DataSource();
            this.chartDashboardItem3 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dataSource4 = new DevExpress.DashboardCommon.DataSource();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource4)).BeginInit();
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
            measure1.Name = "注册数";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem2");
            this.chartDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
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
            this.chartDashboardItem1.ShowCaption = true;
            // 
            // dataSource1
            // 
            this.dataSource1.ComponentName = "dataSource1";
            this.dataSource1.Data = null;
            this.dataSource1.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client;
            this.dataSource1.Name = "first";
            // 
            // pieDashboardItem1
            // 
            dimension3.DataMember = "VNoHead";
            this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            measure2.DataMember = "DataValue";
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.DataItemRepository.Add(dimension3, "DataItem0");
            this.pieDashboardItem1.DataItemRepository.Add(measure2, "DataItem1");
            this.pieDashboardItem1.IgnoreMasterFilters = false;
            this.pieDashboardItem1.Name = "Pies 1";
            this.pieDashboardItem1.ShowCaption = true;
            this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure2});
            // 
            // dataSource3
            // 
            this.dataSource3.ComponentName = "dataSource3";
            this.dataSource3.Data = null;
            this.dataSource3.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client;
            this.dataSource3.Name = "third";
            // 
            // chartDashboardItem2
            // 
            dimension4.DataMember = "CreateDate";
            dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
            dimension5.DataMember = "Hour";
            this.chartDashboardItem2.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4,
            dimension5});
            this.chartDashboardItem2.AxisX.TitleVisible = false;
            this.chartDashboardItem2.ComponentName = "chartDashboardItem2";
            measure3.DataMember = "DataValue";
            measure3.Name = "注册数";
            dimension6.DataMember = "MemberLevel";
            dimension6.Name = "会员等级";
            this.chartDashboardItem2.DataItemRepository.Clear();
            this.chartDashboardItem2.DataItemRepository.Add(measure3, "DataItem0");
            this.chartDashboardItem2.DataItemRepository.Add(dimension5, "DataItem1");
            this.chartDashboardItem2.DataItemRepository.Add(dimension4, "DataItem2");
            this.chartDashboardItem2.DataItemRepository.Add(dimension6, "DataItem3");
            this.chartDashboardItem2.IgnoreMasterFilters = false;
            this.chartDashboardItem2.Name = "Chart 2";
            chartPane2.Name = "Pane 1";
            chartPane2.PrimaryAxisY.ShowGridLines = true;
            chartPane2.PrimaryAxisY.TitleVisible = true;
            chartPane2.SecondaryAxisY.ShowGridLines = false;
            chartPane2.SecondaryAxisY.TitleVisible = true;
            simpleSeries2.AddDataItem("Value", measure3);
            chartPane2.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries2});
            this.chartDashboardItem2.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane2});
            this.chartDashboardItem2.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension6});
            this.chartDashboardItem2.ShowCaption = true;
            // 
            // dataSource2
            // 
            this.dataSource2.ComponentName = "dataSource2";
            this.dataSource2.Data = null;
            this.dataSource2.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client;
            this.dataSource2.Name = "second";
            // 
            // chartDashboardItem3
            // 
            dimension7.DataMember = "CreateDate";
            dimension7.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
            dimension8.DataMember = "Hour";
            this.chartDashboardItem3.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension7,
            dimension8});
            this.chartDashboardItem3.AxisX.TitleVisible = false;
            this.chartDashboardItem3.ComponentName = "chartDashboardItem3";
            dimension9.DataMember = "VNoHead";
            measure4.DataMember = "DataValue";
            this.chartDashboardItem3.DataItemRepository.Clear();
            this.chartDashboardItem3.DataItemRepository.Add(dimension9, "DataItem0");
            this.chartDashboardItem3.DataItemRepository.Add(dimension8, "DataItem1");
            this.chartDashboardItem3.DataItemRepository.Add(measure4, "DataItem2");
            this.chartDashboardItem3.DataItemRepository.Add(dimension7, "DataItem3");
            this.chartDashboardItem3.IgnoreMasterFilters = false;
            this.chartDashboardItem3.Name = "Chart 3";
            chartPane3.Name = "Pane 1";
            chartPane3.PrimaryAxisY.ShowGridLines = true;
            chartPane3.PrimaryAxisY.TitleVisible = true;
            chartPane3.SecondaryAxisY.ShowGridLines = false;
            chartPane3.SecondaryAxisY.TitleVisible = true;
            simpleSeries3.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries3.AddDataItem("Value", measure4);
            chartPane3.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries3});
            this.chartDashboardItem3.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane3});
            this.chartDashboardItem3.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension9});
            this.chartDashboardItem3.ShowCaption = true;
            // 
            // dataSource4
            // 
            this.dataSource4.ComponentName = "dataSource4";
            this.dataSource4.Data = null;
            this.dataSource4.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client;
            this.dataSource4.Name = "fourth";
            // 
            // DashboardRegister
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {
            this.dataSource1,
            this.dataSource2,
            this.dataSource3,
            this.dataSource4});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartDashboardItem1,
            this.chartDashboardItem2,
            this.pieDashboardItem1,
            this.chartDashboardItem3});
            dashboardLayoutItem1.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem1.Weight = 0.5D;
            dashboardLayoutItem2.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem2.Weight = 0.5D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 0.5D;
            dashboardLayoutItem3.DashboardItem = this.chartDashboardItem2;
            dashboardLayoutItem3.Weight = 0.5D;
            dashboardLayoutItem4.DashboardItem = this.chartDashboardItem3;
            dashboardLayoutItem4.Weight = 0.5D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem3,
            dashboardLayoutItem4});
            dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup3.Weight = 0.5D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutGroup3});
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            this.DashboardLoading += new System.EventHandler(this.DashboardRegister_DashboardLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
        private DevExpress.DashboardCommon.DataSource dataSource1;
        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem2;
        private DevExpress.DashboardCommon.DataSource dataSource2;
        private DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
        private DevExpress.DashboardCommon.DataSource dataSource3;
        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem3;
        private DevExpress.DashboardCommon.DataSource dataSource4;










    }
}
