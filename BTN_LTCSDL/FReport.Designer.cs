
namespace BTN_LTCSDL
{
    partial class FReport
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
            this.FReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FReportViewer
            // 
            this.FReportViewer.ActiveViewIndex = -1;
            this.FReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.FReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FReportViewer.Location = new System.Drawing.Point(0, 0);
            this.FReportViewer.Name = "FReportViewer";
            this.FReportViewer.Size = new System.Drawing.Size(1226, 653);
            this.FReportViewer.TabIndex = 0;
            // 
            // FReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 653);
            this.Controls.Add(this.FReportViewer);
            this.Name = "FReport";
            this.Text = "FReport";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer FReportViewer;
    }
}