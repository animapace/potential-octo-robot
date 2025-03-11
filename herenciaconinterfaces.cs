interface IPago {
    void ProcesarPago();
}

class PagoTarjeta : IPago {
    public void ProcesarPago() {
        Console.WriteLine("Pago realizado con tarjeta");
    }
}
