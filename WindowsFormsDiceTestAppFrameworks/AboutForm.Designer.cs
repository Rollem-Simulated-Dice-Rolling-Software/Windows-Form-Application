namespace WindowsFormsDiceTestAppFrameworks
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelWhat = new System.Windows.Forms.Label();
            this.labelWho = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::WindowsFormsDiceTestAppFrameworks.Properties.Resources.game_gamble_dice_roll_512;
            this.pictureBox.Location = new System.Drawing.Point(55, 55);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(350, 350);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelWhat
            // 
            this.labelWhat.AutoSize = true;
            this.labelWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhat.Location = new System.Drawing.Point(411, 68);
            this.labelWhat.Name = "labelWhat";
            this.labelWhat.Size = new System.Drawing.Size(364, 165);
            this.labelWhat.TabIndex = 1;
            this.labelWhat.Text = "Rollem\'\r\nDice Rolling\r\nTest Application";
            this.labelWhat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWho
            // 
            this.labelWho.AutoSize = true;
            this.labelWho.Location = new System.Drawing.Point(457, 266);
            this.labelWho.Name = "labelWho";
            this.labelWho.Size = new System.Drawing.Size(278, 25);
            this.labelWho.TabIndex = 2;
            this.labelWho.Text = "By: Ryan and Trent Doering";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(502, 347);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(163, 58);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelWho);
            this.Controls.Add(this.labelWhat);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About Rollem\'";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelWhat;
        private System.Windows.Forms.Label labelWho;
        private System.Windows.Forms.Button buttonClose;
    }
}