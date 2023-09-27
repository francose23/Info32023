#include <stdio.h>

int main(){
	int planeta;
	
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
	
	scanf("\n%d", &planeta);
	
	switch(planeta){
		case 1: printf("\n Distancia media al Sol de Mercurio: 57,9");
		break;
		case 2: printf("\n Distancia media al Sol de Venus: 108,2");
		break;
		case 3: printf("\n Distancia media al Sol de Tierra: 149,6");
		break;
		case 4: printf("\n Distancia media al Sol de Marte: 227,9");
		break;
		case 5: printf("\n Distancia media al Sol de Jupiter: 778,5");
		break;
		case 6: printf("\n Distancia media al Sol de Saturno: 1434");
		break;
		case 7: printf("\n Distancia media al Sol de Urano: 2871");
		break;
		case 8: printf("\n Distancia media al Sol de Neptuno: 4495");
		break;
		default: printf("Error: Planeta no identificado.");
	}
	
	
	
	return 0;
}
