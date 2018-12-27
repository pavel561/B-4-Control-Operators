using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P1_25_If_TimeOfDayGreeting");
			Console.WriteLine("Программа приветствия с учетом времени суток");
			Console.WriteLine("");
			//=========================================================

			if (DateTime.Now.TimeOfDay.Hours >= 22 && DateTime.Now.TimeOfDay.Hours < 7)
			{
				Console.WriteLine("Доброй ночи! Ольга");
			}
			else if (DateTime.Now.TimeOfDay.Hours >=7 && DateTime.Now.TimeOfDay.Hours <10)
			{
				Console.WriteLine("Доброе утро! Ольга");
			}
			else if (DateTime.Now.TimeOfDay.Hours >= 10 && DateTime.Now.TimeOfDay.Hours < 16)
			{
				Console.WriteLine("Добрый день! Ольга");
			}
			else if (DateTime.Now.TimeOfDay.Hours >= 16 && DateTime.Now.TimeOfDay.Hours < 22)
			{
				Console.WriteLine("Добрый вечер! Ольга");
			}
		}

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P2_25_If_NumbersComparing");
			Console.WriteLine("Программа для сравнения двух чисел");
			Console.WriteLine("");
			//=========================================================
			Console.Write("Введите число X >> ");
			int X = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите число Y >> ");
			int Y = Convert.ToInt32(Console.ReadLine());
			if(X > Y)
			{
				Console.Write($"Число X больше числа Y на {X - Y} ");
			}
			else if(X < Y)
			{
				Console.Write($"Число X меньше числа Y на {Y - X} ");
			}
			else
			{
				Console.Write($"Число X равно числу Y ");
			}
		}

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P3_25_If_PositiveNumbersComparing");
			Console.WriteLine("Программа для сравнения двух чисел");
			Console.WriteLine("больших или равных нулю");
			Console.WriteLine("");
			//=========================================================
			Console.Write("Введите число X >> ");
			int X = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите число Y >> ");
			int Y = Convert.ToInt32(Console.ReadLine());
			if(X>=0)
			{
				if(Y>=0)
				{
					if (X > Y)
					{
						Console.Write($"Число X больше числа Y на {X - Y} ");
					}
					else if (X < Y)
					{
						Console.Write($"Число X меньше числа Y на {Y - X} ");
					}
					else
					{
						Console.Write($"Число X равно числу Y ");
					}
				}
			}
			if(X<0 || Y<0)
			{
				Console.WriteLine($"Веедено отрицательное число!");
				Console.WriteLine($"Сравнение чисел не производится.");
			}

			
		}

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P4_25_If_Akinator5Numbers");
			Console.WriteLine("Программа угадывающая число");
			Console.WriteLine("от 1го до 5ти");
			Console.WriteLine("");
			//=========================================================
			Console.Write($"Число больше 3х? (Y/N) >>");
			if(Console.ReadKey(false).Key == ConsoleKey.Y)
			{
				Console.WriteLine("");
				Console.Write($"Число меньше 5-и? (Y/N) >>");
				if (Console.ReadKey(false).Key == ConsoleKey.Y)
				{
					Console.WriteLine("");
					Console.WriteLine($"Число равно 4-ём !!!");
				}
				else
				{
					Console.WriteLine("");
					Console.WriteLine($"Число равно 5-и !!!");
				}
			}
			else
			{
				Console.WriteLine("");
				Console.Write($"Число меньше 3х? (Y/N) >>");
				if (Console.ReadKey(false).Key == ConsoleKey.Y)
				{
					Console.WriteLine("");
					Console.Write($"Число больше 1-го? >>");
					if(Console.ReadKey(false).Key == ConsoleKey.Y)
					{
						Console.WriteLine("");
						Console.WriteLine($"Число равно 2-м !!!");
					}
					else
					{
						Console.WriteLine("");
						Console.WriteLine($"Число равно 1-му !!!");
					}
				}
				else
				{
					Console.WriteLine("");
					Console.WriteLine($"Число равно 3-ем !!!");
				}
			}
			Console.ReadKey();
		}

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P5_25_Switch_DayOfWeek");
			Console.WriteLine("Программа приветствия с учетом дня недели");
			Console.WriteLine("");
			//=========================================================
			var today = DateTime.Today;
			var dayOfWeek = (int)today.DayOfWeek;
			switch(dayOfWeek)
			{
				case (0):
					{
						Console.WriteLine("Доброго воскресенья, Ольга");
						break;
					}
				case (1):
					{
						Console.WriteLine("Доброго понедельника, Ольга");
						break;
					}
				case (2):
					{
						Console.WriteLine("Доброго вторника, Ольга");
						break;
					}
				case (3):
					{
						Console.WriteLine("Доброй среды, Ольга");
						break;
					}
				case (4):
					{
						Console.WriteLine("Доброго четверга, Ольга");
						break;
					}
				case (5):
					{
						Console.WriteLine("Доброй пятницы, Ольга");
						break;
					}
				case (6):
					{
						Console.WriteLine("Доброй, Субботы");
						break;
					}

			}
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P6_25_Switch_GameNavigation");
			Console.WriteLine("Программа перемещения в игре");
			Console.WriteLine("");
			Console.WriteLine("W - Вверх");
			Console.WriteLine("S - Вниз");
			Console.WriteLine("A - Влево");
			Console.WriteLine("D - Вправо");
			Console.WriteLine("Q - Выход");
			Console.WriteLine("");
			//=========================================================
			bool run = true;
			while (run)
			{
				var pressedKey = Console.ReadKey(true).Key;
				switch (pressedKey)
				{
					case ConsoleKey.W:
						{
							Console.WriteLine("Вверх");
							break;
						}
					case ConsoleKey.A:
						{
							Console.WriteLine("Влево");
							break;
						}
					case ConsoleKey.S:
						{
							Console.WriteLine("Вниз");
							break;
						}
					case ConsoleKey.D:
						{
							Console.WriteLine("Вправо");
							break;
						}
					case ConsoleKey.Q:
						{
							run = false;
							Console.WriteLine("Выход из игры.");
							break;
						}
					default:
						{
							Console.WriteLine("Неверный ввод.");
							break;
						}
				}
			}
			Console.ReadKey();
		}

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P7_25_For_10OddEven");
			Console.WriteLine("Программа вывода чисел и проверки на четность");
			Console.WriteLine("");
			//=========================================================
			for (int i=1; i<=10; i++)
			{
				Console.Write($"{i} ");
				if(i%2 == 0)
				{
					Console.WriteLine("- Четное");
				}
				else
				{
					Console.WriteLine("- Нечетное");
				}
			}
			Console.ReadKey();
		}


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P8_25_For_3DevideNumbers");
			Console.WriteLine("Программа вывода чисел делящихся на 3");
			Console.WriteLine("без остатка, в интервале от 0 до 30");
			Console.WriteLine("");
			//=========================================================
			for (int i = 30; i >= 0; i--)
			{
				
				if (i % 3 == 0)
				{
					Console.Write($"{i} ");				// Вывод в одну строку
					//Console.WriteLine($"{i} ");		// Вывод каждого числа в отдельную строку
				}
			}
			Console.ReadKey();
		}


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P9_25_For_Matrix10x10");
			Console.WriteLine("Программа вывода матрицы 10x10");
			Console.WriteLine("Матрица заполнена случайными числами");
			Console.WriteLine("в интервале от 0 до 100");
			Console.WriteLine("");
			//=========================================================

			const int MAX_VALUE = 100;
			const int MIN_VALUE = 0;
			Random randomNumber = new Random();
			int[,] matrix = new int[10, 10];
			for (int y = 0; y < 10; y++)
			{
				for (int x = 0; x < 10; x++)
				{
					matrix[x,y] = (int)randomNumber.Next(MIN_VALUE, MAX_VALUE);
				}
			}

			for (int y = 0; y<10; y++)
			{
				for(int x=0; x<10; x++)
				{
					//Выравниваем столбцы, в зависимости от количества цифр числа 
					Console.Write($"{matrix[x, y]}");
					if(matrix[x, y] < 100)
					{
						if (matrix[x, y] < 10)
						{
							Console.Write("   ");
						}
						else
						{
							Console.Write("  ");
						}
					}
					else 
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine($"");
				Console.WriteLine($"");
			}
           
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P10_25_For_HelloWorld");
			Console.WriteLine("Программа выводит сообщение");
			Console.WriteLine("\"Привет, мир\" 6 раз");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			for (int i = 0; i<6; i++)
			{
				Console.WriteLine($"Привет, мир!");
			}
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P11_25_For_Afrochildren");
			Console.WriteLine("Программа выводит считалку");
			Console.WriteLine("про 10 негритят");
			Console.WriteLine("Используется цикл for");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			for (int i = 10; i >= 0; i--)
			{
				if (i == 10)
				{
					Console.WriteLine($" Однажды {i} негритят уселись пообедать.");
					Console.WriteLine($" Один из них закашлялся -и их осталось {i-1}.");
					continue;
				}
				if (i == 9)
				{
					Console.WriteLine($" Однажды {i} негритят уснули очень поздно.");
					Console.WriteLine($" Один их них так и не встал - и их осталось {i - 1}.");
					continue;
				}
				if (i == 8)
				{
					Console.WriteLine($" Потом {i}-ка негритят по Девону бродила.");
					Console.WriteLine($" Один остался там совсем - и их теперь уж {i - 1}.");
					continue;
				}
				if (i == 7)
				{
					Console.WriteLine($" Все {i} веселых негритят по тросточке купили.");
					Console.WriteLine($" Один взмахнул - неловкий жест - и вот их стало {i - 1}.");
					continue;
				}
				if (i == 6)
				{
					Console.WriteLine($" Теперь {i}-ка негритят на пасеку взабралась.");
					Console.WriteLine($" Но одного ужалил шмель - и {i - 1}-ро осталось.");
					continue;
				}
				if (i == 5)
				{
					Console.WriteLine($" {i} самых строгих негритят суровый суд вершили.");
					Console.WriteLine($" Приговорили одного - и стало их {i - 1}.");
					continue;
				}
				if (i == 4)
				{
					Console.WriteLine($" И вот {i}-ка негритят пошла плескаться в море.");
					Console.WriteLine($" Попался на крючек один - и их осталось {i - 1}-ое.");
					continue;
				}
				if (i == 3)
				{
					Console.WriteLine($" Явилось {i}-е в зоопарк, медведь гулял на воле.");
					Console.WriteLine($" Прихлопнул лапой одного - их осталось {i - 1}-ое.");
					continue;
				}
				if (i == 2)
				{
					Console.WriteLine($" {i} негрятенка в след за тем на солнышке лежали.");
					Console.WriteLine($" Внезапно выстрел прогремел - и {i - 1}-го не стало.");
					continue;
				}
				if (i == 1)
				{
					Console.WriteLine($" И вот {i}, совсем {i}. Тоскою сердце сжало.");
					Console.WriteLine($" Пошел повесился и он. И никого не стало.");
					continue;
				}
				if (i == 0)
				{
					Console.WriteLine($" Конец");
					continue;
				}
			}
		}


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P12_25_For_Minus10OddEven");
			Console.WriteLine("Программа проверяет на четность");
			Console.WriteLine("числа в интервале от 0 до -10");
			Console.WriteLine("Используется цикл for");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			for (int i=0; i>=-10; i--)
			{
				Console.Write($" {i} ");
				if (i % 2 == 0)
				{
					Console.WriteLine("- Четное");
				}
				else
				{
					Console.WriteLine("- Нечетное");
				}
			}
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P13_25_For_LettersCount");
			Console.WriteLine("Программа определяет количество букв \"а\"");
			Console.WriteLine("и выводит его на экран");
			Console.WriteLine("Используется цикл for");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			Console.Write("Веедите слово >> ");
			string message = Console.ReadLine();
			const char letter = 'а';				//Символ кириллицы
			int counter = 0;
			string ending;
			for(int i = 0; i < message.Length; i++)
			{
				if(message[i]==letter)
				{
					counter++;
				}
			}

			if(counter!=0)
			{
				if (counter == 1) ending = "ва";							//Проверка счетчика для изменения окончания в слове "буква"
				else if (counter > 1 && counter < 5) ending = "вы";
				else ending = "в";
				Console.WriteLine($"В слове содержится {counter} бук{ending} \"{letter}\"");
			}
			else
			{
				Console.WriteLine($"Слове не содержит буквы \"{letter}\"");
			}

		}


		//B4-P14/25 *For_AlphabetBack
		public static void B4_P14_25_For_AlphabetBack()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P14_25_For_AlphabetBack");
			Console.WriteLine("Программа выводит латинский алфавит ");
			Console.WriteLine("в обратном порядке");
			Console.WriteLine("Используется цикл for");
			Console.WriteLine("Используется верхний регистр символов");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			for (char letter = 'Z'; letter>='A'; letter--)
			{
				Console.Write($"{letter}");
			}
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P15_25_While_OddEventNumber");
			Console.WriteLine("Программа выводит четные числа ");
			Console.WriteLine("из выбранного интервала от 1 до N");
			Console.WriteLine("Используется цикл while");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			Console.Write($"Введите максимальное число проверяемого ряда >> ");
			int numbersAmount = Convert.ToInt32(Console.ReadLine());
			if(numbersAmount >=0 )
			{
				int i = 1;
				while (i <= numbersAmount)
				{
					if (i % 2 == 0)
					{
						Console.Write($"{i} ");             // Вывод в одну строку
						//Console.WriteLine($"{i} ");		// Вывод каждого числа в отдельную строку
					}
					i++;
				}
			}
			else
			{
				Console.WriteLine($"Неверный ввод");             // Вывод ошибки													
			}
			Console.ReadKey();
		}


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P16_25_DoWhile_OddEventNumber");
			Console.WriteLine("Программа выводит нечетные числа ");
			Console.WriteLine("из выбранного интервала от 1 до N");
			Console.WriteLine("Используется цикл while");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			Console.Write($"Введите максимальное число проверяемого ряда >> ");
			int numbersAmount = Convert.ToInt32(Console.ReadLine());
			if (numbersAmount >= 0)
			{
				int i = 1;
				while (i <= numbersAmount)
				{
					if (i % 2 != 0)
					{
						Console.Write($"{i} ");             // Вывод в одну строку
						//Console.WriteLine($"{i} ");		// Вывод каждого числа в отдельную строку
					}
					i++;
				}
			}
			else
			{
				Console.WriteLine($"Неверный ввод");             // Вывод ошибки													
			}
			Console.ReadKey();
		}


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P17_25_While_HelloWorld");
			Console.WriteLine("Программа выводит сообщение");
			Console.WriteLine("\"Привет, мир\" 6 раз");
			Console.WriteLine("Используется цикл while");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			int i = 0;
			while(i < 6)
			{
				Console.WriteLine("Привет, мир!");
				i++;
			}
			Console.ReadKey();
		}


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
		{
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P18_25_While_Multiplier");
			Console.WriteLine("Программа возводит введенное число в степень");
			Console.WriteLine("и выводит результат");
			Console.WriteLine("Используется цикл while");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			Console.Write("Введите число, которое требуется возвести в степень >> ");
			int number = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите степень, в которую требуется возвести число >> ");
			int exponent = Convert.ToInt32(Console.ReadLine());
			if(exponent>=0)
			{
				int result = 1;
				while (exponent > 0)
				{
					result *= number;
					exponent--;
				}
				Console.WriteLine($"Результат - {result}");
			}
			else
			{
				Console.WriteLine($"Извините, Программа пока еще не умеет возводит число в отрицательную степень =((");
			}
			Console.ReadKey();
		}


		//B4-P19/25 While_SolveNumberAdding
		public static void B4_P19_25_While_SolveNumberAdding()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P19_25_While_SolveNumberAdding");
			Console.WriteLine("Программа проверяет ответ пользователя");
			Console.WriteLine("до тех пор, пока не будет дан");
			Console.WriteLine("правильный ответ.");
			Console.WriteLine("Используется цикл while");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			bool answer = false;
			Console.Write("Введите результат вычисления выражения 2+2 >> ");
			int result;
			while (!answer)
			{
				result = Convert.ToInt32(Console.ReadLine());
				if (result == 4)
				{
					Console.WriteLine($"Правильно !!");
					break;
				}
				else
				{
					Console.Write($"Неправильно !! Попробуйте еще раз >> ");
				}
			}
			Console.ReadKey();
		}


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P20_25_While_DiceGame");
			Console.WriteLine("Программа, реализующая алгоритм игры");
			Console.WriteLine("с фишками и костями.");
			Console.WriteLine("Используется цикл while");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			const int GAME_STEP_AMOUNT = 25;			//Размер игрового поля
			int currentUserPosition = 0;                //Текущая позиция игрока
			int userMovesCount = 0;						//Счетчик ходов игрока
			bool gameOver = false;						//Флаг окончания игры

			while(!gameOver)
			{
				Console.Write("Введите выпавшее на кости число (от 1 до 6) >> ");
				int boneDroppedNumber = Convert.ToInt32(Console.ReadLine());
				if(boneDroppedNumber > 6 || boneDroppedNumber < 1)
				{
					Console.WriteLine("Неверный ввод !!!");
					continue;
				}
				currentUserPosition += boneDroppedNumber;
				userMovesCount++;
				if(currentUserPosition < GAME_STEP_AMOUNT)
				{

				}
				else
				{
					gameOver = true;
					Console.Write($"Вы выиграли !!! Количество ходов - {userMovesCount}.");
				}
			}
			Console.ReadKey();
		}

		//B4-P21/25 *While_DiceGameMultiplePlayers
		public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
			const bool USER_1 = true;
			const bool USER_2 = false;
			const int GAME_STEP_AMOUNT = 25;            //Размер игрового поля
			int currentUser1Position = 0;               //Текущая позиция игрока 1
			int currentUser2Position = 0;               //Текущая позиция игрока 2
			int user1MovesCount = 0;                    //Счетчик ходов игрока 1 
			int user2MovesCount = 0;                    //Счетчик ходов игрока 2
			bool gameOver = false;                      //Флаг окончания игры
			bool userSelect = USER_1;

			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P20_25_While_DiceGame");
			Console.WriteLine("Программа, реализующая алгоритм игры");
			Console.WriteLine("с фишками и костями.");
			Console.WriteLine("Реализовано взаимодействие 2х игорков.");
			Console.WriteLine("Используется цикл while");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			Console.WriteLine("Для начала игры нажмите любую клавишу...");
			Console.ReadKey();

			while (!gameOver)
			{
				Console.Clear();
				Console.WriteLine($"Позиция игрока 1 - {currentUser1Position}.");
				Console.WriteLine($"Позиция игрока 2 - {currentUser2Position}.");
				if(userSelect)
				{
					Console.WriteLine($"Ход игрока 1.");
				}
				else
				{
					Console.WriteLine($"Ход игрока 2.");
				}
				Console.Write("Введите выпавшее на кости число (от 1 до 6) >> ");
				int boneDroppedNumber = Convert.ToInt32(Console.ReadLine());
				if (boneDroppedNumber > 6 || boneDroppedNumber < 1)
				{
					Console.WriteLine("Неверный ввод !!!");
					continue;
				}
				if(userSelect)
				{
					userSelect = USER_2;
					currentUser1Position += boneDroppedNumber;
					user1MovesCount++;
					if (currentUser1Position < GAME_STEP_AMOUNT)
					{

					}
					else
					{
						gameOver = true;
						Console.Write($"Игрок 1 выиграл !!! Количество ходов - {user1MovesCount}.");
					}
				}
				else
				{
					userSelect = USER_1;
					currentUser2Position += boneDroppedNumber;
					user2MovesCount++;
					if (currentUser2Position < GAME_STEP_AMOUNT)
					{

					}
					else
					{
						gameOver = true;
						Console.Write($"Игрок 2 выиграл !!! Количество ходов - {user2MovesCount}.");
					}
				}
				
				
			}
		}


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B4_P23_25_IfElse_Calcultor");
			Console.WriteLine("Программа - Калькулятор");
			Console.WriteLine("Используется конструкция if/else");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================

			decimal number1;
			decimal number2;
			char calcSign;
			decimal result;
			Console.Write("Введите первое число >> ");
			number1 = Convert.ToDecimal(Console.ReadLine());
			
			while (true)
			{
				Console.Write("Введите знак операции >> ");
				calcSign = Console.ReadKey().KeyChar;
				Console.WriteLine("");
				if (calcSign=='+' || calcSign == '-' || calcSign == '*' || calcSign == '/')
				{
					break;
				}
				else
				{
					Console.WriteLine("Ошибочный ввод !");
					Console.WriteLine("Допустимы символы '+','-','*','/' ");
				}
			}
			
			Console.Write("Введите второе число >> ");
			number2 = Convert.ToDecimal(Console.ReadLine());

			if (calcSign == '+')
			{
				result = number1 + number2;
				Console.WriteLine($" {number1} + {number2} = {result}");
			}
			else if(calcSign == '-')
			{
				result = number1 - number2;
				Console.WriteLine($" {number1} - {number2} = {result}");
			}
			else if(calcSign == '*')
			{
				result = number1 * number2;
				Console.WriteLine($" {number1} * {number2} = {result}");
			}
			else if(calcSign == '/')
			{
				result = number1 / number2;
				Console.WriteLine($" {number1} / {number2} = {result}");
			}
			else
			{
				Console.WriteLine($"Неверный ввод !!!");
			}
			Console.ReadKey();

		}


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
        }
    }
}
