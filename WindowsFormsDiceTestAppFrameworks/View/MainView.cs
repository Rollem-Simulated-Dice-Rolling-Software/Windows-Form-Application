using System;
using System.Windows.Forms;
using WindowsFormsDiceTestAppFrameworks.Interface;
using WindowsFormsDiceTestAppFrameworks.Model;
using WindowsFormsDiceTestAppFrameworks.Presenter;

namespace WindowsFormsDiceTestAppFrameworks.View
{
    public partial class MainFormView : Form, IMainView
    {
        private MainPresenter Presenter;

        public MainFormView()
        {
            InitializeComponent();
        }

        public event EventHandler<DiceEventArgs> AddDiceToCup;
        public event EventHandler<EventArgs> RollDice;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void toolStripButtonRollem_Click(object sender, EventArgs e)
        {
            if (null != RollDice)
            {
                RollDice(this, e);
            }
        }

        public void ShowDiceCupContent(DiceCup diceCup)
        {
        }

        public void ShowDiceRolling(DiceCup diceCup)
        {
            int[] rolledDice = diceCup.Roll();
        }

        private void MainFormView_Load(object sender, EventArgs e)
        {
            Presenter = new MainPresenter(this);
        }
    }
}
