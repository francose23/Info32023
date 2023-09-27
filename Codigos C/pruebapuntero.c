#include<stdio.h>

int *p;
int x;
int A[3];

int main() {
		x = 3;
		A[1]=x;
		p=&x;
		printf("x %d\n", x);
		printf("p %d\n", p);
		

return 0;
}
