#include <stdio.h>

int main(){
	char planeta[9];
	int distancia;
	int numero;
	
	printf("Listado de planetas del Sistema Solar: \n");
	printf("1. Mercurio \n");
	printf("2. Venus \n");
	printf("3. Tierra \n");
	printf("4. Marte \n");
	printf("5. Jupiter \n");
	printf("6. Saturno \n");
	printf("7. Urano \n");
	printf("8. Neptuno \n");
	
	
	printf("\n Ingrese el numero asociado al planeta para conocer su distancia media al Sol en millones de Km \n");
	
	scanf("%d", &numero);
	
	switch(numero){
		case 1: strcpy(planeta,"Mercurio");
				distancia = 58;
		break;
		case 2: strcpy(planeta,"Venus");
				distancia = 108;
		break;
		case 3: strcpy(planeta,"Tierra");
				distancia = 150;
		break;

		default: numero = 20;
	}
	
	if (numero != 20){
	
		printf("La distancia media al Sol de %s",planeta);
		printf(" es %d",distancia);
}
	else printf("Error: planeta no identificado.");
	
	
	return 0;
}
