#include "fact.h"

long CalcFactorial(long n)
{
    long result = 1;
    int i;

    for (i = 1; i <= n; ++i)
    {
        result *= i;
    }

    return result;
}

