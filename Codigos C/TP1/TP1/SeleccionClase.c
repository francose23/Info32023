#include<stdio.h>

void MetodoSeleccion(int A[],int N){
	
	int j;
	int i;
	int temp;
	int ind;
	int k;
	
	for(i=1;i<=N-1;i++){
		ind = i;
		for(j=i+1;j<=N;j++){
			if(A[ind]>A[j]){
			ind = j;				
			}
			
		}
		temp = A[i];
		A[i]=A[ind];
		A[ind]=temp;
		
		printf("\nEtapa  %d",i);
		printf("\n");	
		for(k=1;k<=8;k++){
		
		printf("%d ",A[k]);
	}
	}
}

void main(){
	int A[8];
	int k;
	A[1] = 13;
	A[2] = 59;
	A[3] = 57;
	A[4] = 11;
	A[5] = 68;
	A[6] = 24;
	A[7] = 46;
	A[8] = 35;
	
	printf("Metodo de Seleccion");
	
	printf("\n Vector A: \n");
	for(k=1;k<=8;k++){
		printf(" %d",A[k]);
	}	
	
	MetodoSeleccion(A,8);
	printf("\n Vector ordenado: \n");
	for(k=1;k<=8;k++){
		printf(" %d",A[k]);
	}

}
