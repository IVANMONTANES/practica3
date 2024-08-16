namespace clases;
public enum TipoOperacion{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar
}
public class Operaciones{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;
    private double Resultado;

    public Operaciones(double resultadoAnterior, double nuevoValor, TipoOperacion operacion, double resultado)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
        Resultado = resultado;
    }

    public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
    public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
    public TipoOperacion Operacion { get => operacion; set => operacion = value; }
    public double Resultado1 { get => Resultado; set => Resultado = value; }

    public void mostrarOperacion(){
        Console.WriteLine("Resultado anterior "+resultadoAnterior);
        Console.WriteLine("Nuevo Valor "+nuevoValor);
        Console.WriteLine("Tipo De Operacion: "+operacion);
        Console.WriteLine("Resultado "+Resultado);
    }
}
public class Calculadora{
    //campo dato//
    private double dato;
    private List<Operaciones> historial = new List<Operaciones>();
    //propiedad para obtener el valor del dato//
    public double Resultado
    {
        get => dato;
    }
    public List<Operaciones> Historial { get => historial; set => historial = value; }

    //definimos los metodos//
    public void Sumar(double termino){
        dato += termino;
    }
    public void Restar(double termino){
        dato -= termino;
    }
    public void Multiplicar(double termino){
        dato *= termino;
    }
    public void Dividir(double termino){
        if(termino == 0){
            Console.WriteLine("no se puede dividir en cero");
        }else{
            dato /= termino;
        }
        
    }
    public void Limpiar(){
        dato = 0;
    }

    public void mostrarHistorial(){
        int contador = 1;
        if(historial.Count != 0){
        foreach(var operacion in historial){
            Console.WriteLine("----------OPERACION "+contador+"-----------");
            operacion.mostrarOperacion();
            contador++;
        }
        }else{
            Console.WriteLine("no se realizo ninguna operacion hasta el momento");
        }
    }

}
