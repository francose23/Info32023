# include <stdio.h>
	int A[9];
void MetodoInsercion ( int A[] , int N){
	int j,i,ind,temp;
	for (i = 2;i <= N ;i ++) {
		temp=A[i];
		j=i-1;
		while((A[j]>temp)&&(j>=1)){
			A[j+1]=A[j];
			j=j-1;
			A[j+1]=temp;
		}	
	}
};
void main(){
	int k;
	A[1]=13;
	A[2]=59;
	A[3]=57;
	A[4]=11;
	A[5]=68;
	A[6]=24;
	A[7]=46;
	A[8]=35;
	

	printf ("vector desordenado\n"); //mostramos el vector
	for (k=1;k<=8; k++)
	printf ("%d\n",A[k]) ;
	
	//Lamamos al metodo
	MetodoInsercion(A ,8);
	
	printf ("vector ordenado\n"); //mostramos el vector
	for (k=1;k<=8; k++)
	printf ("%d\n",A[k]) ;
	
	
}
