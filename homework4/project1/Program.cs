using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class alarm
    {
        private int todayHour,todayMinute,todaySecond;
        private int SetHour, SetMinute, SetSecond;
        public void Getnowtime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            todayHour = currentTime.Hour;
            todayMinute=currentTime.Minute;
            todaySecond = currentTime.Second;
        }
        public void Settime(int setHour, int setMinute, int setSecond)
        {
            SetHour = setHour;
            SetMinute = setMinute;
            SetSecond = setSecond;
            Console.WriteLine("剩余时间还有：" + (SetHour - todayHour) + "时" + (SetMinute - todayMinute) + "分" + (SetSecond - todaySecond) + "秒");
        }
        public void Startalarm()
        {
           while(todayHour!=SetHour||todaySecond!=SetSecond||todayMinute!=SetMinute)
                {
                Getnowtime();
                
            }
            Console.WriteLine("时间到了");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            alarm alarm = new alarm();
            alarm.Getnowtime();
            alarm.Settime(11, 30, 00);
            alarm.Startalarm();
            Console.ReadKey();
        }
    }
}
