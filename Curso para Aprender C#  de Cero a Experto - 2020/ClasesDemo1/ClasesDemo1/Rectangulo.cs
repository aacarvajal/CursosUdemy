namespace ClasesDemo1
{
    class Rectangulo
    {

        double baseRectangulo;
        double alturaRectangulo;
        //string color="";

        public Rectangulo()
        {

            baseRectangulo = 0;
            alturaRectangulo = 0;
            //color = "negro";

        }

        public Rectangulo(double baseInicial, double alturaInicial)//, string colorInicial
        {

            baseRectangulo = baseInicial;
            alturaRectangulo = alturaInicial;
            //colorInicial = color;

        }

        public double CalcularArea()
        {

            // A = h* b
            return alturaRectangulo * baseRectangulo;

        }

        public double CalculaPerimetro()
        {

            //P = 2 * h + 2 * b
            return (2 * alturaRectangulo) + (2 * baseRectangulo);

        }

        public static double CalcPerRect(double altRect, double baseRect)
        {

            return (2 * altRect) + (2 * baseRect);

        }

        public void Deconstruct(out double baseRect, out double alturaRect)
        {

            baseRect = baseRectangulo;
            alturaRect = alturaRectangulo;

        }

    }
}
