namespace ECS.Legacy
{
    public class FakeHeater : IHeater
    {
        public bool IsHeaterOn { get; set; }

     

        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
            IsHeaterOn = true;
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
            IsHeaterOn = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}