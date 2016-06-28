using System;
using System.Runtime.InteropServices;

namespace Factorial.Mono
{
	class InteropFunc
	{
		[DllImport ("libfact.so")]
		public static extern long CalcFactorial(long n);

		[DllImport ("libfact.so")]
		public static extern void CalcFactorialInBatch(IntPtr inputBatch, IntPtr resultBatch, int batchSize);
	}

	class UseCases
	{
		public static void UseCaseSimplest()
		{
			for (int i = 1; i < 10; ++i) 
			{
				Console.WriteLine ("Factorial of {0} is {1}", i, InteropFunc.CalcFactorial (i));
			}
		}

		public static void UseCasePassPointer()
		{
			long[] inputArray = new long[] { 2, 4, 6, 8, 10, 12 };
			long[] outputArray = new long[inputArray.Length];

			int batchSize = inputArray.Length;

			// copy to unmanaged memory to call unmanaged function
			GCHandle handle = GCHandle.Alloc(inputArray, GCHandleType.Pinned);
			IntPtr inputBatch = handle.AddrOfPinnedObject ();

			// allocate memory in unmanaged heap for result
			IntPtr resultBatch = Marshal.AllocHGlobal (sizeof(long) * batchSize);

			// call the unmanaged function
			InteropFunc.CalcFactorialInBatch (inputBatch, resultBatch, batchSize);

			// copy result to managed memory
			Marshal.Copy (resultBatch, outputArray, 0, batchSize);

			// free allocated memory from unmanaged heap
			// note that a production app should consider catching
			// exceptions and freeing allocated unmanaged memory
			handle.Free ();
			Marshal.FreeHGlobal (resultBatch);

			for (int i = 0; i < batchSize; ++i) 
			{
				Console.WriteLine ("Batch factorial of {0} is {1}", inputArray [i], outputArray [i]);
			}
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			UseCases.UseCaseSimplest();
			UseCases.UseCasePassPointer();
		}
	}
}
