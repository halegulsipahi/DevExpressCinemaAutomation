namespace DevExpressCinemaAutomation.Forms.CashRegisterForm
{
    partial class FrmReports
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
            this.grdReports = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblTotalOrders = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblTotalSeatsSold = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lblTotalRevenue = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.lblTodayRevenue = new DevExpress.XtraEditors.LabelControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.lblTodaySeatsSold = new DevExpress.XtraEditors.LabelControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.lblTodayOrders = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdReports
            // 
            this.grdReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReports.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdReports.Location = new System.Drawing.Point(2, 23);
            this.grdReports.MainView = this.gridView1;
            this.grdReports.Margin = new System.Windows.Forms.Padding(4);
            this.grdReports.Name = "grdReports";
            this.grdReports.Size = new System.Drawing.Size(962, 315);
            this.grdReports.TabIndex = 0;
            this.grdReports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.grdReports;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grdReports);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 227);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(966, 340);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Cash Register History";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblTotalOrders);
            this.groupControl2.Location = new System.Drawing.Point(33, 13);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(142, 133);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Total Orders";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalOrders.Appearance.Options.UseFont = true;
            this.lblTotalOrders.Appearance.Options.UseTextOptions = true;
            this.lblTotalOrders.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTotalOrders.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTotalOrders.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalOrders.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblTotalOrders.Location = new System.Drawing.Point(5, 57);
            this.lblTotalOrders.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(131, 34);
            this.lblTotalOrders.TabIndex = 0;
            this.lblTotalOrders.Text = "0";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lblTotalSeatsSold);
            this.groupControl3.Location = new System.Drawing.Point(183, 13);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(142, 133);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Total Seats Sold";
            // 
            // lblTotalSeatsSold
            // 
            this.lblTotalSeatsSold.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalSeatsSold.Appearance.Options.UseFont = true;
            this.lblTotalSeatsSold.Appearance.Options.UseTextOptions = true;
            this.lblTotalSeatsSold.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTotalSeatsSold.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTotalSeatsSold.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalSeatsSold.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblTotalSeatsSold.Location = new System.Drawing.Point(6, 57);
            this.lblTotalSeatsSold.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotalSeatsSold.Name = "lblTotalSeatsSold";
            this.lblTotalSeatsSold.Size = new System.Drawing.Size(131, 34);
            this.lblTotalSeatsSold.TabIndex = 0;
            this.lblTotalSeatsSold.Text = "0";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lblTotalRevenue);
            this.groupControl4.Location = new System.Drawing.Point(333, 13);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(142, 133);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "Total Revenue";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalRevenue.Appearance.Options.UseFont = true;
            this.lblTotalRevenue.Appearance.Options.UseTextOptions = true;
            this.lblTotalRevenue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTotalRevenue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalRevenue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblTotalRevenue.Location = new System.Drawing.Point(6, 57);
            this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(130, 34);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "0";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.lblTodayRevenue);
            this.groupControl5.Location = new System.Drawing.Point(783, 13);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(142, 133);
            this.groupControl5.TabIndex = 7;
            this.groupControl5.Text = "Today\'s  Revenue";
            // 
            // lblTodayRevenue
            // 
            this.lblTodayRevenue.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTodayRevenue.Appearance.Options.UseFont = true;
            this.lblTodayRevenue.Appearance.Options.UseTextOptions = true;
            this.lblTodayRevenue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTodayRevenue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTodayRevenue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblTodayRevenue.Location = new System.Drawing.Point(6, 57);
            this.lblTodayRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.lblTodayRevenue.Name = "lblTodayRevenue";
            this.lblTodayRevenue.Size = new System.Drawing.Size(130, 34);
            this.lblTodayRevenue.TabIndex = 0;
            this.lblTodayRevenue.Text = "0";
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.lblTodaySeatsSold);
            this.groupControl6.Location = new System.Drawing.Point(633, 13);
            this.groupControl6.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(142, 133);
            this.groupControl6.TabIndex = 6;
            this.groupControl6.Text = "Today\'s  Seats Sold";
            // 
            // lblTodaySeatsSold
            // 
            this.lblTodaySeatsSold.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTodaySeatsSold.Appearance.Options.UseFont = true;
            this.lblTodaySeatsSold.Appearance.Options.UseTextOptions = true;
            this.lblTodaySeatsSold.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTodaySeatsSold.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTodaySeatsSold.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblTodaySeatsSold.Location = new System.Drawing.Point(6, 57);
            this.lblTodaySeatsSold.Margin = new System.Windows.Forms.Padding(4);
            this.lblTodaySeatsSold.Name = "lblTodaySeatsSold";
            this.lblTodaySeatsSold.Size = new System.Drawing.Size(130, 34);
            this.lblTodaySeatsSold.TabIndex = 0;
            this.lblTodaySeatsSold.Text = "0";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.lblTodayOrders);
            this.groupControl7.Location = new System.Drawing.Point(483, 13);
            this.groupControl7.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(142, 133);
            this.groupControl7.TabIndex = 5;
            this.groupControl7.Text = "Today\'s Orders";
            // 
            // lblTodayOrders
            // 
            this.lblTodayOrders.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTodayOrders.Appearance.Options.UseFont = true;
            this.lblTodayOrders.Appearance.Options.UseTextOptions = true;
            this.lblTodayOrders.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTodayOrders.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTodayOrders.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblTodayOrders.Location = new System.Drawing.Point(6, 57);
            this.lblTodayOrders.Margin = new System.Windows.Forms.Padding(4);
            this.lblTodayOrders.Name = "lblTodayOrders";
            this.lblTodayOrders.Size = new System.Drawing.Size(130, 34);
            this.lblTodayOrders.TabIndex = 0;
            this.lblTodayOrders.Text = "0";
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 567);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReports";
            this.Text = "Cash Reports";
            this.Load += new System.EventHandler(this.FrmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdReports;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblTotalOrders;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblTotalSeatsSold;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl lblTotalRevenue;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl lblTodayRevenue;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.LabelControl lblTodaySeatsSold;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.LabelControl lblTodayOrders;
    }
}