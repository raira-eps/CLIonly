#include <stdio.h>
#include <stdlib.h>

int IAbs(int x);
void Parity(int x);
void main(void);

//絶対値を返す
int IAbs(int x)
{
    return ((x>= 0)? x: -x);
}
//奇数か偶数かを表示する
void Parity(int x)
{
    printf("%s", (x%2)? "Odd": "Even");
}

void main(void)
{
    int n;
    printf("Please enter an integer");
    scanf("%d", &n);
    printf("The absolute value of that number is %d \n", IAbs(n));
    printf("that is");
    Parity(n);
}