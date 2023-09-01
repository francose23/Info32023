#include<stdio.h>
#include<stdlib.h>

int main(){
	int i =0;
	int j =0;
	int k =0;
	int temp=0;
	int A[10];
	int N = 10;
	int Int = N/2;
	
	
	printf("Metodo Shell \n Vector A: \n");
	for (i=1;i<=N;i++){
		
		A[i]=rand() %100;
		printf("%d\n",A[i]);
		
		}
		
	while(Int>0){
	
		for(i=1+Int;i<=N;i++){
			
			j=i-Int;
			
			while(j>0){
				
				k=j+Int;
				
				if(A[j]<=A[k]){
					j=-1;
				}
				else {
					temp = A[j];
					A[j] = A[k];
					A[k] = temp;
					j=j-Int;
				}
			}
		}
		Int = Int/2;
	}
	
	printf("\nVector A ordenado: \n");
	
	for(i=1;i<=N;i++){
		printf("%d\n",A[i]);
	}	
	
	return 0;
}
