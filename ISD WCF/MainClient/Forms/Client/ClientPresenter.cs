using DomainModel;
using System;
using static MainClient.ServiceClient;

namespace MainClient
{
    // Main presenter for clients' form
    public class ClientPresenter
    {
        private IClientsForm _clientForm;
        public ClientPresenter(IClientsForm _clientForm)
        {
            this._clientForm = _clientForm;
            BindingEvents();
        }

        public void BindingEvents()
        {
            _clientForm.ButtCalculateClicked += Calculate;
            _clientForm.ButtGetHumanClicked += GetHuman;
            _clientForm.ButtGetCarClicked += GetCar;
            _clientForm.timerCheckConnectionTick += CheckConnection;
        }
        #region Application's logic
        private void CheckConnection(object sender, EventArgs e)
        {
            try
            {
                _clientForm.ConnectionStatus = GetServiceClient.IsConnected();
            }
            catch (Exception _ex)
            {
                _clientForm.ConnectionStatus = false;
                MessageService.ShowError(_ex.Message);
            }
        }
        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                _clientForm.Solution = GetServiceClient.Summ(_clientForm.ValueA, _clientForm.ValueB);
            }
            catch(Exception _ex)
            {
                MessageService.ShowError(_ex.Message);
            }
        }
        private void GetHuman(object sender, HumansArgs e)
        {
            try
            {
                Human currentHuman = GetServiceClient.GetHuman(e.Id);
                _clientForm.SetHumansInformation(currentHuman);
                MessageService.ShowMassage("Information geted succsessful");
            }
            catch (Exception _ex)
            {
                MessageService.ShowError(_ex.Message);
            }
        }
        private void GetCar(object sender, EventArgs e)
        {
            try
            {
                _clientForm.CurrentCar = GetServiceClient.GetCar();
                MessageService.ShowMassage("Information geted succsessful");
            }
            catch (Exception _ex)
            {
                MessageService.ShowError(_ex.Message);
            }
        }
        #endregion
    }
}
