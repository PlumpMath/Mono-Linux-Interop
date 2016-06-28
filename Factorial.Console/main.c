#include <stdio.h>
#include "fact.h"

int main (int argc, char *argv[])
{
    int i;

    for (i = 1; i < 10; ++i)
    {
        printf("Factorial for %d is %ld\n", i, CalcFactorial(i));
    }

    return 0;
}

