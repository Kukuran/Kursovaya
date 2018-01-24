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
                "Скорость" + "\r\n" +
                "------------------------" + "\r\n" +
                "123" + 
                "------------------------" + "\r\n" +
                "Угол" + "\r\n" +
                "------------------------" + "\r\n" +
                "1234" + 
                "------------------------" + "\r\n" +
                "Угловая Скорость" + "\r\n" +
                "------------------------" + "\r\n" +
                "12345" + 
                "------------------------" + "\r\n";
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
        [Test]
        public void InputData_Speed100_Angle200()
        {
            double e_speed = 100;
            double e_angle = 200;
            double speed, angle;
            InputOutput.InputData(out speed, out angle, "test2.txt");
            Assert.That(e_speed, Is.EqualTo(speed));
            Assert.That(e_angle, Is.EqualTo(angle));
        }
        [Test]
        public void DeterminateDTA_Angle270()
        {
            Assert.That(new Equalizer.Equalizer().DeterminateDTA(270), Is.EqualTo(-3));
        }
        [Test]
        public void DeterminateDTS_Speed0()
        {
            Assert.That(new Equalizer.Equalizer().DeterminateDTS(0), Is.EqualTo(0));
        }
        [Test]
        public void Equalizer_Angle270_Speed0()
        {
            Equalizer.Equalizer equalizer = new Equalizer.Equalizer();
            double angle = 270, speed = 0;
            equalizer.CalckChange(ref angle, ref speed);
            Assert.That(angle, Is.EqualTo(300));
            Assert.That(speed, Is.EqualTo(30));
        }
    }
}
