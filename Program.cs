using clases;
Calculadora calculadora = new Calculadora();
bool seguir = true;
do{
    double resultadoAnterior = calculadora.Resultado;
    double nuevoValor;
    TipoOperacion operacion;
    double resultado;
    Console.WriteLine("1 sumar");
    Console.WriteLine("2 restar");
    Console.WriteLine("3 multiplicar");
    Console.WriteLine("4 dividir");
    Console.WriteLine("5 limpiar");
    Console.WriteLine("6 mostrar historial");
    Console.WriteLine("7 salir");
    Console.WriteLine("eliga una opcion:");
    string opcionCadena = Console.ReadLine();
    int opcion = 0;
    if(int.TryParse(opcionCadena, out opcion)){
        if(opcion >= 1 && opcion <= 5){
            if(opcion != 5){
            Console.WriteLine("ingrese un numero");
            string numeroCadena = Console.ReadLine();
            double numero;
            if(double.TryParse(numeroCadena,out numero)){
                switch(opcion){
                    case 1:
                        nuevoValor = numero;
                        operacion = TipoOperacion.Suma; 
                        calculadora.Sumar(numero); 
                        resultado = calculadora.Resultado;
                        calculadora.Historial.Add(new Operaciones(resultadoAnterior,nuevoValor,operacion,resultado));  
                    break;
                    case 2: 
                        nuevoValor = numero;
                        operacion = TipoOperacion.Resta; 
                        calculadora.Restar(numero);
                        resultado = calculadora.Resultado;
                        calculadora.Historial.Add(new Operaciones(resultadoAnterior,nuevoValor,operacion,resultado)); 
                    break;
                    case 3: 
                        nuevoValor = numero;
                        operacion = TipoOperacion.Multiplicacion; 
                        calculadora.Multiplicar(numero); 
                        resultado = calculadora.Resultado;
                        calculadora.Historial.Add(new Operaciones(resultadoAnterior,nuevoValor,operacion,resultado));
                    break;
                    case 4: 
                    calculadora.Dividir(numero); 
                    if(numero != 0){
                        nuevoValor = numero;
                        operacion = TipoOperacion.Division;
                        resultado = calculadora.Resultado;
                        calculadora.Historial.Add(new Operaciones(resultadoAnterior,nuevoValor,operacion,resultado));
                    }
                    break;
                    case 6:
                        calculadora.mostrarHistorial();
                    break;
                }
            }
            }else{
                nuevoValor = 0;
                operacion = TipoOperacion.Limpiar;
                calculadora.Limpiar();
                resultado = calculadora.Resultado;
                calculadora.Historial.Add(new Operaciones(resultadoAnterior,nuevoValor,operacion,resultado));
            }
            Console.WriteLine("valor Actual: "+calculadora.Resultado);
        }else if(opcion == 6){
            calculadora.mostrarHistorial();
        }else if(opcion == 7){
        Console.WriteLine("saliendo");
        seguir = false;
    }else{
        Console.WriteLine("no se indico una opcion valida");
    } 
    }else{
        Console.WriteLine("no se indico un numero");
    }
}while(seguir);
