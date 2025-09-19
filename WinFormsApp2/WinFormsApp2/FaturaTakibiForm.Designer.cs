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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            lblTitle.Size = new Size(631, 55);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvFaturaTakibi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFaturaTakibi.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFaturaTakibi.DefaultCellStyle = dataGridViewCellStyle2;
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
            AutoScroll = true;
            AutoSize = true;
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