# include <stdio.h>

int A[8];

void MetodoBurbuja ( int A[] , int N){
	int j;
	int i;
	int Temp ;
	
	for (i = 2;i <=N;i ++) {
		for (j = 1;j <=N - 1;j ++) {
			if(A[j] > A[j + 1]) { Temp = A[j];
				A[j] = A[j + 1];
				A[j + 1] = Temp ;
			}
		}
	}
};

int main(){
	int k;
	A[1]=13;
	A[2]=57;
	A[3]=11;
	A[4]=68;
	A[5]=24;
	A[6]=46;
	A[7]=34;
	A[8]=35;
	
	printf ("Vector desordenado\n");
	for (k =1;k <=8; k ++)
	printf (" %d\n",A[k]);
	
	MetodoBurbuja (A ,8) ;
	
	printf ("Vector ordenado\n");
	for (k =1;k <=8; k ++)
	printf (" %d\n",A[k]);
}
