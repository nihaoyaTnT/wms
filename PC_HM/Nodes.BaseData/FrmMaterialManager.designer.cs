﻿namespace Nodes.BaseData
{
    partial class FrmMaterialManager
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
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.toolRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.toolAdd = new DevExpress.XtraBars.BarButtonItem();
            this.toolCopyNew = new DevExpress.XtraBars.BarButtonItem();
            this.toolEdit = new DevExpress.XtraBars.BarButtonItem();
            this.toolDel = new DevExpress.XtraBars.BarButtonItem();
            this.toolPrint = new DevExpress.XtraBars.BarButtonItem();
            this.toolDesign = new DevExpress.XtraBars.BarButtonItem();
            this.toolSearch = new DevExpress.XtraBars.BarButtonItem();
            this.toolMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBoxDump = new System.Windows.Forms.TextBox();
            this.labDump = new System.Windows.Forms.Label();
            this.labYE = new System.Windows.Forms.Label();
            this.txtCountPage = new System.Windows.Forms.TextBox();
            this.labZG = new System.Windows.Forms.Label();
            this.txtCurePage = new System.Windows.Forms.TextBox();
            this.labCur = new System.Windows.Forms.Label();
            this.labLast = new System.Windows.Forms.Label();
            this.labNext = new System.Windows.Forms.Label();
            this.labPre = new System.Windows.Forms.Label();
            this.labFirst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "启用状态";
            this.gridColumn15.FieldName = "IsActive";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Width = 60;
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.toolRefresh,
            this.toolAdd,
            this.toolEdit,
            this.toolDel,
            this.toolSearch,
            this.toolCopyNew,
            this.toolPrint,
            this.toolDesign,
            this.toolMaterial,
            this.barListItem1});
            this.barManager1.MaxItemId = 18;
            // 
            // bar1
            // 
            this.bar1.BarName = "工具";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toolRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.toolAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.toolCopyNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.toolEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.toolDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.toolPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.toolDesign),
            new DevExpress.XtraBars.LinkPersistInfo(this.toolSearch, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.toolMaterial)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "工具";
            // 
            // toolRefresh
            // 
            this.toolRefresh.Caption = "刷新";
            this.toolRefresh.Id = 0;
            this.toolRefresh.Name = "toolRefresh";
            this.toolRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.toolRefresh.Tag = "刷新";
            this.toolRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnItemClick);
            // 
            // toolAdd
            // 
            this.toolAdd.Caption = "新增";
            this.toolAdd.Id = 1;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.toolAdd.Tag = "新增";
            this.toolAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.toolAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnItemClick);
            // 
            // toolCopyNew
            // 
            this.toolCopyNew.Caption = "复制新增";
            this.toolCopyNew.Id = 8;
            this.toolCopyNew.Name = "toolCopyNew";
            this.toolCopyNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.toolCopyNew.Tag = "复制新增";
            this.toolCopyNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.toolCopyNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnItemClick);
            // 
            // toolEdit
            // 
            this.toolEdit.Caption = "修改";
            this.toolEdit.Id = 2;
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.toolEdit.Tag = "修改";
            this.toolEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnItemClick);
            // 
            // toolDel
            // 
            this.toolDel.Caption = "删除";
            this.toolDel.Id = 3;
            this.toolDel.Name = "toolDel";
            this.toolDel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.toolDel.Tag = "删除";
            this.toolDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.toolDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnItemClick);
            // 
            // toolPrint
            // 
            this.toolPrint.Caption = "打印物料标签";
            this.toolPrint.Id = 9;
            this.toolPrint.Name = "toolPrint";
            this.toolPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.toolPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // toolDesign
            // 
            this.toolDesign.Caption = "设计打印模板";
            this.toolDesign.Id = 10;
            this.toolDesign.Name = "toolDesign";
            this.toolDesign.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.toolDesign.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // toolSearch
            // 
            this.toolSearch.Caption = "快速查找";
            this.toolSearch.Id = 4;
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.toolSearch.Tag = "快速查找";
            this.toolSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnItemClick);
            // 
            // toolMaterial
            // 
            this.toolMaterial.Caption = "本库物料信息";
            this.toolMaterial.Id = 16;
            this.toolMaterial.Name = "toolMaterial";
            this.toolMaterial.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.toolMaterial.Tag = "本库物料信息";
            this.toolMaterial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1118, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 482);
            this.barDockControlBottom.Size = new System.Drawing.Size(1118, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 451);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1118, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 451);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "uyiuiy";
            this.barListItem1.Id = 17;
            this.barListItem1.Name = "barListItem1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1118, 451);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn21,
            this.gridColumn3,
            this.gridColumn8,
            this.gridColumn5,
            this.gridColumn9,
            this.gridColumn14,
            this.gridColumn13,
            this.gridColumn4,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn15,
            this.gridColumn17,
            this.gridColumn7,
            this.gridColumn10});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.ID = "db195274-8eab-43e7-8bca-33f31f29cab1";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.RowDoubleClick += new System.EventHandler(this.gridView1_RowDoubleClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.OnGridMaterialFocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "物料编码";
            this.gridColumn1.FieldName = "MaterialCode";
            this.gridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 114;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "物料名称";
            this.gridColumn2.FieldName = "MaterialName";
            this.gridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 143;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "品牌";
            this.gridColumn6.FieldName = "BrandName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 67;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "分类";
            this.gridColumn21.FieldName = "MaterialTypeName";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "规格";
            this.gridColumn3.FieldName = "Spec";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "保质期(天)";
            this.gridColumn8.FieldName = "ExpDays";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "存储条件编码";
            this.gridColumn5.FieldName = "TemperatureCode";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "存储条件";
            this.gridColumn9.FieldName = "TemperatureName";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 60;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "低储";
            this.gridColumn14.FieldName = "MinStockQty";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 7;
            this.gridColumn14.Width = 66;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "高储";
            this.gridColumn13.FieldName = "MaxStockQty";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 8;
            this.gridColumn13.Width = 66;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "单货位安全库存";
            this.gridColumn4.FieldName = "SecurityQty";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 9;
            this.gridColumn4.Width = 99;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "最后更新时间";
            this.gridColumn22.DisplayFormat.FormatString = "g";
            this.gridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn22.FieldName = "LastUpdateDate";
            this.gridColumn22.Name = "gridColumn22";
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "最后更新人";
            this.gridColumn23.FieldName = "LastUpdateBy";
            this.gridColumn23.Name = "gridColumn23";
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "显示次序";
            this.gridColumn17.FieldName = "SortOrder";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Width = 60;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "商品类型";
            this.gridColumn7.FieldName = "SkuTypeDesc";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 10;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "总库存";
            this.gridColumn10.FieldName = "TotalStockQty";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 11;
            // 
            // textBoxDump
            // 
            this.textBoxDump.Location = new System.Drawing.Point(704, 4);
            this.textBoxDump.Name = "textBoxDump";
            this.textBoxDump.Size = new System.Drawing.Size(58, 21);
            this.textBoxDump.TabIndex = 67;
            this.textBoxDump.Visible = false;
            this.textBoxDump.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDump_KeyDown);
            // 
            // labDump
            // 
            this.labDump.AutoSize = true;
            this.labDump.Location = new System.Drawing.Point(656, 9);
            this.labDump.Name = "labDump";
            this.labDump.Size = new System.Drawing.Size(41, 12);
            this.labDump.TabIndex = 66;
            this.labDump.Text = "跳转页";
            this.labDump.Visible = false;
            this.labDump.Click += new System.EventHandler(this.labDump_Click);
            // 
            // labYE
            // 
            this.labYE.AutoSize = true;
            this.labYE.Location = new System.Drawing.Point(1093, 9);
            this.labYE.Name = "labYE";
            this.labYE.Size = new System.Drawing.Size(17, 12);
            this.labYE.TabIndex = 65;
            this.labYE.Text = "页";
            this.labYE.Visible = false;
            // 
            // txtCountPage
            // 
            this.txtCountPage.Location = new System.Drawing.Point(997, 2);
            this.txtCountPage.Name = "txtCountPage";
            this.txtCountPage.ReadOnly = true;
            this.txtCountPage.Size = new System.Drawing.Size(85, 21);
            this.txtCountPage.TabIndex = 64;
            this.txtCountPage.Visible = false;
            // 
            // labZG
            // 
            this.labZG.AutoSize = true;
            this.labZG.Location = new System.Drawing.Point(964, 9);
            this.labZG.Name = "labZG";
            this.labZG.Size = new System.Drawing.Size(29, 12);
            this.labZG.TabIndex = 63;
            this.labZG.Text = "总共";
            this.labZG.Visible = false;
            // 
            // txtCurePage
            // 
            this.txtCurePage.Location = new System.Drawing.Point(578, 3);
            this.txtCurePage.Name = "txtCurePage";
            this.txtCurePage.ReadOnly = true;
            this.txtCurePage.Size = new System.Drawing.Size(66, 21);
            this.txtCurePage.TabIndex = 62;
            this.txtCurePage.Visible = false;
            // 
            // labCur
            // 
            this.labCur.AutoSize = true;
            this.labCur.Location = new System.Drawing.Point(533, 9);
            this.labCur.Name = "labCur";
            this.labCur.Size = new System.Drawing.Size(41, 12);
            this.labCur.TabIndex = 61;
            this.labCur.Text = "当前页";
            this.labCur.Visible = false;
            // 
            // labLast
            // 
            this.labLast.AutoSize = true;
            this.labLast.Location = new System.Drawing.Point(911, 9);
            this.labLast.Name = "labLast";
            this.labLast.Size = new System.Drawing.Size(41, 12);
            this.labLast.TabIndex = 60;
            this.labLast.Text = "最后页";
            this.labLast.Visible = false;
            this.labLast.Click += new System.EventHandler(this.labLast_Click);
            // 
            // labNext
            // 
            this.labNext.AutoSize = true;
            this.labNext.Location = new System.Drawing.Point(864, 9);
            this.labNext.Name = "labNext";
            this.labNext.Size = new System.Drawing.Size(41, 12);
            this.labNext.TabIndex = 59;
            this.labNext.Text = "下一页";
            this.labNext.Visible = false;
            this.labNext.Click += new System.EventHandler(this.labNext_Click);
            // 
            // labPre
            // 
            this.labPre.AutoSize = true;
            this.labPre.Location = new System.Drawing.Point(817, 9);
            this.labPre.Name = "labPre";
            this.labPre.Size = new System.Drawing.Size(41, 12);
            this.labPre.TabIndex = 58;
            this.labPre.Text = "上一页";
            this.labPre.Visible = false;
            this.labPre.Click += new System.EventHandler(this.labPre_Click);
            // 
            // labFirst
            // 
            this.labFirst.AutoSize = true;
            this.labFirst.Location = new System.Drawing.Point(770, 9);
            this.labFirst.Name = "labFirst";
            this.labFirst.Size = new System.Drawing.Size(41, 12);
            this.labFirst.TabIndex = 57;
            this.labFirst.Text = "第一页";
            this.labFirst.Visible = false;
            this.labFirst.Click += new System.EventHandler(this.labFirst_Click);
            // 
            // FrmMaterialManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1118, 482);
            this.Controls.Add(this.textBoxDump);
            this.Controls.Add(this.labDump);
            this.Controls.Add(this.labYE);
            this.Controls.Add(this.txtCountPage);
            this.Controls.Add(this.labZG);
            this.Controls.Add(this.txtCurePage);
            this.Controls.Add(this.labCur);
            this.Controls.Add(this.labLast);
            this.Controls.Add(this.labNext);
            this.Controls.Add(this.labPre);
            this.Controls.Add(this.labFirst);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmMaterialManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料信息";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem toolRefresh;
        private DevExpress.XtraBars.BarButtonItem toolAdd;
        private DevExpress.XtraBars.BarButtonItem toolEdit;
        private DevExpress.XtraBars.BarButtonItem toolDel;
        private DevExpress.XtraBars.BarButtonItem toolSearch;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraBars.BarButtonItem toolCopyNew;
        private DevExpress.XtraBars.BarButtonItem toolPrint;
        private DevExpress.XtraBars.BarButtonItem toolDesign;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraBars.BarButtonItem toolMaterial;
        private System.Windows.Forms.TextBox textBoxDump;
        private System.Windows.Forms.Label labDump;
        private System.Windows.Forms.Label labYE;
        private System.Windows.Forms.TextBox txtCountPage;
        private System.Windows.Forms.Label labZG;
        private System.Windows.Forms.TextBox txtCurePage;
        private System.Windows.Forms.Label labCur;
        private System.Windows.Forms.Label labLast;
        private System.Windows.Forms.Label labNext;
        private System.Windows.Forms.Label labPre;
        private System.Windows.Forms.Label labFirst;
        private DevExpress.XtraBars.BarListItem barListItem1;
    }
}