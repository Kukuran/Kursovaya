using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equalizer
{
    public class Equalizer
    {
        public double down_coeff, up_coeff;
        public void CalckChange(ref double angle, ref double speed)
        {
            int degree_truth_angle = DeterminateDTA(angle),
                degree_truth_speed = DeterminateDTS(speed);
            List<Condition> ConditionList = new List<Condition>
            {
                new Condition(-3, 0),  // case 0
                new Condition(-4, 2),  // case 1
                new Condition(-2, -2), // case 2
                new Condition(-5, 2),  // case 3
                new Condition(-1, -2), // case 4
                new Condition(0, 2),   // case 5
                new Condition(4, -2),  // case 6
                new Condition(1, 2),   // case 7
                new Condition(3, 2),   // case 8
                new Condition(1, 1),   // case 9
                new Condition(3, -1),  // case 10
                new Condition(2, 1),   // case 11
                new Condition(2, -1),  // case 12
                new Condition(2, 0)    // case 13
            };
            int num = 0;
            for (int i = 0; i < ConditionList.Count; i++)
            {
                if (ConditionList[i].Check(degree_truth_angle, degree_truth_speed))
                {
                    num = i;
                    break;
                }                    
            }
            switch (num)
            {
                case 0:
                    speed = 30;
                    angle = angle + speed;
                    break;
                case 1:
                    speed = -30;
                    angle = 270 + down_coeff * speed;
                    break;
                case 2:
                    speed = 30;
                    angle = 270 + down_coeff * speed;
                    break;
                case 3:
                    speed = -30;
                    angle = 270 + down_coeff * speed;
                    break;
                case 4:
                    speed = 30;
                    angle = 270 + down_coeff * speed;
                    break;
                case 5:
                    speed = -30;
                    angle = 90 - up_coeff * speed;
                    break;
                case 6:
                    speed = 30;
                    angle = 90 - up_coeff * speed;
                    break;
                case 7:
                    speed = -speed + 15;
                    angle = 90 - up_coeff * speed;
                    break;
                case 8:
                    speed = -speed - 15;
                    angle = 90 - up_coeff * speed;
                    break;
                case 9:
                    speed = -speed + 5;
                    angle = 90 - up_coeff * speed;
                    break;
                case 10:
                    speed = -speed - 5;
                    angle = 90 - up_coeff * speed;
                    break;
                case 11:
                    speed = -speed + 5;
                    angle = 90 - up_coeff * speed;
                    break;
                case 12:
                    speed = -speed - 5;
                    angle = 90 - up_coeff * speed;
                    break;
                case 13:
                    if (speed > 0)
                    {
                        speed = -speed + 3;
                        angle = 90 - up_coeff * speed;
                    }
                    if (speed < 0)
                    {
                        speed = -speed - 3;
                        angle = 90 - up_coeff * speed;
                    }
                    break;
            }
        }
        public int DeterminateDTA(double angle)
        {
            int result = 0;
            /*  
                верхняя часть: 0-27.5 - 0; 17.5-72.5 - 1; 62.5-117.5 - 2; 107.5-162.5 - 3; 152.5-180 - 4;   
                нижняя часть: 180-207.5 - -1; 197.5-252.5 - -2; 242.5-297.5 - -3; 287.5-342.5 - -4; 332.5-360 - -5;
            */
            double[] tr_arr = new double[5];
            if (angle >= 0 && angle <= 180)
            {
                double l = -27.5, r = l + 55;
                tr_arr[0] = MathApparat.yTriangleHalf(0, 27.5, angle);
                for (int i = 1; i < 4; i++)
                {
                    l += 45;
                    r = l + 55;
                    tr_arr[i] = MathApparat.yTrianglePos(l, (l + r) / 2, r, angle);
                    if (tr_arr[i] > tr_arr[i - 1])
                    {
                        result = i;
                    }
                }
                tr_arr[4] = MathApparat.yTriangleHalf(152.5, 180, angle);
                if (tr_arr[4] > tr_arr[3])
                {
                    result = 4;
                }
            }
            if (angle > 180 && angle < 360)
            {
                double l = 152.5, r = l + 55;
                result = -1;
                tr_arr[0] = MathApparat.yTriangleHalf(180, 207.5, angle);
                for (int i = 1; i < 4; i++)
                {
                    l += 45;
                    r = l + 55;
                    tr_arr[i] = MathApparat.yTrianglePos(l, (l + r) / 2, r, angle);
                    if (tr_arr[i] > tr_arr[i - 1])
                    {
                        result = -i - 1;
                    }
                }
                tr_arr[4] = MathApparat.yTriangleHalf(332.5, 360, angle);
                if (tr_arr[4] > tr_arr[3])
                {
                    result = -5;
                }
            }
            return result;
        }
        public int DeterminateDTS(double speed)
        {
            int type = 0;
            // 0 - нулевая; 
            // 1 - положительная низкая; 
            // 2 - положительная высокая;
            // -1 - отрицательная низкая;
            // -2 - отрицательная высокая;
            double[] tr_arr = new double[3];
            if (speed > 0)
            {
                tr_arr[0] = MathApparat.yTriangleHalf(0, 15, speed);
                double l = -5, r = 15;
                for (int i = 1; i < 3; i++)
                {
                    l += 15;
                    r += 15;
                    tr_arr[i] = MathApparat.yTrianglePos(l, (l + r) / 2, r, speed);
                    if (tr_arr[i] > tr_arr[i - 1])
                    {
                        type = i;
                    }
                }
            }
            if (speed < 0)
            {
                tr_arr[0] = MathApparat.yTriangleHalf(-15, 0, speed);
                int l = 5, r = -15;
                for (int i = 1; i < 3; i++)
                {
                    l -= 15;
                    r -= 15;
                    tr_arr[i] = MathApparat.yTriangleNeg(l, (l + r) / 2, r, speed);
                    if (tr_arr[i] > tr_arr[i - 1])
                    {
                        type = -i;
                    }
                }
            }
            if (speed == 45)
            {
                type = 2;
            }
            if (speed == -45)
            {
                type = -2;
            }
            return type;
        }
    }       
}
