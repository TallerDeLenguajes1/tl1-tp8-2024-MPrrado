namespace espacioTareas
{
    public enum Estado
    {
        PENDIENTE,
        TERMINADA
    }
    public class Tarea
    {
        private int id;
        private string? descripcion;
        private int duracion;
        private Estado estado;

        public int Id { get => id; set => id = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        internal Estado Estado { get => estado; set => estado = value; }

        public Tarea(int id, string? descripcion, int duracion, Estado estado)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
            this.estado = estado;
        }
        public Tarea(){}

        //metodos
    }

    public class GenerarTareasPendientes()
    {

       
    }

    public class Listas
    {
        private List<Tarea> tareasPendientes = new List<Tarea>(); //parentesis en List<Tarea>() porque tenemos que crear la lista y la lista recibe parametros similar a instancias una clase
        private List<Tarea> tareasRealizadas = new List<Tarea>(); //parentesis en List<Tarea>() porque tenemos que crear la lista y la lista recibe parametros similar a instancias una clase
        public List<Tarea> TareasPendientes { get => tareasPendientes; set => tareasPendientes = value; }
        public List<Tarea> TareasRealizadas { get => tareasRealizadas; set => tareasRealizadas = value; }

    }

    public class OperacionesTareas()
    {
        public List<Tarea> GenerarListaTareasPendientes(Listas listas)
        {   
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Ingrese la cantidad de tareas PENDIENTES a cargar");
            Console.ForegroundColor = ConsoleColor.White;
            int.TryParse(Console.ReadLine(), out int cantidadTareasAGenerar);
            Random random = new Random();
            for(int i = 0; i<cantidadTareasAGenerar; i++)
            {
                Tarea tarea = new Tarea(i, "hola", random.Next(10,100), Estado.PENDIENTE);
                listas.TareasPendientes.Add(tarea);
            }
            return listas.TareasPendientes;
        }
        public void MostrarListaTareas(List<Tarea> lista)
        {
            System.Console.WriteLine("-----------LISTA-----------");
            System.Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            int i=0;
            foreach(var tarea in lista)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"----Tarea [{i}]----");
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine($"ID tarea: {tarea.Id}");
                System.Console.WriteLine($"Descripcion: {tarea.Descripcion}");
                System.Console.WriteLine($"Duracion: {tarea.Duracion}");
                System.Console.WriteLine();
                i++;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void MoverTareasTerminadas(List<Tarea>listaPendientes,List<Tarea>ListaRealizadas)
        {
            System.Console.WriteLine("Ingrese ID de la tarea realizada para mover a terminadas: ");
            System.Console.WriteLine();
            int salir = 0;
            while(salir == 0)
            {
                if(int.TryParse(Console.ReadLine(), out int idTareaRealizada))
                {
                    foreach(var tarea in listaPendientes)
                    {
                        if(tarea.Id == idTareaRealizada)
                        {
                            listaPendientes.Remove(tarea);//no remover aqui porque da error tengo que guardar la tarea y despues remover
                            tarea.Estado = Estado.TERMINADA;
                            ListaRealizadas.Add(tarea);
                        }else{
                            
                            System.Console.WriteLine("ERROR LA ID NO SE ENCONTRO");
                        }
                    }
                }else
                {
                    System.Console.WriteLine("ERROR INGRESE UNA ID VALIDA");
                    System.Console.WriteLine();
                    Console.ForegroundColor=ConsoleColor.Blue;
                    System.Console.WriteLine("DESEA SEGUIR INTENTANDO? (si [0], no [1]):");
                    Console.ForegroundColor=ConsoleColor.White;
                    int.TryParse(Console.ReadLine(), out salir);
                }
            }

        }
    }

}