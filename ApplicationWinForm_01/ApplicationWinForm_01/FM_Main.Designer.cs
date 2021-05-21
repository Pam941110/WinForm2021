
namespace ApplicationWinForm_01
{
    partial class FM_Main
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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.M_SYSTEM = new System.Windows.Forms.ToolStripMenuItem();
            this.MDI_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.MDI_TEST2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.stb_Search = new System.Windows.Forms.ToolStripButton();
            this.stb_Insert = new System.Windows.Forms.ToolStripButton();
            this.stb_Delete = new System.Windows.Forms.ToolStripButton();
            this.stb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stb_Close = new System.Windows.Forms.ToolStripButton();
            this.stb_Exit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tss_Space = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_NowDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_SYSTEM});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1116, 28);
            this.MenuStrip.TabIndex = 0;
            // 
            // M_SYSTEM
            // 
            this.M_SYSTEM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MDI_Test,
            this.MDI_TEST2});
            this.M_SYSTEM.Name = "M_SYSTEM";
            this.M_SYSTEM.Size = new System.Drawing.Size(98, 24);
            this.M_SYSTEM.Text = "시스템관리";
            // 
            // MDI_Test
            // 
            this.MDI_Test.Name = "MDI_Test";
            this.MDI_Test.Size = new System.Drawing.Size(228, 26);
            this.MDI_Test.Text = "테스트 화면";
            // 
            // MDI_TEST2
            // 
            this.MDI_TEST2.Name = "MDI_TEST2";
            this.MDI_TEST2.Size = new System.Drawing.Size(228, 26);
            this.MDI_TEST2.Text = "toolStripMenuItem1";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stb_Search,
            this.stb_Insert,
            this.stb_Delete,
            this.stb_Save,
            this.toolStripSeparator1,
            this.stb_Close,
            this.stb_Exit});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1116, 83);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // stb_Search
            // 
            this.stb_Search.Image = global::ApplicationWinForm_01.Properties.Resources.BtnSearch;
            this.stb_Search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stb_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stb_Search.Name = "stb_Search";
            this.stb_Search.Size = new System.Drawing.Size(54, 80);
            this.stb_Search.Text = "조회";
            this.stb_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stb_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stb_Insert
            // 
            this.stb_Insert.Image = global::ApplicationWinForm_01.Properties.Resources.BtnAdd;
            this.stb_Insert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stb_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stb_Insert.Name = "stb_Insert";
            this.stb_Insert.Size = new System.Drawing.Size(54, 80);
            this.stb_Insert.Text = "추가";
            this.stb_Insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stb_Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stb_Delete
            // 
            this.stb_Delete.Image = global::ApplicationWinForm_01.Properties.Resources.BtnDelete;
            this.stb_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stb_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stb_Delete.Name = "stb_Delete";
            this.stb_Delete.Size = new System.Drawing.Size(54, 80);
            this.stb_Delete.Text = "삭제";
            this.stb_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stb_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stb_Save
            // 
            this.stb_Save.Image = global::ApplicationWinForm_01.Properties.Resources.BtnSaveB;
            this.stb_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stb_Save.Name = "stb_Save";
            this.stb_Save.Size = new System.Drawing.Size(54, 80);
            this.stb_Save.Text = "저장";
            this.stb_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stb_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 83);
            // 
            // stb_Close
            // 
            this.stb_Close.Image = global::ApplicationWinForm_01.Properties.Resources.BtnClose;
            this.stb_Close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stb_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stb_Close.Name = "stb_Close";
            this.stb_Close.Size = new System.Drawing.Size(54, 80);
            this.stb_Close.Text = "닫기";
            this.stb_Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stb_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stb_Exit
            // 
            this.stb_Exit.Image = global::ApplicationWinForm_01.Properties.Resources.BtcExit;
            this.stb_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stb_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stb_Exit.Name = "stb_Exit";
            this.stb_Exit.Size = new System.Drawing.Size(54, 80);
            this.stb_Exit.Text = "종료";
            this.stb_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stb_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stb_Exit.Click += new System.EventHandler(this.stb_Exit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_Space,
            this.tss_UserName,
            this.tss_NowDate});
            this.statusStrip.Location = new System.Drawing.Point(0, 481);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1116, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tss_Space
            // 
            this.tss_Space.AutoSize = false;
            this.tss_Space.Name = "tss_Space";
            this.tss_Space.Size = new System.Drawing.Size(501, 20);
            this.tss_Space.Spring = true;
            // 
            // tss_UserName
            // 
            this.tss_UserName.AutoSize = false;
            this.tss_UserName.Name = "tss_UserName";
            this.tss_UserName.Size = new System.Drawing.Size(300, 20);
            this.tss_UserName.Text = "toolStripStatusLabel2";
            // 
            // tss_NowDate
            // 
            this.tss_NowDate.AutoSize = false;
            this.tss_NowDate.Name = "tss_NowDate";
            this.tss_NowDate.Size = new System.Drawing.Size(300, 20);
            this.tss_NowDate.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 507);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FM_Main";
            this.Text = "App_Dev_Ver1.0";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem M_SYSTEM;
        private System.Windows.Forms.ToolStripMenuItem MDI_Test;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton stb_Search;
        private System.Windows.Forms.ToolStripButton stb_Insert;
        private System.Windows.Forms.ToolStripButton stb_Delete;
        private System.Windows.Forms.ToolStripButton stb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton stb_Close;
        private System.Windows.Forms.ToolStripButton stb_Exit;
        private System.Windows.Forms.ToolStripStatusLabel tss_Space;
        private System.Windows.Forms.ToolStripStatusLabel tss_UserName;
        private System.Windows.Forms.ToolStripStatusLabel tss_NowDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem MDI_TEST2;
    }
}