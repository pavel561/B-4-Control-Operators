﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
			Console.WriteLine("Введите первое число");
			int var = Convert.ToInt32(Console.ReadLine());
			Summ2Variable.setVar1(var);
			Console.WriteLine("Введите второе число");
			var = Convert.ToInt32(Console.ReadLine());
			Summ2Variable.setVar2(var);
			Summ2Variable.summVar();
			Console.WriteLine("Введите предполагаемый результат вычисления");
			*/
			/*
			for(int i=0;i<3;i++)
			{
				var = Convert.ToInt32(Console.ReadLine());
				if (Summ2Variable.compareUserResult(var))
				{
					Console.WriteLine($"Верно, результат {var}");
					break;
				}
				else
				{
					Console.WriteLine($"Неверно. Результат {Summ2Variable.getResult()}");
				}
			}
			*/
			/*
			int attempts = 3;
			bool correct = false;
			while(!correct && attempts!=0)
			{
				var = Convert.ToInt32(Console.ReadLine());
				if (Summ2Variable.compareUserResult(var))
				{
					Console.WriteLine($"Верно, результат {var}");
					correct = true;
					break;
				}
				else
				{
					Console.WriteLine($"Неверно. Результат {Summ2Variable.getResult()}");
					attempts--;
					if (attempts == 0)correct = false;
				}

			}
			*/

			//Practice.B4_P1_25_If_TimeOfDayGreeting();
			//Practice.B4_P2_25_If_NumbersComparing();
			//Practice.B4_P3_25_If_PositiveNumbersComparing();
			//Practice.B4_P4_25_If_Akinator5Numbers();
			//Practice.B4_P5_25_Switch_DayOfWeek();
			//Practice.B4_P6_25_Switch_GameNavigation();
			//Practice.B4_P7_25_For_10OddEven();
			//Practice.B4_P8_25_For_3DevideNumbers();
			//Practice.B4_P9_25_For_Matrix10x10();
			//Practice.B4_P10_25_For_HelloWorld();
			//Practice.B4_P11_25_For_Afrochildren();
			//Practice.B4_P12_25_For_Minus10OddEven();
			//Practice.B4_P13_25_For_LettersCount();
			//Practice.B4_P14_25_For_AlphabetBack();
			//Practice.B4_P15_25_While_OddEventNumber();
			//Practice.B4_P16_25_DoWhile_OddEventNumber();
			//Practice.B4_P17_25_While_HelloWorld();
			//Practice.B4_P18_25_While_Multiplier();
			//Practice.B4_P19_25_While_SolveNumberAdding();
			//Practice.B4_P20_25_While_DiceGame();
			//Practice.dB4_P21_25_While_DiceGameMultiplePlayers();

			//Practice.B4_P23_25_IfElse_Calcultor();
			Practice.B4_P24_25_Switch_Calculator();
			Console.ReadLine();

		}
     }
}
