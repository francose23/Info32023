#include <stdio.h>
#include <stdlib.h>
int main(){
	int A[10];
	int i= 0;
	int j= 0;
	int ind = 0;
	int temp = 0;
	
	for (i=0;i<10;i++){
		A[i]= rand() % 100;
	}
	
	printf("Vector A: \n");
	for (i=0;i<10;i++){
		printf("%d\n",A[i]);
	}
	
	
	
	for (i=0;i<=8;i++){
		
		for(j=i+1;j<=9;j++){
			
			if(A[ind]>A[j]){
				ind = j;
			}
		}
		temp = A[i];
		A[i]= A[ind];
		A[ind] = temp;
	}
	
	printf("\nVector A ordenado: \n");
	for (i=0;i<10;i++){
		printf("%d\n",A[i]);
	}
	
	
	return 0;
}
