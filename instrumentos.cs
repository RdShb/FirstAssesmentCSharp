abstract class InstrumentosMusicales
{
    protected string nombre;
    protected double precio;


    public InstrumentosMusicales(string nombre, double precio)
    {
        this.nombre = nombre;
        this.precio = precio;
    }

    public abstract string Descripcion();
}