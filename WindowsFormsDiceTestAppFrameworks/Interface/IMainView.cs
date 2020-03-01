using System;
using WindowsFormsDiceTestAppFrameworks.Model;

namespace WindowsFormsDiceTestAppFrameworks.Interface
{
    public interface IMainView
    {
        event EventHandler<DiceEventArgs> AddDiceToCup;
        event EventHandler<EventArgs> RollDice;

        void ShowDiceCupContent(DiceCup diceCup);
        void ShowDiceRolling(DiceCup diceCup);
    }
}
