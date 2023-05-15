class Violin : InstrumentosMusicales
{
    private string tipo_violin;

    public Violin(string nombre, double precio, string tipo_violin) : base(nombre, precio)
    {
        this.tipo_violin = tipo_violin;
    }

    public override string Descripcion()
    {
        return "El " + nombre + " es del tipo " + tipo_violin + " y su precio es " + precio + ".";
    }
}