#include <stdio.h>
#include <stdlib.h>
#include "fact.h"

void TestFactorial()
{
    int i;

    for (i = 1; i < 10; ++i)
    {
        printf("Factorial for %d is %ld\n", i, CalcFactorial(i));
    }
}

void TestFactorialInBatch()
{
    long inputBatch[] = { 2, 4, 6, 8, 10, 12, 14 };
    int batchSize = sizeof(inputBatch) / sizeof(long);
    int i;

    long* resultBatch = (long *) malloc(sizeof(long) * batchSize);
    CalcFactorialInBatch(inputBatch, resultBatch, batchSize);

    for (i = 0; i < batchSize; ++i)
    {
        printf("Batch: factorial for %ld is %ld\n", inputBatch[i], resultBatch[i]);
    }

    free(resultBatch);
}

int main (int argc, char *argv[])
{
    TestFactorial();
    TestFactorialInBatch();

    return 0;
}

