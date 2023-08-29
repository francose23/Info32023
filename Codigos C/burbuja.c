#include<stdio.h>
#include<stdlib.h>

int main(){
	int i=0;
	int j=0;
	int A[10];
	int temp=0;
	
	printf("Algoritmo de la Burbuja \n Vector A: \n");
	for (i=0;i<=9;i++){
		A[i]=rand() % 100;
		printf("%d\n",A[i]);		
	}
	
	for(i=1;i<10;i++){
		for(j=0;j<9;j++){
			if(A[j]>A[j+1]){
				temp=A[j];
				A[j]=A[j+1];
				A[j+1]=temp;
			}
		}
	}
	
	printf("\n Vector A ordenado: \n");
	for (i=0;i<=9;i++){
		printf("%d\n",A[i]);		
	}
	return 0;
}
