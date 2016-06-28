using System;
using System.Runtime.InteropServices;

namespace Factorial.Mono
{
	class InteropFunc
	{
		[DllImport ("libfact.so")]
		public static extern long CalcFactorial(long n);
	}

	class UseCases
	{
		public static void SimplestUseCase()
		{
			for (int i = 1; i < 10; ++i) 
			{
				Console.WriteLine ("Factorial of {0} is {1}", i, InteropFunc.CalcFactorial (i));
			}
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			UseCases.SimplestUseCase();
		}
	}
}
