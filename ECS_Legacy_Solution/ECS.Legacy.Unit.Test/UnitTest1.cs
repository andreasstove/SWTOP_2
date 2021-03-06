using System;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;


namespace ECS.Legacy.Unit.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ECS_TempSensor_PropertyInj()
        {
            var uut = new ECS(20);
            FakeTempSensor FakeTemp = new FakeTempSensor();
            int expectedResult = FakeTemp.Temp = 3;
            uut.TempSensor = FakeTemp;
            //uut.Heater = new FakeHeater();
            int result = uut.TempSensor.GetTemp();
            Assert.That(result,Is.EqualTo(expectedResult));
        }

        //[Test]
        //public void ECS_Heater_PropertyInj()
        //{
        //    var uut = new ECS(20);
        //    FakeHeater fakeheater = new FakeHeater();
        //    string expectedResult = "Heater is on";
        //   // string resut = uut.Heater.TurnOn().ToString();
        //    //Assert.That(expectedResult,  Is.EqualTo(uut.Heater.TurnOn().ToString()));
        //    uut.Heater.TurnOn();
        //    //Det virker ikke stadig
        //    Assert.AreEqual(expectedResult,Console.Out);
        //}

        [Test]
        public void ECS_Heater_On()
        {
            var uut = new ECS(20);
            FakeHeater FakeH = new FakeHeater();
            uut.Heater = FakeH;
            FakeTempSensor FakeT = new FakeTempSensor();
            FakeT.Temp = 10;
            uut.TempSensor = FakeT;
            uut.Regulate();
            Assert.IsTrue(FakeH.IsHeaterOn);
        }
    }
}