#include <stdio.h>



int A[9];
int X;
int Posicion;
int Existe;

void BusquedaBinaria(int A[], int Min, int Max, int X, int *Posicion,int *Existe){
	
	int Medio;
	if ((Min >= Max)&&(X != A[Min])){
		Existe = No;
		if (X > A[Min]){
			*Posicion = Min + 1;
		}
		else {
			*Posicion = Min - 1;
		}
		}
	else {
		Medio = (Min + Max)/2;
		
		if (X == A[Medio]){
			Existe = Si;
			*Posicion = Medio;
		}
		else {
			if (X > A[Medio]){
				Min = Medio + 1;
			}
			else {
				Max = Medio - 1;
			}
			BusquedaBinaria(A, Min, Max, X, Posicion, Existe);
		}
	}
}

int main(){
	
	A[1] = 11;
	A[2] = 13;
	A[3] = 24;
	A[4] = 35;
	A[5] = 46;
	A[6] = 57;
	A[7] = 59;
	A[8] = 68;

	X = 59;
	BusquedaBinaria(A,1,8,X,&Posicion, &Existe);
	printf(" %d\n", Posicion);
	printf(" %d\n", Existe);
	
	return 0;
}
