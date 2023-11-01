
namespace SMSystem.Gui.MaterailsGui
{
    partial class MaterailsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            flowLayoutPanelNavBar = new System.Windows.Forms.FlowLayoutPanel();
            buttonAdd = new System.Windows.Forms.Button();
            buttonEdit = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            buttonIncome = new System.Windows.Forms.Button();
            buttonOucome = new System.Windows.Forms.Button();
            buttonPrint = new System.Windows.Forms.Button();
            panelSearchBar = new System.Windows.Forms.Panel();
            buttonSearch = new System.Windows.Forms.Button();
            textBoxSearch = new System.Windows.Forms.TextBox();
            dataGridView = new System.Windows.Forms.DataGridView();
            flowLayoutPanelNavBar.SuspendLayout();
            panelSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanelNavBar.Controls.Add(buttonAdd);
            flowLayoutPanelNavBar.Controls.Add(buttonEdit);
            flowLayoutPanelNavBar.Controls.Add(buttonDelete);
            flowLayoutPanelNavBar.Controls.Add(buttonRefresh);
            flowLayoutPanelNavBar.Controls.Add(buttonIncome);
            flowLayoutPanelNavBar.Controls.Add(buttonOucome);
            flowLayoutPanelNavBar.Controls.Add(buttonPrint);
            flowLayoutPanelNavBar.Controls.Add(panelSearchBar);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(1062, 75);
            flowLayoutPanelNavBar.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = Properties.Resources.add_32px;
            buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAdd.Location = new System.Drawing.Point(911, 11);
            buttonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(120, 54);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = " اضافة مادة";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Image = Properties.Resources.edit_32px;
            buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.Location = new System.Drawing.Point(783, 11);
            buttonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new System.Drawing.Size(120, 54);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "  تعديل";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = Properties.Resources.Delete_32px;
            buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDelete.Location = new System.Drawing.Point(655, 11);
            buttonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(120, 54);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "  حذف";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Image = Properties.Resources.refresh_32px;
            buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonRefresh.Location = new System.Drawing.Point(527, 11);
            buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(120, 54);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "  تحديث";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonIncome
            // 
            buttonIncome.Image = Properties.Resources.icons8_internal_32px_1;
            buttonIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonIncome.Location = new System.Drawing.Point(399, 11);
            buttonIncome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonIncome.Name = "buttonIncome";
            buttonIncome.Size = new System.Drawing.Size(120, 54);
            buttonIncome.TabIndex = 5;
            buttonIncome.Text = "  ادخال";
            buttonIncome.UseVisualStyleBackColor = true;
            buttonIncome.Click += buttonIncome_Click;
            // 
            // buttonOucome
            // 
            buttonOucome.Image = Properties.Resources.icons8_external_32px;
            buttonOucome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOucome.Location = new System.Drawing.Point(271, 11);
            buttonOucome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonOucome.Name = "buttonOucome";
            buttonOucome.Size = new System.Drawing.Size(120, 54);
            buttonOucome.TabIndex = 6;
            buttonOucome.Text = "  إخراج";
            buttonOucome.UseVisualStyleBackColor = true;
            buttonOucome.Click += buttonOucome_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Image = Properties.Resources.print_32px;
            buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonPrint.Location = new System.Drawing.Point(143, 11);
            buttonPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new System.Drawing.Size(120, 54);
            buttonPrint.TabIndex = 4;
            buttonPrint.Text = "  طباعة";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // panelSearchBar
            // 
            panelSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            panelSearchBar.Controls.Add(buttonSearch);
            panelSearchBar.Controls.Add(textBoxSearch);
            panelSearchBar.Location = new System.Drawing.Point(648, 74);
            panelSearchBar.Name = "panelSearchBar";
            panelSearchBar.Size = new System.Drawing.Size(384, 44);
            panelSearchBar.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            buttonSearch.Image = Properties.Resources.search_32px;
            buttonSearch.Location = new System.Drawing.Point(310, 0);
            buttonSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(74, 44);
            buttonSearch.TabIndex = 6;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxSearch.Location = new System.Drawing.Point(0, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(313, 26);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new System.Drawing.Point(0, 75);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = "لا بيانات";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new System.Drawing.Size(1062, 523);
            dataGridView.TabIndex = 2;
            dataGridView.DoubleClick += dataGridView_DoubleClick;
            // 
            // MaterailsUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(dataGridView);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "MaterailsUserControl";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1062, 598);
            flowLayoutPanelNavBar.ResumeLayout(false);
            panelSearchBar.ResumeLayout(false);
            panelSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonOucome;
    }
}
