using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ex1Nikita
{
    public partial class MainForm : Form
    {
        #region items
        public int unit = -1, exersize = -1;
        Invoker invoker = new Invoker();
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }


        private void butOpen_Click(object sender, EventArgs e)
        {
            invoker.OpenExersize(unit, exersize);
        }
        private void unitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            unit = unitComboBox.SelectedIndex;
            exersizeComboBox.Items.Clear();
            exersizeComboBox.Items.AddRange(invoker.unitsList[unit]);
            exersizeComboBox.SelectedIndex = 0;
        }

        private void exersizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            exersize = exersizeComboBox.SelectedIndex;
        }
    }
}
