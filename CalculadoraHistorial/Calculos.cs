namespace Calculos
{
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar // Representa la acción de borrar el resultado actual o el historial
    }
    public class Operacion
    {
        private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        private TipoOperacion operacion;// El tipo de operación realizada

        // Constructor para inicializar los valores de la operación
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }

        /* Lógica para calcular o devolver el resultado */
        /*public double Resultado
        {
        }*/
        // Propiedad pública para acceder al nuevo valor utilizado en la operación
        public double ResultadoAnterior
        {
            get { return resultadoAnterior; }
        }
        public double NuevoValor
        {
            get { return nuevoValor; }
        }
        public TipoOperacion Operando
        {
            get { return operacion; }
        }
    }
}