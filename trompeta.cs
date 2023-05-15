class Trompeta : InstrumentosMusicales
{
    private string tipo_trompeta;

    public Trompeta(string nombre, double precio, string tipo_trompeta) : base(nombre, precio)
    {
        this.tipo_trompeta = tipo_trompeta;
    }

    public override string Descripcion()
    {
        return "La " + nombre + " es del tipo " + tipo_trompeta + " y su precio es " + precio + ".";
    }
}