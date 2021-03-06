﻿namespace WindowsFormsDiceTestAppFrameworks.View
{
    partial class MainFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormView));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorFile = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRollem = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.rollingDice = new OpenGL.View.OpenGLView();
            this.panelDiceRoller = new System.Windows.Forms.Panel();
            this.splitContainerDiceCupAndAnnimation = new System.Windows.Forms.SplitContainer();
            this.diceCupControl1 = new WindowsFormsDiceTestAppFrameworks.View.DiceCupControl();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.panelDiceRoller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDiceCupAndAnnimation)).BeginInit();
            this.splitContainerDiceCupAndAnnimation.Panel1.SuspendLayout();
            this.splitContainerDiceCupAndAnnimation.Panel2.SuspendLayout();
            this.splitContainerDiceCupAndAnnimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1122, 40);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparatorFile,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparatorFile
            // 
            this.toolStripSeparatorFile.Name = "toolStripSeparatorFile";
            this.toolStripSeparatorFile.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 44);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(75, 36);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRollem});
            this.toolStripMain.Location = new System.Drawing.Point(0, 40);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStripMain.Size = new System.Drawing.Size(1122, 42);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonRollem
            // 
            this.toolStripButtonRollem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRollem.Image = global::WindowsFormsDiceTestAppFrameworks.Properties.Resources.game_gamble_dice_roll_512;
            this.toolStripButtonRollem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRollem.Name = "toolStripButtonRollem";
            this.toolStripButtonRollem.Size = new System.Drawing.Size(46, 36);
            this.toolStripButtonRollem.Text = "Rollem\'";
            this.toolStripButtonRollem.Click += new System.EventHandler(this.toolStripButtonRollem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStripMain.Location = new System.Drawing.Point(0, 578);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1122, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // rollingDice
            // 
            this.rollingDice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollingDice.Location = new System.Drawing.Point(0, 0);
            this.rollingDice.Margin = new System.Windows.Forms.Padding(12);
            this.rollingDice.Name = "rollingDice";
            this.rollingDice.Size = new System.Drawing.Size(736, 492);
            this.rollingDice.TabIndex = 0;
            // 
            // panelDiceRoller
            // 
            this.panelDiceRoller.Controls.Add(this.splitContainerDiceCupAndAnnimation);
            this.panelDiceRoller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiceRoller.Location = new System.Drawing.Point(0, 82);
            this.panelDiceRoller.Margin = new System.Windows.Forms.Padding(6);
            this.panelDiceRoller.Name = "panelDiceRoller";
            this.panelDiceRoller.Size = new System.Drawing.Size(1122, 496);
            this.panelDiceRoller.TabIndex = 3;
            // 
            // splitContainerDiceCupAndAnnimation
            // 
            this.splitContainerDiceCupAndAnnimation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerDiceCupAndAnnimation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDiceCupAndAnnimation.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDiceCupAndAnnimation.Name = "splitContainerDiceCupAndAnnimation";
            // 
            // splitContainerDiceCupAndAnnimation.Panel1
            // 
            this.splitContainerDiceCupAndAnnimation.Panel1.Controls.Add(this.diceCupControl1);
            // 
            // splitContainerDiceCupAndAnnimation.Panel2
            // 
            this.splitContainerDiceCupAndAnnimation.Panel2.Controls.Add(this.rollingDice);
            this.splitContainerDiceCupAndAnnimation.Size = new System.Drawing.Size(1122, 496);
            this.splitContainerDiceCupAndAnnimation.SplitterDistance = 374;
            this.splitContainerDiceCupAndAnnimation.SplitterWidth = 8;
            this.splitContainerDiceCupAndAnnimation.TabIndex = 1;
            // 
            // diceCupControl1
            // 
            this.diceCupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diceCupControl1.Location = new System.Drawing.Point(0, 0);
            this.diceCupControl1.Name = "diceCupControl1";
            this.diceCupControl1.Size = new System.Drawing.Size(370, 492);
            this.diceCupControl1.TabIndex = 4;
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 600);
            this.Controls.Add(this.panelDiceRoller);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainFormView";
            this.Text = "Rollem\'";
            this.Load += new System.EventHandler(this.MainFormView_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panelDiceRoller.ResumeLayout(false);
            this.splitContainerDiceCupAndAnnimation.Panel1.ResumeLayout(false);
            this.splitContainerDiceCupAndAnnimation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDiceCupAndAnnimation)).EndInit();
            this.splitContainerDiceCupAndAnnimation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonRollem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private OpenGL.View.OpenGLView rollingDice;
        private System.Windows.Forms.Panel panelDiceRoller;
        private System.Windows.Forms.SplitContainer splitContainerDiceCupAndAnnimation;
        private DiceCupControl diceCupControl1;
    }
}

