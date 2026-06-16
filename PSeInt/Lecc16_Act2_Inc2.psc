Algoritmo Lecc16_Act2_Inc2

	Dimension numerosEnteros[8]
	
	Definir indice, numeroMayor, posicionMayor Como Entero
	
	Para indice <- 1 Hasta 8 Hacer
		Escribir "Ingrese el número ", indice, ": "
		Leer numerosEnteros[indice]
		
		Si indice = 1 Entonces
			numeroMayor <- numerosEnteros[indice]
			posicionMayor <- indice
		SiNo
			Si numerosEnteros[indice] > numeroMayor Entonces
				numeroMayor <- numerosEnteros[indice]
				posicionMayor <- indice
			FinSi
		FinSi
	FinPara
	
	Escribir "El número mayor es: ", numeroMayor
	Escribir "Se encuentra en la posición: ", posicionMayor
	
FinAlgoritmo