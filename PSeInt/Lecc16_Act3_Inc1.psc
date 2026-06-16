Algoritmo Lecc16_Act3_Inc1
	
	Dimension numerosEnteros[15]
	
	Definir indice, comparador Como Entero
	Definir existeRepetido Como Logico
	
	existeRepetido <- Falso
	
	Para indice <- 1 Hasta 15 Hacer
		Escribir "Ingrese el número ", indice, ": "
		Leer numerosEnteros[indice]
	FinPara
	
	Para indice <- 1 Hasta 14 Hacer
		Para comparador <- indice + 1 Hasta 15 Hacer
			Si numerosEnteros[indice] = numerosEnteros[comparador] Entonces
				existeRepetido <- Verdadero
			FinSi
		FinPara
	FinPara
	
	Si existeRepetido Entonces
		Escribir "Sí existe al menos un número repetido."
	SiNo
		Escribir "No existe ningún número repetido."
	FinSi
	
FinAlgoritmo