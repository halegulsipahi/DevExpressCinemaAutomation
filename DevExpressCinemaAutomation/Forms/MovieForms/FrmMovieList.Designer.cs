namespace DevExpressCinemaAutomation
{
    partial class FrmMovieList
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
            this.gridMovies = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMovies
            // 
            this.gridMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMovies.Location = new System.Drawing.Point(0, 0);
            this.gridMovies.MainView = this.gridView1;
            this.gridMovies.Name = "gridMovies";
            this.gridMovies.Size = new System.Drawing.Size(800, 450);
            this.gridMovies.TabIndex = 0;
            this.gridMovies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
//            this.gridMovies.Click += new System.EventHandler(this.gridMovies_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridMovies;
            this.gridView1.Name = "gridView1";
            // 
            // FrmMovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridMovies);
            this.Name = "FrmMovieList";
            this.Text = "List of Movies";
            this.Load += new System.EventHandler(this.FrmFilmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMovies;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}