using DevicesFactory.Tools;

namespace DevicesFactory.Trigger
{
    public class Button
    {
        private IDevice _device;
        public Button(IDevice device)
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