abstract class Empleado {
    public string Nombre { get; set; }
    public abstract void CalcularSalario();
}

class EmpleadoTiempoCompleto : Empleado {
    public override void CalcularSalario() {
        Console.WriteLine("Salario calculado para tiempo completo");
    }
}
