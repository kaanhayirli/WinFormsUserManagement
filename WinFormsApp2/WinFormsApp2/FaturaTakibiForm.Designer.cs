namespace WinFormsApp2
{
    partial class FaturaTakibiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvFaturaTakibi;
        private System.Windows.Forms.Button btnYenile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvFaturaTakibi = new DataGridView();
            btnYenile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFaturaTakibi).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.WhiteSmoke;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(672, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fatura Takibi";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvFaturaTakibi
            // 
            dgvFaturaTakibi.AllowUserToAddRows = false;
            dgvFaturaTakibi.AllowUserToDeleteRows = false;
            dgvFaturaTakibi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFaturaTakibi.ColumnHeadersHeight = 29;
            dgvFaturaTakibi.Location = new Point(10, 50);
            dgvFaturaTakibi.Name = "dgvFaturaTakibi";
            dgvFaturaTakibi.ReadOnly = true;
            dgvFaturaTakibi.RowHeadersWidth = 51;
            dgvFaturaTakibi.Size = new Size(650, 280);
            dgvFaturaTakibi.TabIndex = 0;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(0, 0);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(75, 23);
            btnYenile.TabIndex = 1;
            // 
            // FaturaTakibiForm
            // 
            ClientSize = new Size(672, 381);
            Controls.Add(lblTitle);
            Controls.Add(dgvFaturaTakibi);
            Controls.Add(btnYenile);
            Name = "FaturaTakibiForm";
            Text = "Fatura Takibi";
            ((System.ComponentModel.ISupportInitialize)dgvFaturaTakibi).EndInit();
            ResumeLayout(false);
        }
    }
}