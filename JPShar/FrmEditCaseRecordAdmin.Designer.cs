namespace JPShar
{
    partial class FrmEditCaseRecordAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditCaseRecordAdmin));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtCaseNum = new DevExpress.XtraEditors.TextEdit();
            this.txtPerson1 = new DevExpress.XtraEditors.TextEdit();
            this.txtPerson2 = new DevExpress.XtraEditors.TextEdit();
            this.txtLawyer = new DevExpress.XtraEditors.TextEdit();
            this.cmbType = new DevExpress.XtraEditors.LookUpEdit();
            this.numRoom = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaseNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLawyer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.txtCaseNum);
            this.layoutControl1.Controls.Add(this.txtPerson1);
            this.layoutControl1.Controls.Add(this.txtPerson2);
            this.layoutControl1.Controls.Add(this.txtLawyer);
            this.layoutControl1.Controls.Add(this.cmbType);
            this.layoutControl1.Controls.Add(this.numRoom);
            this.layoutControl1.Controls.Add(this.dtDate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(598, 343);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(300, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(286, 38);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 292);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(284, 38);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCaseNum
            // 
            this.txtCaseNum.Location = new System.Drawing.Point(12, 12);
            this.txtCaseNum.Name = "txtCaseNum";
            this.txtCaseNum.Size = new System.Drawing.Size(487, 36);
            this.txtCaseNum.StyleController = this.layoutControl1;
            this.txtCaseNum.TabIndex = 4;
            // 
            // txtPerson1
            // 
            this.txtPerson1.Location = new System.Drawing.Point(12, 52);
            this.txtPerson1.Name = "txtPerson1";
            this.txtPerson1.Size = new System.Drawing.Size(487, 36);
            this.txtPerson1.StyleController = this.layoutControl1;
            this.txtPerson1.TabIndex = 5;
            // 
            // txtPerson2
            // 
            this.txtPerson2.Location = new System.Drawing.Point(12, 92);
            this.txtPerson2.Name = "txtPerson2";
            this.txtPerson2.Size = new System.Drawing.Size(487, 36);
            this.txtPerson2.StyleController = this.layoutControl1;
            this.txtPerson2.TabIndex = 6;
            // 
            // txtLawyer
            // 
            this.txtLawyer.Location = new System.Drawing.Point(12, 132);
            this.txtLawyer.Name = "txtLawyer";
            this.txtLawyer.Size = new System.Drawing.Size(487, 36);
            this.txtLawyer.StyleController = this.layoutControl1;
            this.txtLawyer.TabIndex = 7;
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(12, 172);
            this.cmbType.Name = "cmbType";
            this.cmbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbType.Properties.NullText = "";
            this.cmbType.Properties.PopupSizeable = false;
            this.cmbType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbType.Size = new System.Drawing.Size(487, 36);
            this.cmbType.StyleController = this.layoutControl1;
            this.cmbType.TabIndex = 8;
            // 
            // numRoom
            // 
            this.numRoom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoom.Location = new System.Drawing.Point(12, 212);
            this.numRoom.Name = "numRoom";
            this.numRoom.Properties.Appearance.Options.UseTextOptions = true;
            this.numRoom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.numRoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numRoom.Properties.IsFloatValue = false;
            this.numRoom.Properties.MaskSettings.Set("mask", "N00");
            this.numRoom.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRoom.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoom.Size = new System.Drawing.Size(487, 36);
            this.numRoom.StyleController = this.layoutControl1;
            this.numRoom.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem8,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem9});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(598, 343);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCaseNum;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem1.CustomizationFormText = "رقم الأساس";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(578, 40);
            this.layoutControlItem1.Text = "رقم الأساس";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(83, 30);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPerson1;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem2.CustomizationFormText = "المدعى";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(578, 40);
            this.layoutControlItem2.Text = "المدعى";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(83, 30);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPerson2;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem3.CustomizationFormText = "المدعى عليه";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(578, 40);
            this.layoutControlItem3.Text = "المدعى عليه";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(83, 30);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtLawyer;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem4.CustomizationFormText = "الوكيل";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(578, 40);
            this.layoutControlItem4.Text = "الوكيل";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(83, 30);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cmbType;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem5.CustomizationFormText = "نوع الدعوى";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(578, 40);
            this.layoutControlItem5.Text = "نوع الدعوى";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(83, 30);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.numRoom;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem8.CustomizationFormText = "الغرفة";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 200);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(578, 40);
            this.layoutControlItem8.Text = "الغرفة";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(83, 30);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnSave;
            this.layoutControlItem6.Location = new System.Drawing.Point(288, 280);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(290, 43);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnClose;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 280);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(288, 43);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // dtDate
            // 
            this.dtDate.EditValue = null;
            this.dtDate.Location = new System.Drawing.Point(12, 252);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Size = new System.Drawing.Size(487, 36);
            this.dtDate.StyleController = this.layoutControl1;
            this.dtDate.TabIndex = 14;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.dtDate;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(578, 40);
            this.layoutControlItem9.Text = "التاريخ";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(83, 30);
            // 
            // FrmEditCaseRecordAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 343);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmEditCaseRecordAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEditCaseRecordAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCaseNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLawyer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtCaseNum;
        private DevExpress.XtraEditors.TextEdit txtPerson1;
        private DevExpress.XtraEditors.TextEdit txtPerson2;
        private DevExpress.XtraEditors.TextEdit txtLawyer;
        private DevExpress.XtraEditors.LookUpEdit cmbType;
        private DevExpress.XtraEditors.SpinEdit numRoom;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.DateEdit dtDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}