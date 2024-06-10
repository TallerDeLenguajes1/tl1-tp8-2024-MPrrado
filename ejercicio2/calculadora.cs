namespace EspacioCalculadora //analogia con compañeros de clase y otra clase
{
    public enum TipoOperacion
    {
        SUMA,
        RESTA,
        PRODUCTO,
        DIVISION,
        LIMPIAR
    }
    public class Calculadora
    {
        private double dato;

        // private double Dato{ //esto no es necesario porque yo PUEDO acceder a las variables que son privadas mientras este dentro de la clase
        //     get; set;
        // }
        
        
        public double Resultado{ //aqui solo creo la propiedad de Resultado para poder acceder a traver de ella a lo que contiene el resultado que lo alamaceno en dato
            get => dato;
        }
        public double Sumar(double termino){
            dato = dato + termino;
            return dato;
        }
        public double Restar(double termino){
            dato = dato - termino;
            return dato;
        }
        public double Multiplicar(double termino){
            dato = dato * termino;
            return dato;
        }
        public double Dividir(double termino){
            dato = dato / termino;
            return dato;
        }
        public double Limpiar(){
            dato = 0;
            return dato;
        }
    }
    
    public class EjecutarOperacionCalculadora
    {
        private List<Operacion> Historial(List<Operacion> historial, int opcion, double resultadoAnterior, double resultadoActual)
        {
            switch (opcion)
            {
                case 1: 
                        historial.Add(new Operacion(resultadoAnterior, resultadoActual, TipoOperacion.SUMA));
                        break;
                case 2:
                        historial.Add(new Operacion(resultadoAnterior, resultadoActual, TipoOperacion.RESTA));
                        break;
                case 3:
                        historial.Add(new Operacion(resultadoAnterior, resultadoActual, TipoOperacion.PRODUCTO));
                        break;
                case 4:
                        historial.Add(new Operacion(resultadoAnterior, resultadoActual, TipoOperacion.DIVISION));
                        break;
                case 6:
                        historial.Add(new Operacion(resultadoAnterior, resultadoActual, TipoOperacion.LIMPIAR));
                        break;
            }
            return historial;
        }

        public bool operacionCalculadora(Calculadora instanciaCalculadora, bool salir,int opcion, List<Operacion> listaHistorial)
        {
            double termino;
            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("INGRESE EL TERMINO A SUMARSE: ");
                    if(double.TryParse(Console.ReadLine(), out termino)){
                        // instanciaCalculadora.Sumar(termino);
                        Historial(listaHistorial, opcion, instanciaCalculadora.Resultado, instanciaCalculadora.Sumar(termino));
                    }else{
                        System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
                    }
                    break;

                case 2:
                    System.Console.WriteLine("INGRESE EL TERMINO A RESTARSE: ");
                    if(double.TryParse(Console.ReadLine(), out termino)){
                        Historial(listaHistorial, opcion, instanciaCalculadora.Resultado, instanciaCalculadora.Restar(termino));
                    }else{
                        System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
                    }
                    break;

                case 3:
                    System.Console.WriteLine("INGRESE EL TERMINO A MULTIPLICARSE: ");
                    if(double.TryParse(Console.ReadLine(), out  termino)){
                        Historial(listaHistorial, opcion, instanciaCalculadora.Resultado, instanciaCalculadora.Multiplicar(termino));
                    }else{
                        System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
                    }
                    break;

                case 4:
                    System.Console.WriteLine("INGRESE EL TERMINO DIVISOR: ");
                    if(double.TryParse(Console.ReadLine(), out  termino)){
                        Historial(listaHistorial, opcion, instanciaCalculadora.Resultado, instanciaCalculadora.Dividir(termino));
                    }else{
                        System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
                    }
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine("----------HISTORIAL---------");
                    System.Console.WriteLine();
                    foreach (var elemento in listaHistorial)
                    {
                        System.Console.WriteLine($"Resultado anterior: {elemento.ResultadoAnterior}");
                        System.Console.WriteLine($"Resultado siguiente: {elemento.NuevoValor}");
                        System.Console.WriteLine($"Operacion realizada: {elemento.Oper}");
                        System.Console.WriteLine();
                    }
                    System.Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"EL RESULTADO FINAL ES: {instanciaCalculadora.Resultado}");
                    break;

                case 6:
                    Historial(listaHistorial, opcion, instanciaCalculadora.Limpiar(), instanciaCalculadora.Resultado);
                    break;
                
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("saliendo....");
                    salir = false;
                    break;
            }
            return salir;
        }
    }
    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion oper;

        public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
        public TipoOperacion Oper { get => oper; set => oper = value; }
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion oper)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.oper = oper;
        }
    }
}