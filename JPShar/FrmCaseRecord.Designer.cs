namespace JPShar
{
    partial class FrmCaseRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaseRecord));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnReNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnLockYear = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CaseNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Person1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Person2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lawyer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Room = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CaseDecesionNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnReNew,
            this.btnLockYear,
            this.btnExportToExcel,
            this.btnBackup});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReNew, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLockYear, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBackup, true)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            toolTipTitleItem1.Text = "إضافة جديد";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnAdd.SuperTip = superToolTip1;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnReNew
            // 
            this.btnReNew.Caption = "ReNew";
            this.btnReNew.Id = 1;
            this.btnReNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReNew.ImageOptions.Image")));
            this.btnReNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReNew.ImageOptions.LargeImage")));
            this.btnReNew.Name = "btnReNew";
            toolTipItem1.Text = "تجديد";
            superToolTip2.Items.Add(toolTipItem1);
            this.btnReNew.SuperTip = superToolTip2;
            this.btnReNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReNew_ItemClick);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Caption = "Exel";
            this.btnExportToExcel.Id = 3;
            this.btnExportToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.ImageOptions.Image")));
            this.btnExportToExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.ImageOptions.LargeImage")));
            this.btnExportToExcel.Name = "btnExportToExcel";
            toolTipItem2.Text = "تصدير إلى إكسل";
            superToolTip3.Items.Add(toolTipItem2);
            this.btnExportToExcel.SuperTip = superToolTip3;
            this.btnExportToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToExcel_ItemClick);
            // 
            // btnLockYear
            // 
            this.btnLockYear.Caption = "LockYear";
            this.btnLockYear.Id = 2;
            this.btnLockYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLockYear.ImageOptions.Image")));
            this.btnLockYear.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLockYear.ImageOptions.LargeImage")));
            this.btnLockYear.Name = "btnLockYear";
            toolTipItem3.Text = "قفل السنة الحالية";
            superToolTip4.Items.Add(toolTipItem3);
            this.btnLockYear.SuperTip = superToolTip4;
            this.btnLockYear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLockYear_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "backup";
            this.btnBackup.Id = 4;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.LargeImage")));
            this.btnBackup.Name = "btnBackup";
            toolTipItem4.Text = "إنشاء نسخة احتياطية";
            superToolTip5.Items.Add(toolTipItem4);
            this.btnBackup.SuperTip = superToolTip5;
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1237, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1237, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 574);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1237, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 574);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1237, 574);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1213, 550);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.CaseNum,
            this.Person1,
            this.Person2,
            this.Lawyer,
            this.Room,
            this.Date,
            this.Type,
            this.CaseDecesionNum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // CaseNum
            // 
            this.CaseNum.Caption = "رقم الأساس";
            this.CaseNum.FieldName = "CaseNum";
            this.CaseNum.Name = "CaseNum";
            this.CaseNum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CaseNum", "{0}")});
            this.CaseNum.Visible = true;
            this.CaseNum.VisibleIndex = 0;
            // 
            // Person1
            // 
            this.Person1.Caption = "المدعى";
            this.Person1.FieldName = "Person1";
            this.Person1.Name = "Person1";
            this.Person1.Visible = true;
            this.Person1.VisibleIndex = 2;
            // 
            // Person2
            // 
            this.Person2.Caption = "المدعى عليه";
            this.Person2.FieldName = "Person2";
            this.Person2.Name = "Person2";
            this.Person2.Visible = true;
            this.Person2.VisibleIndex = 3;
            // 
            // Lawyer
            // 
            this.Lawyer.Caption = "الوكيل";
            this.Lawyer.FieldName = "Lawyer";
            this.Lawyer.Name = "Lawyer";
            this.Lawyer.Visible = true;
            this.Lawyer.VisibleIndex = 4;
            // 
            // Room
            // 
            this.Room.Caption = "الغرفة";
            this.Room.FieldName = "Room";
            this.Room.Name = "Room";
            this.Room.Visible = true;
            this.Room.VisibleIndex = 5;
            // 
            // Date
            // 
            this.Date.Caption = "التاريخ";
            this.Date.FieldName = "Date";
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 7;
            // 
            // Type
            // 
            this.Type.Caption = "نوع الدعوى";
            this.Type.FieldName = "Type";
            this.Type.Name = "Type";
            this.Type.Visible = true;
            this.Type.VisibleIndex = 6;
            // 
            // CaseDecesionNum
            // 
            this.CaseDecesionNum.Caption = "رقم القرار";
            this.CaseDecesionNum.FieldName = "CaseDecesionNum";
            this.CaseDecesionNum.Name = "CaseDecesionNum";
            this.CaseDecesionNum.Visible = true;
            this.CaseDecesionNum.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1237, 574);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1217, 554);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmCaseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 600);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmCaseRecord";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل الدعاوي";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCaseRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn CaseNum;
        private DevExpress.XtraGrid.Columns.GridColumn Person1;
        private DevExpress.XtraGrid.Columns.GridColumn Person2;
        private DevExpress.XtraGrid.Columns.GridColumn Lawyer;
        private DevExpress.XtraGrid.Columns.GridColumn Room;
        private DevExpress.XtraGrid.Columns.GridColumn Type;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnReNew;
        private DevExpress.XtraBars.BarButtonItem btnLockYear;
        private DevExpress.XtraBars.BarButtonItem btnExportToExcel;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraGrid.Columns.GridColumn CaseDecesionNum;
    }
}