namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFont = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMakeItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMakeBold = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMakeUnderlined = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIncreaseFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDecreaseFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.btnMakeItalic,
            this.btnMakeBold,
            this.btnMakeUnderlined,
            this.btnIncreaseFontSize,
            this.btnDecreaseFontSize});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectTextFile,
            this.btnSaveTextFile,
            this.btnSaveAs});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 27);
            this.toolStripMenuItem1.Text = "File";
            // 
            // btnSelectTextFile
            // 
            this.btnSelectTextFile.Name = "btnSelectTextFile";
            this.btnSelectTextFile.Size = new System.Drawing.Size(224, 28);
            this.btnSelectTextFile.Text = "Open";
            this.btnSelectTextFile.Click += new System.EventHandler(this.btnSelectTextFile_Click);
            // 
            // btnSaveTextFile
            // 
            this.btnSaveTextFile.Enabled = false;
            this.btnSaveTextFile.Name = "btnSaveTextFile";
            this.btnSaveTextFile.Size = new System.Drawing.Size(224, 28);
            this.btnSaveTextFile.Text = "Save";
            this.btnSaveTextFile.Click += new System.EventHandler(this.btnSaveTextFile_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(224, 28);
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWordWrap,
            this.btnFont});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // btnWordWrap
            // 
            this.btnWordWrap.Checked = true;
            this.btnWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnWordWrap.Name = "btnWordWrap";
            this.btnWordWrap.Size = new System.Drawing.Size(224, 28);
            this.btnWordWrap.Text = "Word wrap";
            this.btnWordWrap.Click += new System.EventHandler(this.btnWordWrap_Click);
            // 
            // btnFont
            // 
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(224, 28);
            this.btnFont.Text = "Font";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnMakeItalic
            // 
            this.btnMakeItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMakeItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeItalic.Image")));
            this.btnMakeItalic.Name = "btnMakeItalic";
            this.btnMakeItalic.Size = new System.Drawing.Size(34, 27);
            this.btnMakeItalic.Click += new System.EventHandler(this.btnMakeItalic_Click);
            // 
            // btnMakeBold
            // 
            this.btnMakeBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMakeBold.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeBold.Image")));
            this.btnMakeBold.Name = "btnMakeBold";
            this.btnMakeBold.Size = new System.Drawing.Size(34, 27);
            this.btnMakeBold.Click += new System.EventHandler(this.btnMakeBold_Click);
            // 
            // btnMakeUnderlined
            // 
            this.btnMakeUnderlined.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMakeUnderlined.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeUnderlined.Image")));
            this.btnMakeUnderlined.Name = "btnMakeUnderlined";
            this.btnMakeUnderlined.Size = new System.Drawing.Size(34, 27);
            this.btnMakeUnderlined.Click += new System.EventHandler(this.btnMakeUnderlined_Click);
            // 
            // btnIncreaseFontSize
            // 
            this.btnIncreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncreaseFontSize.Image = ((System.Drawing.Image)(resources.GetObject("btnIncreaseFontSize.Image")));
            this.btnIncreaseFontSize.Name = "btnIncreaseFontSize";
            this.btnIncreaseFontSize.Size = new System.Drawing.Size(34, 27);
            this.btnIncreaseFontSize.Click += new System.EventHandler(this.btnIncreaseFontSize_Click);
            // 
            // btnDecreaseFontSize
            // 
            this.btnDecreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDecreaseFontSize.Image = ((System.Drawing.Image)(resources.GetObject("btnDecreaseFontSize.Image")));
            this.btnDecreaseFontSize.Name = "btnDecreaseFontSize";
            this.btnDecreaseFontSize.Size = new System.Drawing.Size(34, 27);
            this.btnDecreaseFontSize.Click += new System.EventHandler(this.btnDecreaseFontSize_Click);
            // 
            // textBox
            // 
            this.textBox.AcceptsTab = true;
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.AutoWordSelection = true;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(0, 34);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(800, 416);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "";
            this.textBox.WordWrap = false;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // fontDialog
            // 
            this.fontDialog.ShowApply = true;
            this.fontDialog.Apply += new System.EventHandler(this.fontDialog_Apply);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar});
            this.statusBar.Location = new System.Drawing.Point(0, 426);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 24);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            this.statusBar.Visible = false;
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(0, 18);
            // 
            // statusBarTimer
            // 
            this.statusBarTimer.Interval = 5000;
            this.statusBarTimer.Tick += new System.EventHandler(this.statusBarTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btnSelectTextFile;
        private ToolStripMenuItem btnSaveTextFile;
        private ToolStripMenuItem btnSaveAs;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem btnWordWrap;
        private ToolStripMenuItem btnFont;
        private RichTextBox textBox;
        private FontDialog fontDialog;
        private ToolStripMenuItem btnMakeItalic;
        private ToolStripMenuItem btnMakeBold;
        private ToolStripMenuItem btnMakeUnderlined;
        private ToolStripMenuItem btnIncreaseFontSize;
        private ToolStripMenuItem btnDecreaseFontSize;
        private StatusStrip statusBar;
        private ToolStripStatusLabel lblStatusBar;
        private System.Windows.Forms.Timer statusBarTimer;
    }
}