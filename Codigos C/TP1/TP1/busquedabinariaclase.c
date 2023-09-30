# include <stdio.h>

int A [9];
int X;

void Imprimir (char Existe, int Medio){
		printf ("Existe el valor en el vector?\n");
		printf (" %c\n",Existe);
		printf ("Posicion del Valor\n");
		printf (" %d\n",Medio);
}

void BusquedaBinaria ( int A[], int Min, int Max, int X){
	int Medio ;
	int Posicion;
	char Existe;
	
	if ((Min>=Max) && (X!=A[Min])){
			Existe = 'N';
			Medio = 0;
			Imprimir(Existe, Medio);
		if(X > A[Min])
			Posicion = Min + 1;
		else
			Posicion = Min - 1;
		
	} else {
		Posicion = Min - 1;
		Medio = (Min+Max)/2;
		if(X == A[Medio]){
			Existe = 'S';
			Imprimir(Existe, Medio);
		} else {
			if(X > A[Medio])
				Min = Medio + 1;
			else
				Max = Medio - 1;
			BusquedaBinaria (A, Min , Max , X);
		}
	}
}

void MetodoBurbuja ( int A[] , int N){
	int j;
	int i;
	int Temp ;
	
	for (i = 2;i <=N;i ++) {
		for (j = 1;j <=N - 1;j ++) {
			if(A[j] > A[j + 1]) { Temp = A[j];
				A[j] = A[j + 1];
				A[j + 1] = Temp ;
			}
		}
	}
};

void main(){
	int k;
	A[1]=13;
	A[2]= 59;
	A[3]= 57;
	A[4]= 11;
	A[5]= 68;
	A[6]= 24;
	A[7]= 46;
	A[8]= 35;
	X=15;
	
	printf ("Vector ingresado\n");
	for (k =1;k <=8; k ++)
	printf (" %d\n",A[k]);
	
	printf ("Valor a buscar\n");
	printf (" %d\n",X);
	
	MetodoBurbuja (A ,8) ;
	
	printf ("Vector Ordenado\n");
	for (k =1;k <=8; k ++)
	printf (" %d\n",A[k]);
	
	BusquedaBinaria (A, 1, 8, X);
}

