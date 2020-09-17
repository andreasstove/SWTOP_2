namespace ECS.Legacy
{
    public class FakeHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on Fake");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off Fake");
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}