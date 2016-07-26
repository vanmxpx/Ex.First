using DomainModel;
using System;


namespace MainClient
{
    public class HumansArgs : EventArgs
    {
        public Int32 Id { get; set; }
        public HumansArgs(Int32 Id)
        {
            this.Id = Id;
        }
    }
    public interface IClientsForm
    {
        Int32 ValueA { get; }
        Int32 ValueB { get; }
        Int32 Solution { set; }
        Boolean ConnectionStatus { set; }
        Car CurrentCar { set; }
        Int32 Id { get; }
        void SetHumansInformation(Human currenthuman);
        event EventHandler ButtCalculateClicked;
        event EventHandler ButtGetCarClicked;
        event EventHandler<HumansArgs> ButtGetHumanClicked;
        event EventHandler timerCheckConnectionTick;
    }
}
