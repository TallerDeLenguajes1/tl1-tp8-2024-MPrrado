namespace EspacioCalculadora //analogia con compañeros de clase y otra clase
{
    public enum TipoOperacion
    {
        SUMA,
        RESTA,
        PRODUCTO,
        DIVISION
    }
    public class Calculadora
    {
        private double dato;

        private double Dato{ //esto no es necesario porque yo PUEDO acceder a las variables que son privadas mientras este dentro de la clase
            get; set;
        }
        
        
        public double Resultado{ //aqui solo creo la propiedad de Resultado para poder acceder a traver de ella a lo que contiene el resultado que lo alamaceno en dato
            get => Dato;
        }
        public double Sumar(double termino){
            Dato = Dato + termino;
            return Dato;
        }
        public double Restar(double termino){
            Dato = Dato - termino;
            return Dato;
        }
        public double Multiplicar(double termino){
            Dato = Dato * termino;
            return Dato;
        }
        public double Dividir(double termino){
            Dato = Dato / termino;
            return Dato;
        }
        public double limpiar(){
            Dato = 0;
            return Dato;
        }
    }
    
    public class EjecutarOperacionCalculadora
    {
        private List<Operacion> Historial(List<Operacion> historial)
        {
            return historial;
        }

        public bool operacionCalculadora(Calculadora instanciaCalculadora, bool salir,int opcion, List<Operacion> historial)
        {
            double termino;
            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("INGRESE EL TERMINO A SUMARSE: ");
                    if(double.TryParse(Console.ReadLine(), out termino)){
                        instanciaCalculadora.Sumar(termino);
                    }else{
                        System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
                    }
                    break;

                case 2:
                    System.Console.WriteLine("INGRESE EL TERMINO A RESTARSE: ");
                    if(double.TryParse(Console.ReadLine(), out termino)){
                        instanciaCalculadora.Restar(termino);
                    }else{
                        System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
                    }
                    break;

                case 3:
                    System.Console.WriteLine("INGRESE EL TERMINO A SUMARSE: ");
                    if(double.TryParse(Console.ReadLine(), out  termino)){
                        instanciaCalculadora.Multiplicar(termino);
                    }else{
                        System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
                    }
                    break;

                case 4:
                    System.Console.WriteLine("INGRESE EL TERMINO A SUMARSE: ");
                    if(double.TryParse(Console.ReadLine(), out  termino)){
                        instanciaCalculadora.Dividir(termino);
                    }else{
                        System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
                    }
                    break;

                case 5:
                    System.Console.WriteLine($"EL RESULTADO FINAL ES: {instanciaCalculadora.Resultado}");
                    break;

                case 6:
                    instanciaCalculadora.limpiar();
                    break;
                
                default:
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