using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal class Dice
    {
        private int die;
        private int face;
        private Random rnd;

        //rnd = new Random(); //เรียกคอนสตักเกตอร์ไปรับค่า
        //rnd.Next(1,7)//for random ในเน็กแรนดอมเริ่ม ถึงที่สิ้นสุด+1 = คือจะได้1-6  use class random

        public int Face
        {
            get { return face; }
            set { face = value; }
        }
        public Dice()
        {
            face = 6;
            rnd = new Random();
            die = rnd.Next(1, 7);
        }
        public Dice(int f)
        {
            face = f;
            rnd = new Random();
            die = rnd.Next(1, face + 1);
        }
        public int RollDice()
        {
            die = rnd.Next(1, face + 1);
            return die;
        }
    }
}
