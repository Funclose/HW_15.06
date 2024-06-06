using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device myboat = new Steamboat();
            myboat.Show();
            myboat.Sound();
            myboat.Desc();

            Device mymicrowave = new Microwave();
            mymicrowave.Show();
            mymicrowave.Sound();
            mymicrowave.Desc();

            Device mycar = new Car();
            mycar.Show();
            mycar.Sound();
            mycar.Desc();


            Device kettle = new Kettle();
            kettle.Show();
            kettle.Sound();
            kettle.Desc();


        }
    }
}
