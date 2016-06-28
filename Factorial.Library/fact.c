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

void CalcFactorialInBatch(long* inputBatch, long* resultBatch, int batchSize)
{
    int i;

    for (i = 0; i < batchSize; ++i)
    {
        resultBatch[i] = CalcFactorial(inputBatch[i]);
    }
}

