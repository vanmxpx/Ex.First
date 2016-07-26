using System.Windows.Forms;

namespace MainClient
{
    //Centralized message service
    public static class MessageService
    {
        public static void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowMassage(string massage)
        {
            MessageBox.Show(massage, "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
