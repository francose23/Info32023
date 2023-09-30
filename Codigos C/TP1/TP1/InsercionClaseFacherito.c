#include<stdio.h>

int A[9];

void MetodoInsercion(int A[], int N){
	int j;
	int i;
	int temp;
	int x;


	
	for(i=2;i<=N;i++){
		
		temp = A[i];
		j = i -1;
		
		while((A[j]>temp) && j>=1){
			
			A[j+1]=A[j];
			j = j - 1;
			A[j+1]=temp;
		}
		
		printf("\n Etapa %d",i-1);
		printf("\n");
	for(x=1;x<=8;x++){
		printf("%d ",A[x]);
	}
		
	}
}

void main(){
	int k;
	
	A[1] = 13;
	A[2] = 59;
	A[3] = 57;
	A[4] = 11;
	A[5] = 68;
	A[6] = 24;
	A[7] = 46;
	A[8] = 35;
	
	printf("Metodo de Insercion \n");

	printf(" Vector Desordenado \n");
	for(k=1;k<=8;k++){
		printf("%d ",A[k]);
	}
	MetodoInsercion(A,8);
	printf("\n Vector Ordenado \n");
	for(k=1;k<=8;k++){
		printf("%d ",A[k]);
	}
}
