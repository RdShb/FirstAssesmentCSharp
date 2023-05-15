class Piano : InstrumentosMusicales
{
    private string marca;

    public Piano(string nombre, double precio, string marca) : base(nombre, precio)
    {
        this.marca = marca;
    }

    public override string Descripcion()
    {
        return "El " + nombre + " es de la marca " + marca + " y su precio es " + precio + ".";
    }
}
