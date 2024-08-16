using clases;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

//creamos la lista de tareas pendientes//
List<Tarea> tareaPendientes = new List<Tarea>();
//creamos la lista de tareas realizadas//
List<Tarea> tareaRealizadas = new List<Tarea>();

//creamos una interfaz para cargar las tareas y marcarlas como realizadas//
bool seguir = true;
//usamos esta variable para el id//
int id = 1;
do{
Console.WriteLine("1: cargar tarea pendiente");
Console.WriteLine("2: establecer tarea como realizada");
Console.WriteLine("3: Buscar tareas pendientes por descripcion");
Console.WriteLine("4: mostrar tareas pendientes");
Console.WriteLine("5: motrar tareas realizadas");
Console.WriteLine("6: salir");
string elegirCadena = Console.ReadLine();
int elegir = 0;
    if(int.TryParse(elegirCadena,out elegir)){
            switch(elegir){
                case 1:
                    Console.WriteLine("ingrese la descripcion de la tarea:");
                    string descripcion = Console.ReadLine();
                    
                    int duracion = 0;
                    bool esNumero = true;
                    while(esNumero){
                        Console.WriteLine("ingrese la duracion de la tarea:");
                        string DuracionCadena = Console.ReadLine();
                        if(int.TryParse(DuracionCadena,out duracion)){
                            esNumero = false;
                        }
                        else{
                            Console.WriteLine("no se ingreso una duracion valida");
                        }
                    }
                    tareaPendientes.Add(new Tarea(id,descripcion,duracion));
                    id++;
                break;

                case 2:
                    foreach(var tarea in tareaPendientes){
                        tarea.mostrarTarea();
                    }
                    Console.WriteLine("ingrese el id:");
                    string elegirTareaCadena = Console.ReadLine();
                    int elegirTarea = 0;
                    int indiceTarea=0,contador = 0,encontro1 = 0;
                    if(int.TryParse(elegirTareaCadena,out elegirTarea)){
                            foreach(var tarea in tareaPendientes){
                                if(elegirTarea == tarea.TareaId){
                                    indiceTarea = contador;
                                    encontro1 = 1;
                                }
                                contador++;
                            }
                            if(encontro1 == 0){
                                Console.WriteLine("no se indico un indice valido");
                            }
                            else{
                            tareaRealizadas.Add(tareaPendientes[indiceTarea]);
                            tareaPendientes.RemoveAt(indiceTarea);
                            }
                    }
                    else{
                        Console.WriteLine("no se indico un numero");
                    }
                break;

                case 3:
                    Console.WriteLine("ingrese una descripcion:");
                    string descripcion2 = Console.ReadLine();
                    int encontro2 = 0;
                    foreach(var tarea in tareaPendientes){
                        if(tarea.Descripcion.Contains(descripcion2)){
                            tarea.mostrarTarea();
                            encontro2 = 1;
                        }
                    }
                    if(encontro2 == 0){
                        Console.WriteLine("no existe una tarea pendiente con esa descripcion");
                    }
                break;

                case 4:
                    if(tareaPendientes.Count == 0){
                        Console.WriteLine("no hay tareas pendientes");
                    }
                    else{
                    Console.WriteLine("----------TAREAS PENDIENTES-----------");
                    foreach(var tarea in tareaPendientes){
                        tarea.mostrarTarea();
                    }}
                break;

                case 5:
                    if(tareaRealizadas.Count == 0){
                        Console.WriteLine("no se marcaron tareas como realizadas");
                    }else{
                    Console.WriteLine("----------TAREAS REALIZADAS-----------");
                    foreach(var tarea in tareaRealizadas){
                        tarea.mostrarTarea();
                    }}
                break;
                case 6:
                default:
                seguir = false;
                Console.WriteLine("saliendo...");
                break;
            }
        }
    }while(seguir);
