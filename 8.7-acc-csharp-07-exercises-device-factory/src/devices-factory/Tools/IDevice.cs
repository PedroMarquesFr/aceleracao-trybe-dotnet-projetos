namespace DevicesFactory.Tools
{

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();

        bool IsTurned();

    }
}