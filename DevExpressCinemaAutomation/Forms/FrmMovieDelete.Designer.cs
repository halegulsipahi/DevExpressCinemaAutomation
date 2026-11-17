namespace DevExpressCinemaAutomation.Forms
{
    partial class FrmMovieDelete
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
            this.gridMovies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMovies
            // 
            this.gridMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMovies.Location = new System.Drawing.Point(0, 0);
            this.gridMovies.Name = "gridMovies";
            this.gridMovies.ReadOnly = true;
            this.gridMovies.Size = new System.Drawing.Size(800, 450);
            this.gridMovies.TabIndex = 0;
            this.gridMovies.DoubleClick += new System.EventHandler(this.gridMovies_DoubleClick);
            // 
            // FrmMovieDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridMovies);
            this.Name = "FrmMovieDelete";
            this.Text = "Delete the Movie";
            this.Load += new System.EventHandler(this.FrmMovieDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMovies;
    }
}