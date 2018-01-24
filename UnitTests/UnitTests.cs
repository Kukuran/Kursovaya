using System;
using NUnit.Framework;
using System.Windows.Forms;
using System.IO;
using Equalizer;

namespace UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void ResultToFile_Text123()
        {
            string etalon =
                "Скорость" + "\n" +
                "------------------------" + "\n" +
                "123" + "\n" +
                "------------------------" + "\n" +
                "Угол" + "\n" +
                "------------------------" + "\n" +
                "1234" + "\n" +
                "------------------------" + "\n" +
                "Угловая Скорость" + "\n" +
                "------------------------" + "\n" +
                "12345" + "\n" +
                "------------------------" + "\n";
            TextBox SpeedTB = new TextBox();
            TextBox AngleTb = new TextBox();
            TextBox AngSpeedTb = new TextBox();
            SpeedTB.Text = "123";
            AngleTb.Text = "1234";
            AngSpeedTb.Text = "12345";
            InputOutput.ResultToFile(AngleTb, SpeedTB, AngSpeedTb, "test1.txt");
            string test;
            using (StreamReader file = new StreamReader("test1.txt"))
            {
                test = file.ReadToEnd();
            }
            Assert.That(test, Is.EqualTo(etalon));
        }
        public void InputData_Speed100_Angle200()
        {
            double e_speed = 100;
            double e_angle = 200;
            double speed, angle;
            InputOutput.InputData(out speed, out angle, "test2.txt");
            Assert.That(e_speed, Is.EqualTo(speed));
            Assert.That(e_angle, Is.EqualTo(angle));
        }
    }
}
