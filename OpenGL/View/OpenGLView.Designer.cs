namespace OpenGL.View
{
    partial class OpenGLView
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
            this.glControlRollingDice = new OpenTK.GLControl();
            this.imageListDice = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // glControlRollingDice
            // 
            this.glControlRollingDice.BackColor = System.Drawing.Color.Black;
            this.glControlRollingDice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControlRollingDice.Location = new System.Drawing.Point(0, 0);
            this.glControlRollingDice.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.glControlRollingDice.Name = "glControlRollingDice";
            this.glControlRollingDice.Size = new System.Drawing.Size(300, 288);
            this.glControlRollingDice.TabIndex = 0;
            this.glControlRollingDice.VSync = false;
            // 
            // imageListDice
            // 
            this.imageListDice.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListDice.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListDice.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // OpenGLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.glControlRollingDice);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "OpenGLView";
            this.Size = new System.Drawing.Size(300, 288);
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControlRollingDice;
        private System.Windows.Forms.ImageList imageListDice;
    }
}
