using DevicesFactory.Tools;

namespace DevicesFactory.Trigger
{
    public class Switcher
    {
        private IDevice _device;
        public Switcher(IDevice device)
        {
            _device = device;
        }

        public void Trigger()
        {
            if (_device.IsTurned())
            {
                _device.TurnOff();
            }
            else
            {
                _device.TurnOn();
            }
        }
    }

}