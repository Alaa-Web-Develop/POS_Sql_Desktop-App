
namespace SMSystem.Gui.Home
{
    partial class HomeUserControl
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
            components = new System.ComponentModel.Container();
            buttonAddMaterial = new System.Windows.Forms.Button();
            buttonAddIncome = new System.Windows.Forms.Button();
            buttonAddOutCome = new System.Windows.Forms.Button();
            labelWellcom = new System.Windows.Forms.Label();
            labelDate = new System.Windows.Forms.Label();
            labelTime = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            labelCompanyName = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            FlowLayoutPanelNotification = new System.Windows.Forms.FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddMaterial
            // 
            buttonAddMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonAddMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddMaterial.Image = Properties.Resources.icons8_box_96px_1;
            buttonAddMaterial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonAddMaterial.Location = new System.Drawing.Point(415, 190);
            buttonAddMaterial.Margin = new System.Windows.Forms.Padding(4);
            buttonAddMaterial.Name = "buttonAddMaterial";
            buttonAddMaterial.Size = new System.Drawing.Size(148, 106);
            buttonAddMaterial.TabIndex = 5;
            buttonAddMaterial.Text = "اضافة مادة";
            buttonAddMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonAddMaterial.UseVisualStyleBackColor = true;
            buttonAddMaterial.Click += buttonAddMaterial_Click;
            // 
            // buttonAddIncome
            // 
            buttonAddIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonAddIncome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddIncome.Image = Properties.Resources.icons8_internal_96px_1;
            buttonAddIncome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonAddIncome.Location = new System.Drawing.Point(250, 190);
            buttonAddIncome.Margin = new System.Windows.Forms.Padding(4);
            buttonAddIncome.Name = "buttonAddIncome";
            buttonAddIncome.Size = new System.Drawing.Size(144, 106);
            buttonAddIncome.TabIndex = 6;
            buttonAddIncome.Text = "ادخال مادة";
            buttonAddIncome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonAddIncome.UseVisualStyleBackColor = true;
            buttonAddIncome.Click += buttonAddIncome_Click;
            // 
            // buttonAddOutCome
            // 
            buttonAddOutCome.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonAddOutCome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonAddOutCome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddOutCome.Image = Properties.Resources.icons8_external_80px;
            buttonAddOutCome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonAddOutCome.Location = new System.Drawing.Point(86, 190);
            buttonAddOutCome.Margin = new System.Windows.Forms.Padding(4);
            buttonAddOutCome.Name = "buttonAddOutCome";
            buttonAddOutCome.Size = new System.Drawing.Size(143, 106);
            buttonAddOutCome.TabIndex = 7;
            buttonAddOutCome.Text = "قائمة اخراج";
            buttonAddOutCome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonAddOutCome.UseVisualStyleBackColor = true;
            buttonAddOutCome.Click += buttonAddOutCome_Click;
            // 
            // labelWellcom
            // 
            labelWellcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelWellcom.Location = new System.Drawing.Point(15, 11);
            labelWellcom.Name = "labelWellcom";
            labelWellcom.Size = new System.Drawing.Size(305, 136);
            labelWellcom.TabIndex = 8;
            labelWellcom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDate
            // 
            labelDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDate.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            labelDate.Location = new System.Drawing.Point(3, 380);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(367, 41);
            labelDate.TabIndex = 8;
            labelDate.Text = "000000000";
            labelDate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelTime
            // 
            labelTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTime.ForeColor = System.Drawing.Color.DarkSlateGray;
            labelTime.Location = new System.Drawing.Point(0, 411);
            labelTime.Name = "labelTime";
            labelTime.Size = new System.Drawing.Size(311, 33);
            labelTime.TabIndex = 8;
            labelTime.Text = "000000000";
            labelTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(labelCompanyName);
            panel1.Location = new System.Drawing.Point(512, 352);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(424, 94);
            panel1.TabIndex = 9;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCompanyName.Location = new System.Drawing.Point(3, 20);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(285, 71);
            labelCompanyName.TabIndex = 8;
            labelCompanyName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // FlowLayoutPanelNotification
            // 
            FlowLayoutPanelNotification.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            FlowLayoutPanelNotification.AutoScroll = true;
            FlowLayoutPanelNotification.BackColor = System.Drawing.Color.White;
            FlowLayoutPanelNotification.Location = new System.Drawing.Point(347, 11);
            FlowLayoutPanelNotification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            FlowLayoutPanelNotification.Name = "FlowLayoutPanelNotification";
            FlowLayoutPanelNotification.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            FlowLayoutPanelNotification.Size = new System.Drawing.Size(587, 156);
            FlowLayoutPanelNotification.TabIndex = 10;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            Controls.Add(FlowLayoutPanelNotification);
            Controls.Add(labelWellcom);
            Controls.Add(labelDate);
            Controls.Add(panel1);
            Controls.Add(labelTime);
            Controls.Add(buttonAddMaterial);
            Controls.Add(buttonAddIncome);
            Controls.Add(buttonAddOutCome);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "HomeUserControl";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(939, 448);
            Load += HomeUserControl_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Button buttonAddIncome;
        private System.Windows.Forms.Button buttonAddOutCome;
        private System.Windows.Forms.Label labelWellcom;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelNotification;
    }
}
