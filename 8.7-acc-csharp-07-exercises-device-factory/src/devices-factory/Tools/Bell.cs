namespace DevicesFactory.Tools
{

    public class Bell : IDevice
    {
        private bool IsOn = false;
        public void TurnOn()
        {
            if (IsOn) throw new System.Exception("Bell is already on");
            IsOn = true;
        }
        public void TurnOff()
        {
            if (!IsOn) throw new System.Exception("Bell is already off");
            IsOn = false;
        }

        public bool IsTurned()
        {
            return IsOn;
        }

    }
}