namespace ECS.Legacy
{
    public class FakeTempSensor : ITempSensor
    {
        //private Random gen = new Random();
        public int Temp { get; set;}
        public int GetTemp()
        {
            return Temp;
        }
        public bool RunSelfTest()
        {
            return true;
        }

    }
}