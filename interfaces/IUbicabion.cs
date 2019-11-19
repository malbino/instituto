namespace Instituto.Interfaces
{
    public interface IUbicacion
    {
         public double Latitud { get; set; }
         public double Longitud { get; set; }

         public string geolocalizacion();
    }
}