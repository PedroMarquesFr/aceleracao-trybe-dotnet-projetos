namespace DevicesFactory.Tools
{

    public class Lamp : IDevice
    {
        public bool IsOn = false;
        public void TurnOn()
        {
            if (IsOn) throw new System.Exception("Lamp is already on");
            IsOn = true;
        }
        public void TurnOff()
        {
            if (!IsOn) throw new System.Exception("Lamp is already off");
            IsOn = false;
        }

        public bool IsTurned()
        {
            return IsOn;
        }

    }
}