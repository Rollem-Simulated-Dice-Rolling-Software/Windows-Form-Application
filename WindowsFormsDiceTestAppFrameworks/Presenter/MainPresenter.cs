using System;
using WindowsFormsDiceTestAppFrameworks.Interface;
using WindowsFormsDiceTestAppFrameworks.Model;

namespace WindowsFormsDiceTestAppFrameworks.Presenter
{
    public class MainPresenter
    {
        protected IMainView View;
        protected DiceCup _diceCup;

        public MainPresenter(IMainView view)
        {
            View = view;

            OnLoaded();
        }

        public virtual void OnLoaded()
        {
            InitializeView();
        }

        private void OnAddDiceToCup(object sender, DiceEventArgs e)
        {
            _diceCup.Add(e.Dice);
            View.ShowDiceCupContent(_diceCup);
        }

        private void OnRollDice(object sender, EventArgs e)
        {
            _diceCup.Roll();
            View.ShowDiceRolling(_diceCup);
        }

        public void InitializeModels()
        {
            _diceCup = new DiceCup();
        }

        public void InitializeView()
        {
            View.AddDiceToCup += OnAddDiceToCup;
            View.RollDice += OnRollDice;

            InitializeModels();
        }

        public void UninitializeModels()
        {
            EmptyDiceCup();
        }

        public void UninitializeView()
        {
            View.RollDice -= OnRollDice;
            View.AddDiceToCup -= OnAddDiceToCup;
        }

        private void EmptyDiceCup()
        {
            _diceCup.Clear();
        }

        public virtual void Render()
        {
        }

        public virtual void Resize()
        {
        }
    }
}
