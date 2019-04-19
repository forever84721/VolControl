namespace VolControl
{
    partial class VolControl
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolControl));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_Increase = new System.Windows.Forms.TextBox();
            this.TB_Decrease = new System.Windows.Forms.TextBox();
            this.TB_Mute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Save = new System.Windows.Forms.Button();
            this.NotifyIconMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "VolControl";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            this.NotifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDown);
            // 
            // NotifyIconMenuStrip
            // 
            this.NotifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.NotifyIconMenuStrip.Name = "NotifyIconMenuStrip";
            this.NotifyIconMenuStrip.Size = new System.Drawing.Size(106, 26);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // TB_Increase
            // 
            this.TB_Increase.Location = new System.Drawing.Point(123, 10);
            this.TB_Increase.Name = "TB_Increase";
            this.TB_Increase.ReadOnly = true;
            this.TB_Increase.Size = new System.Drawing.Size(122, 29);
            this.TB_Increase.TabIndex = 3;
            this.TB_Increase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Increase_KeyDown);
            // 
            // TB_Decrease
            // 
            this.TB_Decrease.Location = new System.Drawing.Point(123, 80);
            this.TB_Decrease.Name = "TB_Decrease";
            this.TB_Decrease.ReadOnly = true;
            this.TB_Decrease.Size = new System.Drawing.Size(122, 29);
            this.TB_Decrease.TabIndex = 4;
            this.TB_Decrease.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Decrease_KeyDown);
            // 
            // TB_Mute
            // 
            this.TB_Mute.Location = new System.Drawing.Point(123, 45);
            this.TB_Mute.Name = "TB_Mute";
            this.TB_Mute.ReadOnly = true;
            this.TB_Mute.Size = new System.Drawing.Size(122, 29);
            this.TB_Mute.TabIndex = 5;
            this.TB_Mute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Mute_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Increase(+)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Decrease(-)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mute";
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(27, 115);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(218, 44);
            this.BT_Save.TabIndex = 8;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // VolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 170);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Mute);
            this.Controls.Add(this.TB_Decrease);
            this.Controls.Add(this.TB_Increase);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "VolControl";
            this.Text = "VolControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VolControl_FormClosing);
            this.Load += new System.EventHandler(this.VolControl_Load);
            this.Shown += new System.EventHandler(this.VolControl_Shown);
            this.SizeChanged += new System.EventHandler(this.VolControl_SizeChanged);
            this.NotifyIconMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.TextBox TB_Increase;
        private System.Windows.Forms.TextBox TB_Decrease;
        private System.Windows.Forms.TextBox TB_Mute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_Save;
    }
}

