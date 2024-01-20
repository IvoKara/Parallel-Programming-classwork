#include <stdio.h>
#include <omp.h>

int main()
{
    printf("Hello World");

    #pragma omp parallel
    {
        int id = omp_get_num_threads();

        printf("Hello (%d)", id);
        printf("World (%d)", id);
    }

    return 0;
}