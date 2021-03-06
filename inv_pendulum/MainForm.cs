﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Equalizer
{
    public partial class MainForm : Form
    {
        public double speed, angle, tick;
        public Equalizer equalizer = new Equalizer();
        AngleGrForm AngleForm = new AngleGrForm();
        SpeedGrForm SpeedForm = new SpeedGrForm();

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TimerRefresh.Stop();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            speed = 0;
            angle = 270;
            tick = 0;
            equalizer.down_coeff = 1;
            equalizer.up_coeff = 1;
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            speed = 0;
            angle = 270;
            tick = 0;
            equalizer.down_coeff = 1;
            equalizer.up_coeff = 1;
            TimerRefresh.Stop();
            AngleForm.Close();
            SpeedForm.Close();
            AngleTb.Text = "";
            SpeedTB.Text = "";
            AngSpeedTb.Text = "";
            AngleForm = new AngleGrForm();
            SpeedForm = new SpeedGrForm();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                InputOutput.ResultToFile(AngleTb, SpeedTB, AngSpeedTb, "TestResult.txt");
                MessageBox.Show("Успешно сохранено в файл", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Упс. Что-то пошло не так!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnReadData_Click(object sender, EventArgs e)
        {
            try
            {
                InputOutput.InputData(out speed, out angle, "f1t.txt");
                MessageBox.Show("Успешно загружено из файла", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Упс. Что-то пошло не так!", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {            
            AngleForm.Show();
            SpeedForm.Show();
            TimerRefresh.Start();
            AngleTb.Text += string.Format("{0} \n", angle) + Environment.NewLine;
            SpeedTB.Text += string.Format("{0} \n", speed) + Environment.NewLine;
            AngSpeedTb.Text += string.Format("{0} \n", speed) + Environment.NewLine;
            AngleForm.MakeGr(tick, angle);
            SpeedForm.MakeGr(tick, speed);
        }

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            if (angle!=90)
            {
                if(angle>180)
                {
                    equalizer.down_coeff += 0.1;
                }
                if(angle<180)
                {
                    equalizer.up_coeff -= 0.05;
                }
                equalizer.CalckChange(ref angle, ref speed);
                AngleTb.Text += string.Format("{0} \n", angle) + Environment.NewLine;
                SpeedTB.Text += string.Format("{0} \n", speed) + Environment.NewLine;
                AngSpeedTb.Text += string.Format("{0} \n", speed) + Environment.NewLine;
                tick++;
                AngleForm.MakeGr(tick, angle);
                SpeedForm.MakeGr(tick, speed);
            }
            else
            {
                TimerRefresh.Stop();
                MessageBox.Show("Установка маятника завершена", "Завершение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
