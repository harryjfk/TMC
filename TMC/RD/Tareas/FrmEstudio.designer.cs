using TMC.Components.TemperatureControl;
using TMC.RD.DSRDTableAdapters;
using TMC.RD;
namespace TMC.RD.Tareas
{
    partial class FrmEstudio
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint(11D, new object[] {
            ((object)(11D))});
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.StackedArea3DSeriesLabel stackedArea3DSeriesLabel1 = new DevExpress.XtraCharts.StackedArea3DSeriesLabel();
            DevExpress.XtraCharts.StackedArea3DSeriesView stackedArea3DSeriesView1 = new DevExpress.XtraCharts.StackedArea3DSeriesView();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn chartControlCommandGalleryItemGroup2DColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn();
            DevExpress.XtraCharts.UI.CreateBarChartItem createBarChartItem1 = new DevExpress.XtraCharts.UI.CreateBarChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem createFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem createSideBySideFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem createSideBySideStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBarChartItem createStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn chartControlCommandGalleryItemGroup3DColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn();
            DevExpress.XtraCharts.UI.CreateBar3DChartItem createBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem createFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateManhattanBarChartItem createManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreateManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem createSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem createSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem createStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn chartControlCommandGalleryItemGroupCylinderColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn();
            DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem createCylinderBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem createCylinderFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem createCylinderManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem createCylinderSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem createCylinderSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem createCylinderStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn chartControlCommandGalleryItemGroupConeColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn();
            DevExpress.XtraCharts.UI.CreateConeBar3DChartItem createConeBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem createConeFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem createConeManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem createConeSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem createConeSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem createConeStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn chartControlCommandGalleryItemGroupPyramidColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn();
            DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem createPyramidBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem createPyramidFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem createPyramidManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem createPyramidSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem createPyramidSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem createPyramidStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine chartControlCommandGalleryItemGroup2DLine1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine();
            DevExpress.XtraCharts.UI.CreateLineChartItem createLineChartItem1 = new DevExpress.XtraCharts.UI.CreateLineChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem createFullStackedLineChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateScatterLineChartItem createScatterLineChartItem1 = new DevExpress.XtraCharts.UI.CreateScatterLineChartItem();
            DevExpress.XtraCharts.UI.CreateSplineChartItem createSplineChartItem1 = new DevExpress.XtraCharts.UI.CreateSplineChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLineChartItem createStackedLineChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateStepLineChartItem createStepLineChartItem1 = new DevExpress.XtraCharts.UI.CreateStepLineChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine chartControlCommandGalleryItemGroup3DLine1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine();
            DevExpress.XtraCharts.UI.CreateLine3DChartItem createLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem createFullStackedLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateSpline3DChartItem createSpline3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSpline3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem createStackedLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepLine3DChartItem createStepLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStepLine3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie chartControlCommandGalleryItemGroup2DPie1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie();
            DevExpress.XtraCharts.UI.CreatePieChartItem createPieChartItem1 = new DevExpress.XtraCharts.UI.CreatePieChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnutChartItem createDoughnutChartItem1 = new DevExpress.XtraCharts.UI.CreateDoughnutChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie chartControlCommandGalleryItemGroup3DPie1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie();
            DevExpress.XtraCharts.UI.CreatePie3DChartItem createPie3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePie3DChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem createDoughnut3DChartItem1 = new DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar chartControlCommandGalleryItemGroup2DBar1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar();
            DevExpress.XtraCharts.UI.CreateRotatedBarChartItem createRotatedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem createRotatedFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem createRotatedSideBySideFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem createRotatedSideBySideStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem createRotatedStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea chartControlCommandGalleryItemGroup2DArea1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea();
            DevExpress.XtraCharts.UI.CreateAreaChartItem createAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem createFullStackedAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem createFullStackedSplineAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateSplineAreaChartItem createSplineAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedAreaChartItem createStackedAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem createStackedSplineAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStepAreaChartItem createStepAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateStepAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea chartControlCommandGalleryItemGroup3DArea1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea();
            DevExpress.XtraCharts.UI.CreateArea3DChartItem createArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem createFullStackedArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem createFullStackedSplineArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem createSplineArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem createStackedArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem createStackedSplineArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepArea3DChartItem createStepArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStepArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint chartControlCommandGalleryItemGroupPoint1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint();
            DevExpress.XtraCharts.UI.CreatePointChartItem createPointChartItem1 = new DevExpress.XtraCharts.UI.CreatePointChartItem();
            DevExpress.XtraCharts.UI.CreateBubbleChartItem createBubbleChartItem1 = new DevExpress.XtraCharts.UI.CreateBubbleChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel chartControlCommandGalleryItemGroupFunnel1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel();
            DevExpress.XtraCharts.UI.CreateFunnelChartItem createFunnelChartItem1 = new DevExpress.XtraCharts.UI.CreateFunnelChartItem();
            DevExpress.XtraCharts.UI.CreateFunnel3DChartItem createFunnel3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFunnel3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial chartControlCommandGalleryItemGroupFinancial1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial();
            DevExpress.XtraCharts.UI.CreateStockChartItem createStockChartItem1 = new DevExpress.XtraCharts.UI.CreateStockChartItem();
            DevExpress.XtraCharts.UI.CreateCandleStickChartItem createCandleStickChartItem1 = new DevExpress.XtraCharts.UI.CreateCandleStickChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar chartControlCommandGalleryItemGroupRadar1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar();
            DevExpress.XtraCharts.UI.CreateRadarPointChartItem createRadarPointChartItem1 = new DevExpress.XtraCharts.UI.CreateRadarPointChartItem();
            DevExpress.XtraCharts.UI.CreateRadarLineChartItem createRadarLineChartItem1 = new DevExpress.XtraCharts.UI.CreateRadarLineChartItem();
            DevExpress.XtraCharts.UI.CreateRadarAreaChartItem createRadarAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateRadarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar chartControlCommandGalleryItemGroupPolar1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar();
            DevExpress.XtraCharts.UI.CreatePolarPointChartItem createPolarPointChartItem1 = new DevExpress.XtraCharts.UI.CreatePolarPointChartItem();
            DevExpress.XtraCharts.UI.CreatePolarLineChartItem createPolarLineChartItem1 = new DevExpress.XtraCharts.UI.CreatePolarLineChartItem();
            DevExpress.XtraCharts.UI.CreatePolarAreaChartItem createPolarAreaChartItem1 = new DevExpress.XtraCharts.UI.CreatePolarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange chartControlCommandGalleryItemGroupRange1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange();
            DevExpress.XtraCharts.UI.CreateRangeBarChartItem createRangeBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem createSideBySideRangeBarChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateRangeAreaChartItem createRangeAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateRangeAreaChartItem();
            DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem createRangeArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt chartControlCommandGalleryItemGroupGantt1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt();
            DevExpress.XtraCharts.UI.CreateGanttChartItem createGanttChartItem1 = new DevExpress.XtraCharts.UI.CreateGanttChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem createSideBySideGanttChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges2 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel4 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel5 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel6 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn chartControlCommandGalleryItemGroup2DColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn();
            DevExpress.XtraCharts.UI.CreateBarChartItem createBarChartItem2 = new DevExpress.XtraCharts.UI.CreateBarChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem createFullStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem createSideBySideFullStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem createSideBySideStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBarChartItem createStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn chartControlCommandGalleryItemGroup3DColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn();
            DevExpress.XtraCharts.UI.CreateBar3DChartItem createBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem createFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateManhattanBarChartItem createManhattanBarChartItem2 = new DevExpress.XtraCharts.UI.CreateManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem createSideBySideFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem createSideBySideStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem createStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn chartControlCommandGalleryItemGroupCylinderColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn();
            DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem createCylinderBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem createCylinderFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem createCylinderManhattanBarChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem createCylinderSideBySideFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem createCylinderSideBySideStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem createCylinderStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn chartControlCommandGalleryItemGroupConeColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn();
            DevExpress.XtraCharts.UI.CreateConeBar3DChartItem createConeBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem createConeFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem createConeManhattanBarChartItem2 = new DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem createConeSideBySideFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem createConeSideBySideStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem createConeStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn chartControlCommandGalleryItemGroupPyramidColumn2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn();
            DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem createPyramidBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem createPyramidFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem createPyramidManhattanBarChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem createPyramidSideBySideFullStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem createPyramidSideBySideStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem createPyramidStackedBar3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine chartControlCommandGalleryItemGroup2DLine2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine();
            DevExpress.XtraCharts.UI.CreateLineChartItem createLineChartItem2 = new DevExpress.XtraCharts.UI.CreateLineChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem createFullStackedLineChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateScatterLineChartItem createScatterLineChartItem2 = new DevExpress.XtraCharts.UI.CreateScatterLineChartItem();
            DevExpress.XtraCharts.UI.CreateSplineChartItem createSplineChartItem2 = new DevExpress.XtraCharts.UI.CreateSplineChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLineChartItem createStackedLineChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateStepLineChartItem createStepLineChartItem2 = new DevExpress.XtraCharts.UI.CreateStepLineChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine chartControlCommandGalleryItemGroup3DLine2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine();
            DevExpress.XtraCharts.UI.CreateLine3DChartItem createLine3DChartItem2 = new DevExpress.XtraCharts.UI.CreateLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem createFullStackedLine3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateSpline3DChartItem createSpline3DChartItem2 = new DevExpress.XtraCharts.UI.CreateSpline3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem createStackedLine3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepLine3DChartItem createStepLine3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStepLine3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie chartControlCommandGalleryItemGroup2DPie2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie();
            DevExpress.XtraCharts.UI.CreatePieChartItem createPieChartItem2 = new DevExpress.XtraCharts.UI.CreatePieChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnutChartItem createDoughnutChartItem2 = new DevExpress.XtraCharts.UI.CreateDoughnutChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie chartControlCommandGalleryItemGroup3DPie2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie();
            DevExpress.XtraCharts.UI.CreatePie3DChartItem createPie3DChartItem2 = new DevExpress.XtraCharts.UI.CreatePie3DChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem createDoughnut3DChartItem2 = new DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar chartControlCommandGalleryItemGroup2DBar2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar();
            DevExpress.XtraCharts.UI.CreateRotatedBarChartItem createRotatedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem createRotatedFullStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem createRotatedSideBySideFullStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem createRotatedSideBySideStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem createRotatedStackedBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea chartControlCommandGalleryItemGroup2DArea2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea();
            DevExpress.XtraCharts.UI.CreateAreaChartItem createAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem createFullStackedAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem createFullStackedSplineAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateSplineAreaChartItem createSplineAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedAreaChartItem createStackedAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem createStackedSplineAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStepAreaChartItem createStepAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateStepAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea chartControlCommandGalleryItemGroup3DArea2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea();
            DevExpress.XtraCharts.UI.CreateArea3DChartItem createArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem createFullStackedArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem createFullStackedSplineArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem createSplineArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem createStackedArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem createStackedSplineArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepArea3DChartItem createStepArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateStepArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint chartControlCommandGalleryItemGroupPoint2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint();
            DevExpress.XtraCharts.UI.CreatePointChartItem createPointChartItem2 = new DevExpress.XtraCharts.UI.CreatePointChartItem();
            DevExpress.XtraCharts.UI.CreateBubbleChartItem createBubbleChartItem2 = new DevExpress.XtraCharts.UI.CreateBubbleChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel chartControlCommandGalleryItemGroupFunnel2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel();
            DevExpress.XtraCharts.UI.CreateFunnelChartItem createFunnelChartItem2 = new DevExpress.XtraCharts.UI.CreateFunnelChartItem();
            DevExpress.XtraCharts.UI.CreateFunnel3DChartItem createFunnel3DChartItem2 = new DevExpress.XtraCharts.UI.CreateFunnel3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial chartControlCommandGalleryItemGroupFinancial2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial();
            DevExpress.XtraCharts.UI.CreateStockChartItem createStockChartItem2 = new DevExpress.XtraCharts.UI.CreateStockChartItem();
            DevExpress.XtraCharts.UI.CreateCandleStickChartItem createCandleStickChartItem2 = new DevExpress.XtraCharts.UI.CreateCandleStickChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar chartControlCommandGalleryItemGroupRadar2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar();
            DevExpress.XtraCharts.UI.CreateRadarPointChartItem createRadarPointChartItem2 = new DevExpress.XtraCharts.UI.CreateRadarPointChartItem();
            DevExpress.XtraCharts.UI.CreateRadarLineChartItem createRadarLineChartItem2 = new DevExpress.XtraCharts.UI.CreateRadarLineChartItem();
            DevExpress.XtraCharts.UI.CreateRadarAreaChartItem createRadarAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateRadarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar chartControlCommandGalleryItemGroupPolar2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar();
            DevExpress.XtraCharts.UI.CreatePolarPointChartItem createPolarPointChartItem2 = new DevExpress.XtraCharts.UI.CreatePolarPointChartItem();
            DevExpress.XtraCharts.UI.CreatePolarLineChartItem createPolarLineChartItem2 = new DevExpress.XtraCharts.UI.CreatePolarLineChartItem();
            DevExpress.XtraCharts.UI.CreatePolarAreaChartItem createPolarAreaChartItem2 = new DevExpress.XtraCharts.UI.CreatePolarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange chartControlCommandGalleryItemGroupRange2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange();
            DevExpress.XtraCharts.UI.CreateRangeBarChartItem createRangeBarChartItem2 = new DevExpress.XtraCharts.UI.CreateRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem createSideBySideRangeBarChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateRangeAreaChartItem createRangeAreaChartItem2 = new DevExpress.XtraCharts.UI.CreateRangeAreaChartItem();
            DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem createRangeArea3DChartItem2 = new DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt chartControlCommandGalleryItemGroupGantt2 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt();
            DevExpress.XtraCharts.UI.CreateGanttChartItem createGanttChartItem2 = new DevExpress.XtraCharts.UI.CreateGanttChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem createSideBySideGanttChartItem2 = new DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem1 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudio));
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem2 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem3 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem4 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem5 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem6 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem7 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem8 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem9 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem10 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem11 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem12 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem13 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem14 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem15 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem16 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem17 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem18 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem19 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem20 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem21 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem22 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem23 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem24 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem25 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem26 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem27 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem28 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem29 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            DevExpress.XtraCharts.UI.ChangePaletteGalleryItem changePaletteGalleryItem30 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ucCompleteProperty1 = new TMC.Components.TemperatureControl.UCCompleteProperty();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.t_DegradeeTableAdapter1 = new TMC.RD.DSRDTableAdapters.T_DegradeeTableAdapter();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.chartTypeBar1 = new DevExpress.XtraCharts.UI.ChartTypeBar();
            this.createBarBaseItem1 = new DevExpress.XtraCharts.UI.CreateBarBaseItem();
            this.galleryDropDown8 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.createLineBaseItem1 = new DevExpress.XtraCharts.UI.CreateLineBaseItem();
            this.galleryDropDown9 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.createPieBaseItem1 = new DevExpress.XtraCharts.UI.CreatePieBaseItem();
            this.galleryDropDown10 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.createRotatedBarBaseItem1 = new DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem();
            this.galleryDropDown11 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.createAreaBaseItem1 = new DevExpress.XtraCharts.UI.CreateAreaBaseItem();
            this.galleryDropDown12 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.createOtherSeriesTypesBaseItem1 = new DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem();
            this.galleryDropDown13 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.chartAppearanceBar1 = new DevExpress.XtraCharts.UI.ChartAppearanceBar();
            this.changePaletteGalleryBaseItem1 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem();
            this.galleryDropDown14 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.changeAppearanceGalleryBaseBarManagerItem1 = new DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseBarManagerItem();
            this.galleryDropDown15 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.chartWizardBar1 = new DevExpress.XtraCharts.UI.ChartWizardBar();
            this.runWizardChartItem1 = new DevExpress.XtraCharts.UI.RunWizardChartItem();
            this.chartTemplatesBar1 = new DevExpress.XtraCharts.UI.ChartTemplatesBar();
            this.saveAsTemplateChartItem1 = new DevExpress.XtraCharts.UI.SaveAsTemplateChartItem();
            this.loadTemplateChartItem1 = new DevExpress.XtraCharts.UI.LoadTemplateChartItem();
            this.chartPrintExportBar1 = new DevExpress.XtraCharts.UI.ChartPrintExportBar();
            this.printPreviewChartItem1 = new DevExpress.XtraCharts.UI.PrintPreviewChartItem();
            this.printChartItem1 = new DevExpress.XtraCharts.UI.PrintChartItem();
            this.createExportBaseItem1 = new DevExpress.XtraCharts.UI.CreateExportBaseItem();
            this.exportToPDFChartItem1 = new DevExpress.XtraCharts.UI.ExportToPDFChartItem();
            this.exportToHTMLChartItem1 = new DevExpress.XtraCharts.UI.ExportToHTMLChartItem();
            this.exportToMHTChartItem1 = new DevExpress.XtraCharts.UI.ExportToMHTChartItem();
            this.exportToXLSChartItem1 = new DevExpress.XtraCharts.UI.ExportToXLSChartItem();
            this.exportToXLSXChartItem1 = new DevExpress.XtraCharts.UI.ExportToXLSXChartItem();
            this.exportToRTFChartItem1 = new DevExpress.XtraCharts.UI.ExportToRTFChartItem();
            this.createExportToImageBaseItem1 = new DevExpress.XtraCharts.UI.CreateExportToImageBaseItem();
            this.exportToBMPChartItem1 = new DevExpress.XtraCharts.UI.ExportToBMPChartItem();
            this.exportToGIFChartItem1 = new DevExpress.XtraCharts.UI.ExportToGIFChartItem();
            this.exportToJPEGChartItem1 = new DevExpress.XtraCharts.UI.ExportToJPEGChartItem();
            this.exportToPNGChartItem1 = new DevExpress.XtraCharts.UI.ExportToPNGChartItem();
            this.exportToTIFFChartItem1 = new DevExpress.XtraCharts.UI.ExportToTIFFChartItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new TMC.RD.DSRD();
            this.t_ProjectTableAdapter = new TMC.RD.DSRDTableAdapters.T_ProjectTableAdapter();
            this.t_Tipo_ParedTableAdapter1 = new TMC.RD.DSRDTableAdapters.T_Tipo_ParedTableAdapter();
            this.chartBarController1 = new DevExpress.XtraCharts.UI.ChartBarController();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.galleryDropDown2 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.galleryDropDown3 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.galleryDropDown4 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.galleryDropDown5 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.galleryDropDown6 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.galleryDropDown7 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedArea3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedArea3DSeriesView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(810, 488);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.layoutControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(804, 460);
            this.xtraTabPage1.Text = "Area de diseño";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.treeList1);
            this.layoutControl1.Controls.Add(this.ucCompleteProperty1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(685, 308, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(804, 460);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8});
            this.treeList1.Location = new System.Drawing.Point(12, 399);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.ImmediateEditor = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowRoot = false;
            this.treeList1.Size = new System.Drawing.Size(780, 49);
            this.treeList1.TabIndex = 5;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Material";
            this.treeListColumn1.FieldName = "Material";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Espesor(mm)";
            this.treeListColumn2.FieldName = "Espesor";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Cond.(W/m² °C)";
            this.treeListColumn3.FieldName = "treeListColumn3";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Temp. Media (°C)";
            this.treeListColumn4.FieldName = "treeListColumn4";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Estres(MPa)";
            this.treeListColumn5.FieldName = "Estres(MPa)";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 4;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Costo(UM)";
            this.treeListColumn6.FieldName = "Costo(UM)";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 5;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Peso(Kg)";
            this.treeListColumn7.FieldName = "Peso(Kg)";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 6;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "Vol.(m^3)";
            this.treeListColumn8.FieldName = "Vol.(m^3)";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 7;
            // 
            // ucCompleteProperty1
            // 
            this.ucCompleteProperty1.AllowDrop = true;
            this.ucCompleteProperty1.Location = new System.Drawing.Point(12, 12);
            this.ucCompleteProperty1.Name = "ucCompleteProperty1";
            this.ucCompleteProperty1.Size = new System.Drawing.Size(780, 357);
            this.ucCompleteProperty1.TabIndex = 0;
            this.ucCompleteProperty1.TempAmbiente = 0D;
            this.ucCompleteProperty1.TempInterna = 1250D;
            this.ucCompleteProperty1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ucCompleteProperty1_DragDrop);
            this.ucCompleteProperty1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ucCompleteProperty1_DragEnter);
            this.ucCompleteProperty1.DragOver += new System.Windows.Forms.DragEventHandler(this.ucCompleteProperty1_DragOver);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem14});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(804, 460);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ucCompleteProperty1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(784, 361);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.treeList1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 387);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(784, 53);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.chartControl1);
            this.xtraTabPage2.Controls.Add(this.standaloneBarDockControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(804, 460);
            this.xtraTabPage2.Text = "Gradiente térmico";
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.t_DegradeeTableAdapter1;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 66);
            this.chartControl1.Name = "chartControl1";
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1});
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.Label = stackedArea3DSeriesLabel1;
            stackedArea3DSeriesView1.Transparency = ((byte)(0));
            this.chartControl1.SeriesTemplate.View = stackedArea3DSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(804, 394);
            this.chartControl1.TabIndex = 0;
            // 
            // t_DegradeeTableAdapter1
            // 
            this.t_DegradeeTableAdapter1.ClearBeforeFill = true;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(804, 66);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.layoutControl2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.PageVisible = false;
            this.xtraTabPage3.Size = new System.Drawing.Size(804, 460);
            this.xtraTabPage3.Text = "Régimen transitorio";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.treeList2);
            this.layoutControl2.Controls.Add(this.simpleButton2);
            this.layoutControl2.Controls.Add(this.simpleButton1);
            this.layoutControl2.Controls.Add(this.textEdit5);
            this.layoutControl2.Controls.Add(this.textEdit4);
            this.layoutControl2.Controls.Add(this.textEdit3);
            this.layoutControl2.Controls.Add(this.textEdit2);
            this.layoutControl2.Controls.Add(this.xtraTabControl2);
            this.layoutControl2.Controls.Add(this.textEdit1);
            this.layoutControl2.Controls.Add(this.comboBoxEdit1);
            this.layoutControl2.Controls.Add(this.comboBoxEdit2);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(804, 460);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // treeList2
            // 
            this.treeList2.Location = new System.Drawing.Point(24, 312);
            this.treeList2.Name = "treeList2";
            this.treeList2.Size = new System.Drawing.Size(275, 124);
            this.treeList2.TabIndex = 14;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(163, 243);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(136, 22);
            this.simpleButton2.StyleController = this.layoutControl2;
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Calcular";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(24, 243);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 22);
            this.simpleButton1.StyleController = this.layoutControl2;
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Temperaturas iniciales";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(198, 219);
            this.textEdit5.MenuManager = this.barManager1;
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(101, 20);
            this.textEdit5.StyleController = this.layoutControl2;
            this.textEdit5.TabIndex = 11;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.chartTypeBar1,
            this.chartAppearanceBar1,
            this.chartWizardBar1,
            this.chartTemplatesBar1,
            this.chartPrintExportBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.createBarBaseItem1,
            this.createLineBaseItem1,
            this.createPieBaseItem1,
            this.createRotatedBarBaseItem1,
            this.createAreaBaseItem1,
            this.createOtherSeriesTypesBaseItem1,
            this.changePaletteGalleryBaseItem1,
            this.changeAppearanceGalleryBaseBarManagerItem1,
            this.runWizardChartItem1,
            this.saveAsTemplateChartItem1,
            this.loadTemplateChartItem1,
            this.printPreviewChartItem1,
            this.printChartItem1,
            this.createExportBaseItem1,
            this.exportToPDFChartItem1,
            this.exportToHTMLChartItem1,
            this.exportToMHTChartItem1,
            this.exportToXLSChartItem1,
            this.exportToXLSXChartItem1,
            this.exportToRTFChartItem1,
            this.exportToBMPChartItem1,
            this.exportToGIFChartItem1,
            this.exportToJPEGChartItem1,
            this.exportToPNGChartItem1,
            this.exportToTIFFChartItem1,
            this.createExportToImageBaseItem1});
            this.barManager1.MaxItemId = 30;
            // 
            // chartTypeBar1
            // 
            this.chartTypeBar1.DockCol = 0;
            this.chartTypeBar1.DockRow = 0;
            this.chartTypeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.chartTypeBar1.FloatLocation = new System.Drawing.Point(257, 276);
            this.chartTypeBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.createBarBaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.createLineBaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.createPieBaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.createRotatedBarBaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.createAreaBaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.createOtherSeriesTypesBaseItem1)});
            this.chartTypeBar1.Offset = 4;
            this.chartTypeBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // createBarBaseItem1
            // 
            this.createBarBaseItem1.DropDownControl = this.galleryDropDown8;
            this.createBarBaseItem1.Id = 25;
            this.createBarBaseItem1.Name = "createBarBaseItem1";
            // 
            // galleryDropDown8
            // 
            // 
            // 
            // 
            this.galleryDropDown8.Gallery.AllowFilter = false;
            this.galleryDropDown8.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem1,
            createFullStackedBarChartItem1,
            createSideBySideFullStackedBarChartItem1,
            createSideBySideStackedBarChartItem1,
            createStackedBarChartItem1});
            chartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem1,
            createFullStackedBar3DChartItem1,
            createManhattanBarChartItem1,
            createSideBySideFullStackedBar3DChartItem1,
            createSideBySideStackedBar3DChartItem1,
            createStackedBar3DChartItem1});
            chartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem1,
            createCylinderFullStackedBar3DChartItem1,
            createCylinderManhattanBarChartItem1,
            createCylinderSideBySideFullStackedBar3DChartItem1,
            createCylinderSideBySideStackedBar3DChartItem1,
            createCylinderStackedBar3DChartItem1});
            chartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem1,
            createConeFullStackedBar3DChartItem1,
            createConeManhattanBarChartItem1,
            createConeSideBySideFullStackedBar3DChartItem1,
            createConeSideBySideStackedBar3DChartItem1,
            createConeStackedBar3DChartItem1});
            chartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem1,
            createPyramidFullStackedBar3DChartItem1,
            createPyramidManhattanBarChartItem1,
            createPyramidSideBySideFullStackedBar3DChartItem1,
            createPyramidSideBySideStackedBar3DChartItem1,
            createPyramidStackedBar3DChartItem1});
            this.galleryDropDown8.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn1,
            chartControlCommandGalleryItemGroup3DColumn1,
            chartControlCommandGalleryItemGroupCylinderColumn1,
            chartControlCommandGalleryItemGroupConeColumn1,
            chartControlCommandGalleryItemGroupPyramidColumn1});
            this.galleryDropDown8.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryDropDown8.Gallery.RowCount = 10;
            this.galleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.galleryDropDown8.Manager = this.barManager1;
            this.galleryDropDown8.Name = "galleryDropDown8";
            // 
            // createLineBaseItem1
            // 
            this.createLineBaseItem1.DropDownControl = this.galleryDropDown9;
            this.createLineBaseItem1.Id = 0;
            this.createLineBaseItem1.Name = "createLineBaseItem1";
            // 
            // galleryDropDown9
            // 
            // 
            // 
            // 
            this.galleryDropDown9.Gallery.AllowFilter = false;
            this.galleryDropDown9.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DLine1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem1,
            createFullStackedLineChartItem1,
            createScatterLineChartItem1,
            createSplineChartItem1,
            createStackedLineChartItem1,
            createStepLineChartItem1});
            chartControlCommandGalleryItemGroup3DLine1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem1,
            createFullStackedLine3DChartItem1,
            createSpline3DChartItem1,
            createStackedLine3DChartItem1,
            createStepLine3DChartItem1});
            this.galleryDropDown9.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine1,
            chartControlCommandGalleryItemGroup3DLine1});
            this.galleryDropDown9.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryDropDown9.Gallery.RowCount = 4;
            this.galleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.galleryDropDown9.Manager = this.barManager1;
            this.galleryDropDown9.Name = "galleryDropDown9";
            // 
            // createPieBaseItem1
            // 
            this.createPieBaseItem1.DropDownControl = this.galleryDropDown10;
            this.createPieBaseItem1.Id = 1;
            this.createPieBaseItem1.Name = "createPieBaseItem1";
            // 
            // galleryDropDown10
            // 
            // 
            // 
            // 
            this.galleryDropDown10.Gallery.AllowFilter = false;
            this.galleryDropDown10.Gallery.ColumnCount = 2;
            chartControlCommandGalleryItemGroup2DPie1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem1,
            createDoughnutChartItem1});
            chartControlCommandGalleryItemGroup3DPie1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem1,
            createDoughnut3DChartItem1});
            this.galleryDropDown10.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie1,
            chartControlCommandGalleryItemGroup3DPie1});
            this.galleryDropDown10.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryDropDown10.Gallery.RowCount = 2;
            this.galleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.galleryDropDown10.Manager = this.barManager1;
            this.galleryDropDown10.Name = "galleryDropDown10";
            // 
            // createRotatedBarBaseItem1
            // 
            this.createRotatedBarBaseItem1.DropDownControl = this.galleryDropDown11;
            this.createRotatedBarBaseItem1.Id = 2;
            this.createRotatedBarBaseItem1.Name = "createRotatedBarBaseItem1";
            // 
            // galleryDropDown11
            // 
            // 
            // 
            // 
            this.galleryDropDown11.Gallery.AllowFilter = false;
            this.galleryDropDown11.Gallery.ColumnCount = 3;
            chartControlCommandGalleryItemGroup2DBar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem1,
            createRotatedFullStackedBarChartItem1,
            createRotatedSideBySideFullStackedBarChartItem1,
            createRotatedSideBySideStackedBarChartItem1,
            createRotatedStackedBarChartItem1});
            this.galleryDropDown11.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar1});
            this.galleryDropDown11.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryDropDown11.Gallery.RowCount = 2;
            this.galleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.galleryDropDown11.Manager = this.barManager1;
            this.galleryDropDown11.Name = "galleryDropDown11";
            // 
            // createAreaBaseItem1
            // 
            this.createAreaBaseItem1.DropDownControl = this.galleryDropDown12;
            this.createAreaBaseItem1.Id = 3;
            this.createAreaBaseItem1.Name = "createAreaBaseItem1";
            // 
            // galleryDropDown12
            // 
            // 
            // 
            // 
            this.galleryDropDown12.Gallery.AllowFilter = false;
            this.galleryDropDown12.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroup2DArea1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem1,
            createFullStackedAreaChartItem1,
            createFullStackedSplineAreaChartItem1,
            createSplineAreaChartItem1,
            createStackedAreaChartItem1,
            createStackedSplineAreaChartItem1,
            createStepAreaChartItem1});
            chartControlCommandGalleryItemGroup3DArea1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem1,
            createFullStackedArea3DChartItem1,
            createFullStackedSplineArea3DChartItem1,
            createSplineArea3DChartItem1,
            createStackedArea3DChartItem1,
            createStackedSplineArea3DChartItem1,
            createStepArea3DChartItem1});
            this.galleryDropDown12.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea1,
            chartControlCommandGalleryItemGroup3DArea1});
            this.galleryDropDown12.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryDropDown12.Gallery.RowCount = 4;
            this.galleryDropDown12.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.galleryDropDown12.Manager = this.barManager1;
            this.galleryDropDown12.Name = "galleryDropDown12";
            // 
            // createOtherSeriesTypesBaseItem1
            // 
            this.createOtherSeriesTypesBaseItem1.DropDownControl = this.galleryDropDown13;
            this.createOtherSeriesTypesBaseItem1.Id = 4;
            this.createOtherSeriesTypesBaseItem1.Name = "createOtherSeriesTypesBaseItem1";
            // 
            // galleryDropDown13
            // 
            // 
            // 
            // 
            this.galleryDropDown13.Gallery.AllowFilter = false;
            this.galleryDropDown13.Gallery.ColumnCount = 4;
            chartControlCommandGalleryItemGroupPoint1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem1,
            createBubbleChartItem1});
            chartControlCommandGalleryItemGroupFunnel1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem1,
            createFunnel3DChartItem1});
            chartControlCommandGalleryItemGroupFinancial1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem1,
            createCandleStickChartItem1});
            chartControlCommandGalleryItemGroupRadar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem1,
            createRadarLineChartItem1,
            createRadarAreaChartItem1});
            chartControlCommandGalleryItemGroupPolar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem1,
            createPolarLineChartItem1,
            createPolarAreaChartItem1});
            chartControlCommandGalleryItemGroupRange1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem1,
            createSideBySideRangeBarChartItem1,
            createRangeAreaChartItem1,
            createRangeArea3DChartItem1});
            chartControlCommandGalleryItemGroupGantt1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem1,
            createSideBySideGanttChartItem1});
            this.galleryDropDown13.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint1,
            chartControlCommandGalleryItemGroupFunnel1,
            chartControlCommandGalleryItemGroupFinancial1,
            chartControlCommandGalleryItemGroupRadar1,
            chartControlCommandGalleryItemGroupPolar1,
            chartControlCommandGalleryItemGroupRange1,
            chartControlCommandGalleryItemGroupGantt1});
            this.galleryDropDown13.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryDropDown13.Gallery.RowCount = 7;
            this.galleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.galleryDropDown13.Manager = this.barManager1;
            this.galleryDropDown13.Name = "galleryDropDown13";
            // 
            // chartAppearanceBar1
            // 
            this.chartAppearanceBar1.DockCol = 1;
            this.chartAppearanceBar1.DockRow = 0;
            this.chartAppearanceBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.chartAppearanceBar1.FloatLocation = new System.Drawing.Point(358, 236);
            this.chartAppearanceBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.changePaletteGalleryBaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeAppearanceGalleryBaseBarManagerItem1)});
            this.chartAppearanceBar1.Offset = 209;
            this.chartAppearanceBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // changePaletteGalleryBaseItem1
            // 
            this.changePaletteGalleryBaseItem1.DropDownControl = this.galleryDropDown14;
            this.changePaletteGalleryBaseItem1.Id = 5;
            this.changePaletteGalleryBaseItem1.Name = "changePaletteGalleryBaseItem1";
            // 
            // galleryDropDown14
            // 
            // 
            // 
            // 
            this.galleryDropDown14.Gallery.AllowFilter = false;
            this.galleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.galleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.galleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.galleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.galleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.galleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.galleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.galleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.galleryDropDown14.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.galleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = true;
            this.galleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.galleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.galleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = true;
            this.galleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.galleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.galleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = true;
            this.galleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.galleryDropDown14.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.galleryDropDown14.Gallery.ColumnCount = 1;
            this.galleryDropDown14.Gallery.ImageSize = new System.Drawing.Size(160, 10);
            this.galleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.galleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right;
            skinPaddingEdges1.Bottom = -3;
            skinPaddingEdges1.Top = -3;
            this.galleryDropDown14.Gallery.ItemImagePadding = skinPaddingEdges1;
            skinPaddingEdges2.Bottom = -3;
            skinPaddingEdges2.Top = -3;
            this.galleryDropDown14.Gallery.ItemTextPadding = skinPaddingEdges2;
            this.galleryDropDown14.Gallery.RowCount = 10;
            this.galleryDropDown14.Gallery.ShowGroupCaption = false;
            this.galleryDropDown14.Gallery.ShowItemText = true;
            this.galleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.galleryDropDown14.Manager = this.barManager1;
            this.galleryDropDown14.Name = "galleryDropDown14";
            // 
            // changeAppearanceGalleryBaseBarManagerItem1
            // 
            this.changeAppearanceGalleryBaseBarManagerItem1.DropDownControl = this.galleryDropDown15;
            this.changeAppearanceGalleryBaseBarManagerItem1.Id = 6;
            this.changeAppearanceGalleryBaseBarManagerItem1.Name = "changeAppearanceGalleryBaseBarManagerItem1";
            // 
            // galleryDropDown15
            // 
            // 
            // 
            // 
            this.galleryDropDown15.Gallery.AllowFilter = false;
            this.galleryDropDown15.Gallery.ColumnCount = 7;
            this.galleryDropDown15.Gallery.ImageSize = new System.Drawing.Size(80, 50);
            this.galleryDropDown15.Gallery.RowCount = 4;
            this.galleryDropDown15.Gallery.ShowGroupCaption = false;
            this.galleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.galleryDropDown15.Manager = this.barManager1;
            this.galleryDropDown15.Name = "galleryDropDown15";
            // 
            // chartWizardBar1
            // 
            this.chartWizardBar1.DockCol = 0;
            this.chartWizardBar1.DockRow = 1;
            this.chartWizardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.chartWizardBar1.FloatLocation = new System.Drawing.Point(263, 230);
            this.chartWizardBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.runWizardChartItem1)});
            this.chartWizardBar1.Offset = 9;
            this.chartWizardBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // runWizardChartItem1
            // 
            this.runWizardChartItem1.Id = 7;
            this.runWizardChartItem1.Name = "runWizardChartItem1";
            // 
            // chartTemplatesBar1
            // 
            this.chartTemplatesBar1.DockCol = 1;
            this.chartTemplatesBar1.DockRow = 1;
            this.chartTemplatesBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.chartTemplatesBar1.FloatLocation = new System.Drawing.Point(304, 230);
            this.chartTemplatesBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.saveAsTemplateChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.loadTemplateChartItem1)});
            this.chartTemplatesBar1.Offset = 97;
            this.chartTemplatesBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // saveAsTemplateChartItem1
            // 
            this.saveAsTemplateChartItem1.Id = 8;
            this.saveAsTemplateChartItem1.Name = "saveAsTemplateChartItem1";
            // 
            // loadTemplateChartItem1
            // 
            this.loadTemplateChartItem1.Id = 9;
            this.loadTemplateChartItem1.Name = "loadTemplateChartItem1";
            // 
            // chartPrintExportBar1
            // 
            this.chartPrintExportBar1.DockCol = 2;
            this.chartPrintExportBar1.DockRow = 1;
            this.chartPrintExportBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.chartPrintExportBar1.FloatLocation = new System.Drawing.Point(370, 211);
            this.chartPrintExportBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.createExportBaseItem1)});
            this.chartPrintExportBar1.Offset = 169;
            this.chartPrintExportBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // printPreviewChartItem1
            // 
            this.printPreviewChartItem1.Id = 10;
            this.printPreviewChartItem1.Name = "printPreviewChartItem1";
            // 
            // printChartItem1
            // 
            this.printChartItem1.Id = 11;
            this.printChartItem1.Name = "printChartItem1";
            // 
            // createExportBaseItem1
            // 
            this.createExportBaseItem1.Id = 12;
            this.createExportBaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToPDFChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToHTMLChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToMHTChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToXLSChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToXLSXChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToRTFChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.createExportToImageBaseItem1)});
            this.createExportBaseItem1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText;
            this.createExportBaseItem1.Name = "createExportBaseItem1";
            // 
            // exportToPDFChartItem1
            // 
            this.exportToPDFChartItem1.Id = 13;
            this.exportToPDFChartItem1.Name = "exportToPDFChartItem1";
            // 
            // exportToHTMLChartItem1
            // 
            this.exportToHTMLChartItem1.Id = 14;
            this.exportToHTMLChartItem1.Name = "exportToHTMLChartItem1";
            // 
            // exportToMHTChartItem1
            // 
            this.exportToMHTChartItem1.Id = 15;
            this.exportToMHTChartItem1.Name = "exportToMHTChartItem1";
            // 
            // exportToXLSChartItem1
            // 
            this.exportToXLSChartItem1.Id = 16;
            this.exportToXLSChartItem1.Name = "exportToXLSChartItem1";
            // 
            // exportToXLSXChartItem1
            // 
            this.exportToXLSXChartItem1.Id = 17;
            this.exportToXLSXChartItem1.Name = "exportToXLSXChartItem1";
            // 
            // exportToRTFChartItem1
            // 
            this.exportToRTFChartItem1.Id = 18;
            this.exportToRTFChartItem1.Name = "exportToRTFChartItem1";
            // 
            // createExportToImageBaseItem1
            // 
            this.createExportToImageBaseItem1.Id = 19;
            this.createExportToImageBaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToBMPChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToGIFChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToJPEGChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToPNGChartItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToTIFFChartItem1)});
            this.createExportToImageBaseItem1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText;
            this.createExportToImageBaseItem1.Name = "createExportToImageBaseItem1";
            // 
            // exportToBMPChartItem1
            // 
            this.exportToBMPChartItem1.Id = 20;
            this.exportToBMPChartItem1.Name = "exportToBMPChartItem1";
            // 
            // exportToGIFChartItem1
            // 
            this.exportToGIFChartItem1.Id = 21;
            this.exportToGIFChartItem1.Name = "exportToGIFChartItem1";
            // 
            // exportToJPEGChartItem1
            // 
            this.exportToJPEGChartItem1.Id = 22;
            this.exportToJPEGChartItem1.Name = "exportToJPEGChartItem1";
            // 
            // exportToPNGChartItem1
            // 
            this.exportToPNGChartItem1.Id = 23;
            this.exportToPNGChartItem1.Name = "exportToPNGChartItem1";
            // 
            // exportToTIFFChartItem1
            // 
            this.exportToTIFFChartItem1.Id = 24;
            this.exportToTIFFChartItem1.Name = "exportToTIFFChartItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(810, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 488);
            this.barDockControlBottom.Size = new System.Drawing.Size(810, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 488);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(810, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 488);
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(198, 195);
            this.textEdit4.MenuManager = this.barManager1;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(101, 20);
            this.textEdit4.StyleController = this.layoutControl2;
            this.textEdit4.TabIndex = 10;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(198, 171);
            this.textEdit3.MenuManager = this.barManager1;
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(101, 20);
            this.textEdit3.StyleController = this.layoutControl2;
            this.textEdit3.TabIndex = 9;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(24, 147);
            this.textEdit2.MenuManager = this.barManager1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(275, 20);
            this.textEdit2.StyleController = this.layoutControl2;
            this.textEdit2.TabIndex = 8;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(315, 12);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage4;
            this.xtraTabControl2.Size = new System.Drawing.Size(477, 436);
            this.xtraTabControl2.TabIndex = 6;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.chartControl2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(471, 408);
            this.xtraTabPage4.Text = "Diseño refractario";
            // 
            // chartControl2
            // 
            this.chartControl2.DataAdapter = this.t_DegradeeTableAdapter1;
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram2;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Name = "chartControl2";
            sideBySideBarSeriesLabel1.LineVisible = true;
            series2.Label = sideBySideBarSeriesLabel1;
            series2.Name = "Series 1";
            sideBySideBarSeriesLabel2.LineVisible = true;
            series3.Label = sideBySideBarSeriesLabel2;
            series3.Name = "Series 2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2,
        series3};
            sideBySideBarSeriesLabel3.LineVisible = true;
            this.chartControl2.SeriesTemplate.Label = sideBySideBarSeriesLabel3;
            this.chartControl2.Size = new System.Drawing.Size(471, 408);
            this.chartControl2.TabIndex = 0;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.chartControl3);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(471, 408);
            this.xtraTabPage5.Text = "Gráfico de temperaturas";
            // 
            // chartControl3
            // 
            this.chartControl3.DataAdapter = this.t_DegradeeTableAdapter1;
            xyDiagram3.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram3.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram3.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl3.Diagram = xyDiagram3;
            this.chartControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl3.Location = new System.Drawing.Point(0, 0);
            this.chartControl3.Name = "chartControl3";
            sideBySideBarSeriesLabel4.LineVisible = true;
            series4.Label = sideBySideBarSeriesLabel4;
            series4.Name = "Series 1";
            sideBySideBarSeriesLabel5.LineVisible = true;
            series5.Label = sideBySideBarSeriesLabel5;
            series5.Name = "Series 2";
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5};
            sideBySideBarSeriesLabel6.LineVisible = true;
            this.chartControl3.SeriesTemplate.Label = sideBySideBarSeriesLabel6;
            this.chartControl3.Size = new System.Drawing.Size(471, 408);
            this.chartControl3.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(198, 67);
            this.textEdit1.MenuManager = this.barManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(101, 20);
            this.textEdit1.StyleController = this.layoutControl2;
            this.textEdit1.TabIndex = 5;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(198, 43);
            this.comboBoxEdit1.MenuManager = this.barManager1;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(101, 20);
            this.comboBoxEdit1.StyleController = this.layoutControl2;
            this.comboBoxEdit1.TabIndex = 4;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(24, 107);
            this.comboBoxEdit2.MenuManager = this.barManager1;
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Size = new System.Drawing.Size(275, 20);
            this.comboBoxEdit2.StyleController = this.layoutControl2;
            this.comboBoxEdit2.TabIndex = 7;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(804, 460);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.xtraTabControl2;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(303, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(481, 440);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Condiciones iniciales";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem12,
            this.layoutControlItem11});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(303, 269);
            this.layoutControlGroup3.Text = "Condiciones iniciales";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit1;
            this.layoutControlItem4.CustomizationFormText = "Temperatura (°C):";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem4.Text = "Temperatura (°C):";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboBoxEdit1;
            this.layoutControlItem2.CustomizationFormText = "Régimen:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem2.Text = "Régimen:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.comboBoxEdit2;
            this.layoutControlItem6.CustomizationFormText = "Temperatura Final (°C) :";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(279, 40);
            this.layoutControlItem6.Text = "Temperatura Final (°C) :";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit2;
            this.layoutControlItem7.CustomizationFormText = "Variación de temperatura (°C/min) :";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(279, 40);
            this.layoutControlItem7.Text = "Variación de temperatura (°C/min) :";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textEdit3;
            this.layoutControlItem8.CustomizationFormText = "Particiones (mm):";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem8.Text = "Particiones (mm):";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.textEdit4;
            this.layoutControlItem9.CustomizationFormText = "Tiempo total (min):";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 152);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem9.Text = "Tiempo total (min):";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.textEdit5;
            this.layoutControlItem10.CustomizationFormText = "Variación de tiempo (min):";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 176);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(279, 24);
            this.layoutControlItem10.Text = "Variación de tiempo (min):";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(171, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.simpleButton2;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem12";
            this.layoutControlItem12.Location = new System.Drawing.Point(139, 200);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(140, 26);
            this.layoutControlItem12.Text = "layoutControlItem12";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextToControlDistance = 0;
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.simpleButton1;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 200);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(139, 26);
            this.layoutControlItem11.Text = "layoutControlItem11";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 0;
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Resultado (Lineas de Temperatura)";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem13});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 269);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(303, 171);
            this.layoutControlGroup4.Text = "Resultado (Lineas de Temperatura)";
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.treeList2;
            this.layoutControlItem13.CustomizationFormText = "layoutControlItem13";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(279, 128);
            this.layoutControlItem13.Text = "layoutControlItem13";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextToControlDistance = 0;
            this.layoutControlItem13.TextVisible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "T_Project";
            this.bindingSource1.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_ProjectTableAdapter
            // 
            this.t_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // t_Tipo_ParedTableAdapter1
            // 
            this.t_Tipo_ParedTableAdapter1.ClearBeforeFill = true;
            // 
            // chartBarController1
            // 
            this.chartBarController1.BarItems.Add(this.createBarBaseItem1);
            this.chartBarController1.BarItems.Add(this.createLineBaseItem1);
            this.chartBarController1.BarItems.Add(this.createPieBaseItem1);
            this.chartBarController1.BarItems.Add(this.createRotatedBarBaseItem1);
            this.chartBarController1.BarItems.Add(this.createAreaBaseItem1);
            this.chartBarController1.BarItems.Add(this.createOtherSeriesTypesBaseItem1);
            this.chartBarController1.BarItems.Add(this.changePaletteGalleryBaseItem1);
            this.chartBarController1.BarItems.Add(this.changeAppearanceGalleryBaseBarManagerItem1);
            this.chartBarController1.BarItems.Add(this.runWizardChartItem1);
            this.chartBarController1.BarItems.Add(this.saveAsTemplateChartItem1);
            this.chartBarController1.BarItems.Add(this.loadTemplateChartItem1);
            this.chartBarController1.BarItems.Add(this.printPreviewChartItem1);
            this.chartBarController1.BarItems.Add(this.printChartItem1);
            this.chartBarController1.BarItems.Add(this.createExportBaseItem1);
            this.chartBarController1.BarItems.Add(this.exportToPDFChartItem1);
            this.chartBarController1.BarItems.Add(this.exportToHTMLChartItem1);
            this.chartBarController1.BarItems.Add(this.exportToMHTChartItem1);
            this.chartBarController1.BarItems.Add(this.exportToXLSChartItem1);
            this.chartBarController1.BarItems.Add(this.exportToXLSXChartItem1);
            this.chartBarController1.BarItems.Add(this.exportToRTFChartItem1);
            this.chartBarController1.BarItems.Add(this.createExportToImageBaseItem1);
            this.chartBarController1.BarItems.Add(this.exportToBMPChartItem1);
            this.chartBarController1.BarItems.Add(this.exportToGIFChartItem1);
            this.chartBarController1.BarItems.Add(this.exportToJPEGChartItem1);
            this.chartBarController1.BarItems.Add(this.exportToPNGChartItem1);
            this.chartBarController1.BarItems.Add(this.exportToTIFFChartItem1);
            this.chartBarController1.Control = this.chartControl1;
            // 
            // galleryDropDown1
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem2,
            createFullStackedBarChartItem2,
            createSideBySideFullStackedBarChartItem2,
            createSideBySideStackedBarChartItem2,
            createStackedBarChartItem2});
            chartControlCommandGalleryItemGroup3DColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem2,
            createFullStackedBar3DChartItem2,
            createManhattanBarChartItem2,
            createSideBySideFullStackedBar3DChartItem2,
            createSideBySideStackedBar3DChartItem2,
            createStackedBar3DChartItem2});
            chartControlCommandGalleryItemGroupCylinderColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem2,
            createCylinderFullStackedBar3DChartItem2,
            createCylinderManhattanBarChartItem2,
            createCylinderSideBySideFullStackedBar3DChartItem2,
            createCylinderSideBySideStackedBar3DChartItem2,
            createCylinderStackedBar3DChartItem2});
            chartControlCommandGalleryItemGroupConeColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem2,
            createConeFullStackedBar3DChartItem2,
            createConeManhattanBarChartItem2,
            createConeSideBySideFullStackedBar3DChartItem2,
            createConeSideBySideStackedBar3DChartItem2,
            createConeStackedBar3DChartItem2});
            chartControlCommandGalleryItemGroupPyramidColumn2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem2,
            createPyramidFullStackedBar3DChartItem2,
            createPyramidManhattanBarChartItem2,
            createPyramidSideBySideFullStackedBar3DChartItem2,
            createPyramidSideBySideStackedBar3DChartItem2,
            createPyramidStackedBar3DChartItem2});
            this.galleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn2,
            chartControlCommandGalleryItemGroup3DColumn2,
            chartControlCommandGalleryItemGroupCylinderColumn2,
            chartControlCommandGalleryItemGroupConeColumn2,
            chartControlCommandGalleryItemGroupPyramidColumn2});
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // galleryDropDown2
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DLine2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem2,
            createFullStackedLineChartItem2,
            createScatterLineChartItem2,
            createSplineChartItem2,
            createStackedLineChartItem2,
            createStepLineChartItem2});
            chartControlCommandGalleryItemGroup3DLine2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem2,
            createFullStackedLine3DChartItem2,
            createSpline3DChartItem2,
            createStackedLine3DChartItem2,
            createStepLine3DChartItem2});
            this.galleryDropDown2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine2,
            chartControlCommandGalleryItemGroup3DLine2});
            this.galleryDropDown2.Name = "galleryDropDown2";
            // 
            // galleryDropDown3
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DPie2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem2,
            createDoughnutChartItem2});
            chartControlCommandGalleryItemGroup3DPie2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem2,
            createDoughnut3DChartItem2});
            this.galleryDropDown3.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie2,
            chartControlCommandGalleryItemGroup3DPie2});
            this.galleryDropDown3.Name = "galleryDropDown3";
            // 
            // galleryDropDown4
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DBar2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem2,
            createRotatedFullStackedBarChartItem2,
            createRotatedSideBySideFullStackedBarChartItem2,
            createRotatedSideBySideStackedBarChartItem2,
            createRotatedStackedBarChartItem2});
            this.galleryDropDown4.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar2});
            this.galleryDropDown4.Name = "galleryDropDown4";
            // 
            // galleryDropDown5
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DArea2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem2,
            createFullStackedAreaChartItem2,
            createFullStackedSplineAreaChartItem2,
            createSplineAreaChartItem2,
            createStackedAreaChartItem2,
            createStackedSplineAreaChartItem2,
            createStepAreaChartItem2});
            chartControlCommandGalleryItemGroup3DArea2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem2,
            createFullStackedArea3DChartItem2,
            createFullStackedSplineArea3DChartItem2,
            createSplineArea3DChartItem2,
            createStackedArea3DChartItem2,
            createStackedSplineArea3DChartItem2,
            createStepArea3DChartItem2});
            this.galleryDropDown5.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea2,
            chartControlCommandGalleryItemGroup3DArea2});
            this.galleryDropDown5.Name = "galleryDropDown5";
            // 
            // galleryDropDown6
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroupPoint2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem2,
            createBubbleChartItem2});
            chartControlCommandGalleryItemGroupFunnel2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem2,
            createFunnel3DChartItem2});
            chartControlCommandGalleryItemGroupFinancial2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem2,
            createCandleStickChartItem2});
            chartControlCommandGalleryItemGroupRadar2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem2,
            createRadarLineChartItem2,
            createRadarAreaChartItem2});
            chartControlCommandGalleryItemGroupPolar2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem2,
            createPolarLineChartItem2,
            createPolarAreaChartItem2});
            chartControlCommandGalleryItemGroupRange2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem2,
            createSideBySideRangeBarChartItem2,
            createRangeAreaChartItem2,
            createRangeArea3DChartItem2});
            chartControlCommandGalleryItemGroupGantt2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem2,
            createSideBySideGanttChartItem2});
            this.galleryDropDown6.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint2,
            chartControlCommandGalleryItemGroupFunnel2,
            chartControlCommandGalleryItemGroupFinancial2,
            chartControlCommandGalleryItemGroupRadar2,
            chartControlCommandGalleryItemGroupPolar2,
            chartControlCommandGalleryItemGroupRange2,
            chartControlCommandGalleryItemGroupGantt2});
            this.galleryDropDown6.Name = "galleryDropDown6";
            // 
            // galleryDropDown7
            // 
            // 
            // 
            // 
            changePaletteGalleryItem1.Caption = "Ápice";
            changePaletteGalleryItem1.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem1.Image")));
            changePaletteGalleryItem1.Tag = "Ápice";
            changePaletteGalleryItem2.Caption = "Árboles";
            changePaletteGalleryItem2.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem2.Image")));
            changePaletteGalleryItem2.Tag = "Árboles";
            changePaletteGalleryItem3.Caption = "Aspecto";
            changePaletteGalleryItem3.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem3.Image")));
            changePaletteGalleryItem3.Tag = "Aspecto";
            changePaletteGalleryItem4.Caption = "Blanco y Negro";
            changePaletteGalleryItem4.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem4.Image")));
            changePaletteGalleryItem4.Tag = "Blanco y Negro";
            changePaletteGalleryItem5.Caption = "Chameleon";
            changePaletteGalleryItem5.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem5.Image")));
            changePaletteGalleryItem5.Tag = "Chameleon";
            changePaletteGalleryItem6.Caption = "Cívico";
            changePaletteGalleryItem6.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem6.Image")));
            changePaletteGalleryItem6.Tag = "Cívico";
            changePaletteGalleryItem7.Caption = "Colores Naturales";
            changePaletteGalleryItem7.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem7.Image")));
            changePaletteGalleryItem7.Tag = "Colores Naturales";
            changePaletteGalleryItem8.Caption = "Concurso";
            changePaletteGalleryItem8.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem8.Image")));
            changePaletteGalleryItem8.Tag = "Concurso";
            changePaletteGalleryItem9.Caption = "Equidad";
            changePaletteGalleryItem9.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem9.Image")));
            changePaletteGalleryItem9.Tag = "Equidad";
            changePaletteGalleryItem10.Caption = "Escala de grises";
            changePaletteGalleryItem10.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem10.Image")));
            changePaletteGalleryItem10.Tag = "Escala de grises";
            changePaletteGalleryItem11.Caption = "Flujo";
            changePaletteGalleryItem11.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem11.Image")));
            changePaletteGalleryItem11.Tag = "Flujo";
            changePaletteGalleryItem12.Caption = "Fundución";
            changePaletteGalleryItem12.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem12.Image")));
            changePaletteGalleryItem12.Tag = "Fundución";
            changePaletteGalleryItem13.Caption = "Luces Septentrional ";
            changePaletteGalleryItem13.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem13.Image")));
            changePaletteGalleryItem13.Tag = "Luces Septentrional ";
            changePaletteGalleryItem14.Caption = "Metro";
            changePaletteGalleryItem14.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem14.Image")));
            changePaletteGalleryItem14.Tag = "Metro";
            changePaletteGalleryItem15.Caption = "Mezclado";
            changePaletteGalleryItem15.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem15.Image")));
            changePaletteGalleryItem15.Tag = "Mezclado";
            changePaletteGalleryItem16.Caption = "Mirador";
            changePaletteGalleryItem16.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem16.Image")));
            changePaletteGalleryItem16.Tag = "Mirador";
            changePaletteGalleryItem17.Caption = "Módulo";
            changePaletteGalleryItem17.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem17.Image")));
            changePaletteGalleryItem17.Tag = "Módulo";
            changePaletteGalleryItem18.Caption = "Neblina";
            changePaletteGalleryItem18.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem18.Image")));
            changePaletteGalleryItem18.Tag = "Neblina";
            changePaletteGalleryItem19.Caption = "Office";
            changePaletteGalleryItem19.Checked = true;
            changePaletteGalleryItem19.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem19.Image")));
            changePaletteGalleryItem19.Tag = "Office";
            changePaletteGalleryItem20.Caption = "Opulento";
            changePaletteGalleryItem20.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem20.Image")));
            changePaletteGalleryItem20.Tag = "Opulento";
            changePaletteGalleryItem21.Caption = "Origen";
            changePaletteGalleryItem21.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem21.Image")));
            changePaletteGalleryItem21.Tag = "Origen";
            changePaletteGalleryItem22.Caption = "Papel";
            changePaletteGalleryItem22.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem22.Image")));
            changePaletteGalleryItem22.Tag = "Papel";
            changePaletteGalleryItem23.Caption = "Pastel";
            changePaletteGalleryItem23.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem23.Image")));
            changePaletteGalleryItem23.Tag = "Pastel";
            changePaletteGalleryItem24.Caption = "Promedio";
            changePaletteGalleryItem24.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem24.Image")));
            changePaletteGalleryItem24.Tag = "Promedio";
            changePaletteGalleryItem25.Caption = "Solstice";
            changePaletteGalleryItem25.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem25.Image")));
            changePaletteGalleryItem25.Tag = "Solstice";
            changePaletteGalleryItem26.Caption = "Tarta de Arcilla";
            changePaletteGalleryItem26.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem26.Image")));
            changePaletteGalleryItem26.Tag = "Tarta de Arcilla";
            changePaletteGalleryItem27.Caption = "Técnico";
            changePaletteGalleryItem27.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem27.Image")));
            changePaletteGalleryItem27.Tag = "Técnico";
            changePaletteGalleryItem28.Caption = "Trek";
            changePaletteGalleryItem28.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem28.Image")));
            changePaletteGalleryItem28.Tag = "Trek";
            changePaletteGalleryItem29.Caption = "Urbano";
            changePaletteGalleryItem29.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem29.Image")));
            changePaletteGalleryItem29.Tag = "Urbano";
            changePaletteGalleryItem30.Caption = "Vigor";
            changePaletteGalleryItem30.Image = ((System.Drawing.Image)(resources.GetObject("changePaletteGalleryItem30.Image")));
            changePaletteGalleryItem30.Tag = "Vigor";
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            changePaletteGalleryItem1,
            changePaletteGalleryItem2,
            changePaletteGalleryItem3,
            changePaletteGalleryItem4,
            changePaletteGalleryItem5,
            changePaletteGalleryItem6,
            changePaletteGalleryItem7,
            changePaletteGalleryItem8,
            changePaletteGalleryItem9,
            changePaletteGalleryItem10,
            changePaletteGalleryItem11,
            changePaletteGalleryItem12,
            changePaletteGalleryItem13,
            changePaletteGalleryItem14,
            changePaletteGalleryItem15,
            changePaletteGalleryItem16,
            changePaletteGalleryItem17,
            changePaletteGalleryItem18,
            changePaletteGalleryItem19,
            changePaletteGalleryItem20,
            changePaletteGalleryItem21,
            changePaletteGalleryItem22,
            changePaletteGalleryItem23,
            changePaletteGalleryItem24,
            changePaletteGalleryItem25,
            changePaletteGalleryItem26,
            changePaletteGalleryItem27,
            changePaletteGalleryItem28,
            changePaletteGalleryItem29,
            changePaletteGalleryItem30});
            this.galleryDropDown7.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryDropDown7.Name = "galleryDropDown7";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(12, 373);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(780, 22);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.simpleButton3;
            this.layoutControlItem14.CustomizationFormText = "layoutControlItem14";
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 361);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(784, 26);
            this.layoutControlItem14.Text = "layoutControlItem14";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextToControlDistance = 0;
            this.layoutControlItem14.TextVisible = false;
            // 
            // FrmEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 488);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstudio";
            this.Text = "FrmEstudio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEstudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedArea3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedArea3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private UCCompleteProperty ucCompleteProperty1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DSRD dSDatos;
        private T_ProjectTableAdapter t_ProjectTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private T_Tipo_ParedTableAdapter t_Tipo_ParedTableAdapter1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraCharts.UI.ChartBarController chartBarController1;
        private DevExpress.XtraCharts.UI.CreateBarBaseItem createBarBaseItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown8;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraCharts.UI.ChartTypeBar chartTypeBar1;
        private DevExpress.XtraCharts.UI.CreateLineBaseItem createLineBaseItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown9;
        private DevExpress.XtraCharts.UI.CreatePieBaseItem createPieBaseItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown10;
        private DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem createRotatedBarBaseItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown11;
        private DevExpress.XtraCharts.UI.CreateAreaBaseItem createAreaBaseItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown12;
        private DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem createOtherSeriesTypesBaseItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown13;
        private DevExpress.XtraCharts.UI.ChartAppearanceBar chartAppearanceBar1;
        private DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem changePaletteGalleryBaseItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown14;
        private DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseBarManagerItem changeAppearanceGalleryBaseBarManagerItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown15;
        private DevExpress.XtraCharts.UI.ChartWizardBar chartWizardBar1;
        private DevExpress.XtraCharts.UI.RunWizardChartItem runWizardChartItem1;
        private DevExpress.XtraCharts.UI.ChartTemplatesBar chartTemplatesBar1;
        private DevExpress.XtraCharts.UI.SaveAsTemplateChartItem saveAsTemplateChartItem1;
        private DevExpress.XtraCharts.UI.LoadTemplateChartItem loadTemplateChartItem1;
        private DevExpress.XtraCharts.UI.ChartPrintExportBar chartPrintExportBar1;
        private DevExpress.XtraCharts.UI.PrintPreviewChartItem printPreviewChartItem1;
        private DevExpress.XtraCharts.UI.PrintChartItem printChartItem1;
        private DevExpress.XtraCharts.UI.CreateExportBaseItem createExportBaseItem1;
        private DevExpress.XtraCharts.UI.ExportToPDFChartItem exportToPDFChartItem1;
        private DevExpress.XtraCharts.UI.ExportToHTMLChartItem exportToHTMLChartItem1;
        private DevExpress.XtraCharts.UI.ExportToMHTChartItem exportToMHTChartItem1;
        private DevExpress.XtraCharts.UI.ExportToXLSChartItem exportToXLSChartItem1;
        private DevExpress.XtraCharts.UI.ExportToXLSXChartItem exportToXLSXChartItem1;
        private DevExpress.XtraCharts.UI.ExportToRTFChartItem exportToRTFChartItem1;
        private DevExpress.XtraCharts.UI.CreateExportToImageBaseItem createExportToImageBaseItem1;
        private DevExpress.XtraCharts.UI.ExportToBMPChartItem exportToBMPChartItem1;
        private DevExpress.XtraCharts.UI.ExportToGIFChartItem exportToGIFChartItem1;
        private DevExpress.XtraCharts.UI.ExportToJPEGChartItem exportToJPEGChartItem1;
        private DevExpress.XtraCharts.UI.ExportToPNGChartItem exportToPNGChartItem1;
        private DevExpress.XtraCharts.UI.ExportToTIFFChartItem exportToTIFFChartItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown2;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown3;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown4;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown5;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown6;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown7;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraCharts.ChartControl chartControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit comboBoxEdit2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private T_DegradeeTableAdapter t_DegradeeTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
    }
}