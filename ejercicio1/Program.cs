using espacioTareas;
Listas listas = new Listas();
OperacionesTareas operarLista = new OperacionesTareas();
listas.TareasPendientes = operarLista.GenerarListaTareasPendientes();


OperacionesTareas.MostrarListaTareas(listas);

