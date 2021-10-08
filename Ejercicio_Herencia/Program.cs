using System;

namespace Ejercicio_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche carrito = new Coche();
            carrito.PrenderMotor();
            //carrito.getInfoVehiculos();
            Coche vehiculo = new Coche(4, 4, "Pequeño", "De Coche");
            //vehiculo.getInfoVehiculos();
            Avion avioneta = new Avion(2, 2, "Grande", "De avioneta");
            avioneta.getInfoVehiculos();
        }
    }
    class Vehiculo
    {
        public Vehiculo()
        {
            llantas = 4;
            puertas = 2;
            chasis = "Grande";
            gasolina = "Para todos";
        }
        public Vehiculo(int llantas, int puertas, string chasis, string gasolina)
        {
            this.llantas = llantas;
            this.puertas = puertas;
            this.chasis = chasis;
            this.gasolina = gasolina;
        }
        public void PrenderMotor()
        {
            Console.WriteLine("Usted tiene el motor prendido");
        }
        public void ApagarMotor()
        {
            Console.WriteLine("Usted ha apagado el motor");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("Usted conduce mucho");
        }
        public void getInfoVehiculos()
        {
            Console.WriteLine($"El vehiculo tiene {llantas} llantas, tiene {puertas} puertas, tiene un chasis {chasis} y tiene gasolina {gasolina}");
        }
        private int llantas;
        private int puertas;
        private string chasis;
        private string gasolina;
    }
    class Avion : Vehiculo
    {
        public Avion() : base()
        {

        }
        public Avion(int llantasAvion, int puerasAvion, string chasisAvions, string gasAvion) : base(llantasAvion, puerasAvion, chasisAvions, gasAvion)
        {

        }
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo un avion");
        }
    }
    class Coche : Vehiculo
    {
        public Coche() : base()
        {

        }
        public Coche(int llantasCoche, int puerasCoche, string chasisCoche, string gasCoche) : base(llantasCoche, puerasCoche, chasisCoche, gasCoche)
        {

        }
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo un coche");
        }
    }
}
