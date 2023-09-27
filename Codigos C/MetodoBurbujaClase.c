#include<stdio.h>

int A[9];
int N;

void MetodoBurbuja(int A[], int N){
	int i;
	int j;
	int temp;
	int k;
	
	for (i=2;i<=N;i++){
		
		for(j=1;j<=N-1;j++){
			if(A[j]>A[j+1]){
				temp=A[j];
				A[j]=A[j+1];
				A[j+1]=temp;
			}
		}
		
		printf("\n Etapa %d",i-1);
		printf("\n");
		
		for(k=1;k<=N;k++){
		printf(" %d",A[k]);
		}
		
	}
}

void main (){
	int k;
	A[1] = 13;
	A[2] = 59;
	A[3] = 57;
	A[4] = 11;
	A[5] = 68;
	A[6] = 24;
	A[7] = 46;
	A[8] = 35;
	
	printf("Metodo Burbuja \n");
	printf("Vector A: \n");
	for (k=1;k<=8;k++){

		printf(" %d",A[k]);
	}
	MetodoBurbuja(A,8);
	
	printf("\nVector A ordenado: \n");
	for(k=1;k<=8;k++){
		printf("%d ",A[k]);
	}
}
