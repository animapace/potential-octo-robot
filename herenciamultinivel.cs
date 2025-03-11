class Vehiculo {
    public void Mover() {
        Console.WriteLine("El vehículo se mueve");
    }
}

class Coche : Vehiculo {
    public void Encender() {
        Console.WriteLine("El coche se enciende");
    }
}

class Deportivo : Coche {
    public void Acelerar() {
        Console.WriteLine("El deportivo acelera");
    }
}
