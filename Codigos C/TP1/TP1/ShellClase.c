#include<stdio.h>

void MetodoShell(int A[],int N){
	
	int intervalo;
	int j, i, k;
	int temp;
	int e=1;
	
	intervalo = N/2;
	
	while (intervalo > 0){
		for(i=intervalo + 1;i<=N;i++){
			j = i -intervalo;
			while(j>0){
				k = j + intervalo;
				if (A[j]<=A[k]){
					j=-1;
				}
				else {
					temp=A[j];
					A[j]=A[k];
					A[k]=temp;
					j = j-intervalo;
				}
			}
			
		printf("\n Etapa %d",e);
		printf("\n");
		e++;
		for(k=1;k<=N;k++){
		printf(" %d",A[k]);
		}
		printf("\n");

		}
		intervalo = intervalo/2;
	}
}

void main(){
	int A[9];
	int k;
	A[1] = 13;
	A[2] = 59;
	A[3] = 57;
	A[4] = 11;
	A[5] = 68;
	A[6] = 24;
	A[7] = 46;
	A[8] = 35;
	
	printf("Metodo Shell \n");
	printf("Vector A: \n");
	for (k=1;k<=8;k++){
		printf(" %d",A[k]);
	}
	MetodoShell(A,8);
	
	printf("\nVector A ordenado: \n");
	for(k=1;k<=8;k++){
		printf("%d ",A[k]);
	}
}
