namespace WindowsFormsDiceTestAppFrameworks.View
{
    partial class DiceCupControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceCupControl));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Four", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Six", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Eight", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Ten", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Twelve", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Twenty", 5);
            this.listBoxDiceCupContent = new System.Windows.Forms.ListBox();
            this.imageListDiceSmall = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listViewDiceToChooseFrom = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDiceCupContent
            // 
            this.listBoxDiceCupContent.AllowDrop = true;
            this.listBoxDiceCupContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDiceCupContent.FormattingEnabled = true;
            this.listBoxDiceCupContent.ItemHeight = 25;
            this.listBoxDiceCupContent.Location = new System.Drawing.Point(0, 0);
            this.listBoxDiceCupContent.Name = "listBoxDiceCupContent";
            this.listBoxDiceCupContent.Size = new System.Drawing.Size(459, 186);
            this.listBoxDiceCupContent.TabIndex = 0;
            this.listBoxDiceCupContent.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxDiceCupContent_DragDrop);
            this.listBoxDiceCupContent.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxDiceCupContent_DragEnter);
            this.listBoxDiceCupContent.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxDiceCupContent_DragOver);
            // 
            // imageListDiceSmall
            // 
            this.imageListDiceSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDiceSmall.ImageStream")));
            this.imageListDiceSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDiceSmall.Images.SetKeyName(0, "dice-four-faces.png");
            this.imageListDiceSmall.Images.SetKeyName(1, "perspective-dice-five.png");
            this.imageListDiceSmall.Images.SetKeyName(2, "dice-eight-faces-eight.png");
            this.imageListDiceSmall.Images.SetKeyName(3, "dice-ten-faces_zero.png");
            this.imageListDiceSmall.Images.SetKeyName(4, "dice-twelve-faces_twelve.png");
            this.imageListDiceSmall.Images.SetKeyName(5, "dice-twenty-faces-one.png");
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listViewDiceToChooseFrom);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listBoxDiceCupContent);
            this.splitContainer.Size = new System.Drawing.Size(459, 484);
            this.splitContainer.SplitterDistance = 294;
            this.splitContainer.TabIndex = 1;
            // 
            // listViewDiceToChooseFrom
            // 
            this.listViewDiceToChooseFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDiceToChooseFrom.HideSelection = false;
            this.listViewDiceToChooseFrom.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listViewDiceToChooseFrom.LargeImageList = this.imageListDiceSmall;
            this.listViewDiceToChooseFrom.Location = new System.Drawing.Point(0, 0);
            this.listViewDiceToChooseFrom.Name = "listViewDiceToChooseFrom";
            this.listViewDiceToChooseFrom.Size = new System.Drawing.Size(459, 294);
            this.listViewDiceToChooseFrom.SmallImageList = this.imageListDiceSmall;
            this.listViewDiceToChooseFrom.TabIndex = 0;
            this.listViewDiceToChooseFrom.UseCompatibleStateImageBehavior = false;
            this.listViewDiceToChooseFrom.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewDiceToChooseFrom_ItemDrag);
            this.listViewDiceToChooseFrom.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewDiceToChooseFrom_DragEnter);
            // 
            // DiceCupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "DiceCupControl";
            this.Size = new System.Drawing.Size(459, 484);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDiceCupContent;
        private System.Windows.Forms.ImageList imageListDiceSmall;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView listViewDiceToChooseFrom;
    }
}
