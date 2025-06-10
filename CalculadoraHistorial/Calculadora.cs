using Calculos;
namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        private List<Operacion> historial = new List<Operacion>();
        public double Resultado
        {
            get => this.dato;
        }
        public List<Operacion> Historial
        {
            get => this.historial; 
            set => this.historial = value;
        }

        public double Dato { set => dato = value; }

        public void Sumar(double valor)
        {
            Operacion operacion = new(this.dato, this.dato + valor, Calculos.TipoOperacion.Suma);
            this.Historial.Add(operacion);
            this.dato += valor;
        }
        public void Restar(double valor)
        {
            Operacion operacion = new(this.dato, this.dato - valor, Calculos.TipoOperacion.Resta);
            this.Historial.Add(operacion);
            this.dato -= valor;
        }
        public void Multiplicar(double valor)
        {
            Operacion operacion = new(this.dato, this.dato * valor, Calculos.TipoOperacion.Multiplicacion);
            this.Historial.Add(operacion);
            this.dato *= valor;
        }
        public void Dividir(double valor)
        {
            Operacion operacion = new(this.dato, this.dato / valor, Calculos.TipoOperacion.Division);
            this.historial.Add(operacion);
            this.dato /= valor;
        }
        public void Limpiar()
        {
            if (this.Historial.Count > 0 && this.Historial[this.Historial.Count - 1].Operando == Calculos.TipoOperacion.Limpiar)
            {
                // Si la última operación es de tipo Limpiar, se elimina todo el historial
                this.Historial.Clear();
            }
            else
            {
                Operacion operacion = new(this.dato, this.dato = 0, Calculos.TipoOperacion.Limpiar);
                this.Historial.Add(operacion);
                this.dato = 0;
            }
        }
    }
}