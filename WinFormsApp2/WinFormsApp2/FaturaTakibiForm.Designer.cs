namespace WinFormsApp2
{
    partial class FaturaTakibiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvFaturaTakibi;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitle = new Label();
            dgvFaturaTakibi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFaturaTakibi).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(708, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fatura Takibi";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvFaturaTakibi
            // 
            dgvFaturaTakibi.AllowUserToAddRows = false;
            dgvFaturaTakibi.AllowUserToDeleteRows = false;
            dgvFaturaTakibi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvFaturaTakibi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFaturaTakibi.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvFaturaTakibi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFaturaTakibi.ColumnHeadersHeight = 38;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvFaturaTakibi.DefaultCellStyle = dataGridViewCellStyle4;
            dgvFaturaTakibi.Location = new Point(30, 65);
            dgvFaturaTakibi.Name = "dgvFaturaTakibi";
            dgvFaturaTakibi.ReadOnly = true;
            dgvFaturaTakibi.RowHeadersVisible = false;
            dgvFaturaTakibi.RowHeadersWidth = 51;
            dgvFaturaTakibi.RowTemplate.Height = 30;
            dgvFaturaTakibi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFaturaTakibi.Size = new Size(647, 261);
            dgvFaturaTakibi.TabIndex = 1;
            // 
            // FaturaTakibiForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(707, 391);
            Controls.Add(lblTitle);
            Controls.Add(dgvFaturaTakibi);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FaturaTakibiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatura Takibi";
            ((System.ComponentModel.ISupportInitialize)dgvFaturaTakibi).EndInit();
            ResumeLayout(false);
        }
    }
}