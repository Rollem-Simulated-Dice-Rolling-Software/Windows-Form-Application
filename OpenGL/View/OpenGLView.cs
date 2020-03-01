using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenGL.View
{
    public partial class OpenGLView : UserControl
    {
        public OpenGLView()
        {
            InitializeComponent();
        }

        public OpenTK.GLControl Control
        {
            get
            {
                return glControlRollingDice;
            }
        }
    }
}
