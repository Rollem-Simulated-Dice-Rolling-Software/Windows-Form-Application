namespace TestWindowsFormsCoreApp
{
    partial class DiceTestForm
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
            this.openGLControl = new OpenTK.GLControl();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.openGLControl.BackColor = System.Drawing.Color.Black;
            this.openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl.Location = new System.Drawing.Point(0, 0);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.Size = new System.Drawing.Size(1200, 692);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.VSync = false;

            this.components = new System.ComponentModel.Container();

            // 
            // DiceTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openGLControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DiceTestForm";
            this.Text = "Dice Test";
        }

        private OpenTK.GLControl openGLControl;

        #endregion
    }
}

