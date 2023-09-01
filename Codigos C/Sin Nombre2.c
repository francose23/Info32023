#include<stdio.h>
#include<stdlib.h>

int main(){
	int i =0;
	int j =0;
	int k =0;
	int temp=0;
	int A[10];
	int n = 10;
	int p =n/2;
	
	
	printf("Metodo Shell \n Vector A: \n");
	for (i=1;i<=n;i++){
		
		A[i]=rand() %100;
		printf("%d\n",A[i]);
		
		}
		
	while(p>0){
	
		for(i=1+p;i<=n;i++){
			
			k=i;
			j=i-p;
			
			while(j>0){
				
				if(A[j]>=A[k]){
					temp = A[j];
					A[j] = A[k];
					A[k] = temp;
					j=j-p;
				}
				else {
					j=-1;
				}
			}
		}
		p = p/2;
	}
	
	printf("\nVector A ordenado: \n");
	
	for(i=1;i<=n;i++){
		printf("%d\n",A[i]);
	}	
	
	return 0;
}
