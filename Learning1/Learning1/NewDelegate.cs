using System;

namespace Learning1
{
    delegate string Test(int x, int y);


    public class TestClass1 
    { 
    
    }


    class Speedometer
    {
        public delegate void SpeedChanged(int speed);

        public event SpeedChanged SpeedChangedX;


        public void SetSpeed(int x)
        {
            SpeedChangedX(x);
        }
    }

    public class Seatbelt
    {
        private int oldSpeed = 0;

        public void OnSpeedChange(int speed)
        {
            if ((oldSpeed < 20) && (speed >= 20))
            {
                Console.WriteLine("Seatbelt Speed Increased above 20");
            }
            oldSpeed = speed;
        }
    }


    public class DoorAlarm
    {
        private int oldSpeed = 0;

        public void OnSpeedChange(int speed)
        {
            if ((oldSpeed < 10) && (speed >= 10))
            {
                Console.WriteLine("DoorAlarm Speed Increased above 10");
            }
            oldSpeed = speed;
        }
    }



    public class NewDeletage
    {
        public static void Run()
        {

            Speedometer speedometer = new Speedometer();
            Seatbelt seatbelt = new Seatbelt();
            DoorAlarm doorAlarm = new DoorAlarm();


            speedometer.SpeedChangedX += seatbelt.OnSpeedChange;
            speedometer.SpeedChangedX += doorAlarm.OnSpeedChange;
            speedometer.SpeedChangedX -= seatbelt.OnSpeedChange;


            speedometer.SetSpeed(10);
            speedometer.SetSpeed(20);
            speedometer.SetSpeed(30);
            speedometer.SetSpeed(40);

            //TestClass1 c1 = new TestClass1();

            //Test t1 = TestMethod;
            //t1 += TestMethod1;
            //t1 -= TestMethod1;

            //var y = t1(5,6);



            //Console.WriteLine(y);

            //Creating a delegate
            //executing
            //add another deletage to this
            //removing

        }


        public static string TestMethod(int x, int y)
        {
            Console.WriteLine("TestMethod");
            return $"{x}, sss {y}";
        }


        public static string TestMethod1(int x, int y)
        {
            Console.WriteLine("TestMethod1");
            return $"{x}, xxxx {y}";
        }

    }

}
