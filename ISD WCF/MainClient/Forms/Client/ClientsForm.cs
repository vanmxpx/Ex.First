using DomainModel;
using System;
using System.Windows.Forms;

namespace MainClient
{
    public partial class ClientsForm : Form, IClientsForm
    {
        #region Variables
        public Int32 ValueA
        {
            get
            {
                return Int32.Parse(textBoxValueA.Text);
            }
        }
        public Car CurrentCar
        {
            set
            {
                lblCurrentCar.Text = value.ToString();
            }
        }
        public Int32 ValueB
        {
            get
            {
                return Int32.Parse(textBoxValueB.Text);
            }
        }
        public Boolean ConnectionStatus
        {
            set
            {
                if (!value)
                    timerCheckConnection.Enabled = value;
                lblStatusConnection.Text = value.ToString();
            }
        }
        public Int32 Solution
        {
            set
            {
                lblSolution.Text = value.ToString();
            }
        }
        public Int32 Id
        {
            get
            {
                if (textBoxHumanId.Text == "")
                {
                    textBoxHumanId.Text = "0";
                }
                return Int32.Parse(textBoxHumanId.Text);
            }
        }
        public event EventHandler ButtCalculateClicked;
        public event EventHandler ButtGetCarClicked;
        public event EventHandler<HumansArgs> ButtGetHumanClicked;
        public event EventHandler timerCheckConnectionTick;
        #endregion

        public ClientsForm()
        {
            InitializeComponent();
            toolStripLblConnectionType.Text = ServiceClient.Connection.ToString();
        }

        public void SetHumansInformation(Human currentHuman)
        {
            lblHumanName.Text = currentHuman.Name;
            lblHumanAge.Text = currentHuman.Age.ToString();
            lblHumanSex.Text = currentHuman.Sex;
        }
        #region Forms' events
        private void butCalculate_Click(object sender, EventArgs e)
        {
            ButtCalculateClicked?.Invoke(this, null);
        }
        private void butGetHuman_Click(object sender, EventArgs e)
        {
            ButtGetHumanClicked?.Invoke(this, new HumansArgs(Id));
        }
        private void timerCheckConnection_Tick(object sender, EventArgs e)
        {
            timerCheckConnectionTick?.Invoke(this, null);
        }
        #endregion

        private void butGetCar_Click(object sender, EventArgs e)
        {
            ButtGetCarClicked?.Invoke(this, null);
        }
    }
}
