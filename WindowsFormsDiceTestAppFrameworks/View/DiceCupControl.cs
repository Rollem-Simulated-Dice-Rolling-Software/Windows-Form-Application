using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsDiceTestAppFrameworks.Model;
using System.Collections;

namespace WindowsFormsDiceTestAppFrameworks.View
{
    public partial class DiceCupControl : UserControl, IList<Die>
    {
        // Description of Function
        // ListView contains a collection of images that can be drag and dropped into the ListBox
        // Drag and Drop operation should include:
        // OnDrag - Save current cursor
        // OnDragEnter and OnDragOver - Mouse cursor turns into dice that's being dragged
        // OnLeave - Mouse cursor turns into saved current cursor
        // OnDragDrop - Add dice to dice cup content control
        // Add button to refill dice cup with previous dice
        // Add button to clear dice cup, requiring new fill operations
        public DiceCupControl()
        {
            InitializeComponent();
        }

        public Die this[int index] 
        {
            get
            {
                return listBoxDiceCupContent.Items[index] as Die;
            }
            set
            {
                listBoxDiceCupContent.Items[index] = value;
            }
        }

        public int Count { get { return listBoxDiceCupContent.Items.Count; } }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Die item)
        {
            listBoxDiceCupContent.Items.Add(item);
        }

        public void Clear()
        {
            listBoxDiceCupContent.Items.Clear();
        }

        public bool Contains(Die item)
        {
            return listBoxDiceCupContent.Items.Contains(item);
        }

        public void CopyTo(Die[] array, int arrayIndex)
        {
            listBoxDiceCupContent.Items.CopyTo(array as Die[], arrayIndex);
        }

        public IEnumerator<Die> GetEnumerator()
        {
            return listBoxDiceCupContent.Items.GetEnumerator() as IEnumerator<Die>;
        }

        public int IndexOf(Die item)
        {
            return listBoxDiceCupContent.Items.IndexOf(item);
        }

        public void Insert(int index, Die item)
        {
            listBoxDiceCupContent.Items.Insert(index, item);
        }

        public bool Remove(Die item)
        {
            listBoxDiceCupContent.Items.Remove(item);
            return true;
        }

        public void RemoveAt(int index)
        {
            listBoxDiceCupContent.Items.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listBoxDiceCupContent.Items.GetEnumerator();
        }

        private void listViewDiceToChooseFrom_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewDiceToChooseFrom.DoDragDrop(listViewDiceToChooseFrom.SelectedItems[0], DragDropEffects.Copy);
        }

        private void listViewDiceToChooseFrom_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))

            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBoxDiceCupContent_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
        }

        private void listBoxDiceCupContent_DragEnter(object sender, DragEventArgs e)
        {
            ListViewItem item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
        }

        private void listBoxDiceCupContent_DragOver(object sender, DragEventArgs e)
        {
            ListViewItem item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
        }
    }
}
