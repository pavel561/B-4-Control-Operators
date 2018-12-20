using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
	partial class Summ2Variable
	{
		static int var1;
		static int var2;
		static int result;
		public static bool setVar1(int var)
		{
			var1 = var;
			return (true);
		}

		public static bool setVar2(int var)
		{
			var2 = var;
			return (true);
		}

		public static bool compareUserResult(int userResult)
		{
			if(result == userResult){ return (true); }
			else { return (false); }
		}
		public static void summVar()
		{
			result = var1 + var2;
		}
		public static int getResult()
		{
			return (result);
		}
	}
}
