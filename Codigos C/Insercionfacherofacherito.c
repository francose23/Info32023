#include<stdio.h>
#include<stdlib.h>

int main(){
	
	int i=0;
	int j=0;
	int temp = 0;
	int A[10];
	int k=0;
	
	printf("\n Ordenamiento por Insercion \n Vector A: \n");
	for (i=1; i<=10;i++){
		A[i]=rand () %100;
		A[1]=80;
		printf("%d  ",A[i]);
	}
	
	for(i=1;i<10;i++){
		
		temp = A[i];
		j=i-1;
		
		while(A[j]>temp & j>=1){
			A[j+1]=A[j];
			A[j]=temp;
			j=j-1;
		}
		
		printf("\n Etapa %d",i);
		printf("\n");
		for (k=1; k<=10;k++){
		printf("%d  ",A[k]);
	}
		printf("\n");
	}
	printf("\n Vector A ordenado: \n");
	for (i=1; i<=10;i++){
		printf("%d  ",A[i]);
	}	
	
return 0;	
}
