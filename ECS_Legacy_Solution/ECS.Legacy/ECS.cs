namespace ECS.Legacy
{
    public class ECS
    {
        private int _threshold;
        public IHeater Heater { get; set; }
        public ITempSensor TempSensor { get; set;}
        //private readonly ITempSensor _tempSensor;
        //private readonly IHeater _heater;

        public ECS(int thr)
        {
            SetThreshold(thr);
            Heater = new Heater();
            TempSensor = new TempSensor();
            //_tempSensor = new TempSensor();
            //_heater = new Heater();
        }

        public void Regulate()
        {
            var t = TempSensor.GetTemp();
            if (t < _threshold)
                Heater.TurnOn();
            else
                Heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return TempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return TempSensor.RunSelfTest() && Heater.RunSelfTest();
        }
    }
}
