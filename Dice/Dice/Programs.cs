using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal class Programs
    { 

        public static void Main(string[] args)
    {   //ลองทำ
        //Dice dice1= new Dice();

        //Console.WriteLine("Dice#1 has {0} face",dice1.Face);
        //Console.WriteLine("Dice#2 has {0} face",dice1.Face);
        //int result1, result2, count = 0;

        //do {
        //    result1 = dice1.RollDice();
        //    result2= dice1.RollDice();
        //    Console.WriteLine("Round {0}: ",count+1);
        //    Console.WriteLine("Dice#1 = {0}",result1);
        //    Console.WriteLine("Dice#2 = {0}",result2);
        //    Console.WriteLine("=============");
        //    count++;
        //}while(result1 != result2);
        //Console.WriteLine("Roll 2 dices {0} times to get the same value!!!",count);


        //or or or or or or or or or or or or or or or or or or or or or or or or or or or -----------------------
        Dice dice1 = new Dice();
        Dice dice2 = new Dice(6);
        int die1;
        int die2;
        int count = 0; //ไว้นับ เเล้วเริ่มต้นที่0
        Console.WriteLine("Dice 1 has {0} face", dice1.Face);
        Console.WriteLine("Dice 2 has {0} face", dice2.Face);


        die1 = dice1.RollDice();
        die2 = dice2.RollDice();
        //Console.WriteLine("Dice#1 = {0}", die1);
        //Console.WriteLine("Dice#1 = {0}", die2);
        //Console.WriteLine("=============");

        //----------------------- while
        //while (die1 != die2) {
        //    count++;
        //    Console.WriteLine("Round {0}: ", count);
        //    die1 = dice1.RollDice();
        //    die2 = dice2.RollDice();
        //    Console.WriteLine("Dice#1 = {0}", die1);
        //    Console.WriteLine("Dice#1 = {0}", die2);
        //    Console.WriteLine("=============");
        //}
        //----------------------- do while
        do
        {
            count++;
            Console.WriteLine("Round {0}: ", count);
            die1 = dice1.RollDice();
            die2 = dice2.RollDice();
            Console.WriteLine("Dice#1 = {0}", die1);
            Console.WriteLine("Dice#1 = {0}", die2);
            Console.WriteLine("=============");
        } while (die1 != die2);

        Console.WriteLine("Roll 2 dices {0} times to get the same value!!!", count);

    }
}
}
