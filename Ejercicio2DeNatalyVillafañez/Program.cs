using System;

namespace Ejercicio2DeNatalyVillafañez
{
    class Program
    {
		static bool ValidarElipse(double a, double b)
        {
			if (((a != 0) && (b != 0) && (a != b)) && ((a >= 0 && b >= 0) || (a <= 0 && b <= 0)))
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		static bool ValidarHiperbola(double a, double b)
        {
			if (((a != 0) && (b != 0) && (a != b)) && ((a >= 0 && b <= 0) || (a <= 0 && b >= 0)))
            {
				return true;
            }
			else
            {
				return false;
            }
        }
		static bool ValidarParabola(double a, double b)
        {
			if (((a == 0) || (b == 0)) && (a != b))
            {
				return true;
            }
			else
            {
				return false;
            }				
        }
		static bool ValidarCircunferencia(double a, double b)
		{
			if ((a != 0) && (b != 0) && (a == b))
			{
				return true;
			}
			else
            {
				return false;
            }
		}
		static string CoordenadasCentroCircunferencia(double a, double b, double c, double d, double e)
        {
			b = (b / a);
			c = (c / a);
			d = (d / a);
			e = (e / a);
			a = (a / a);

			var coordenadaX = (-d / 2);
			var coordenadaY = (-e / 2);
			var coordenadas = ($"({coordenadaX},{coordenadaY})");
			return coordenadas;
		}
		static string RadioCircunferencia(double a, double b, double c, double d, double e)
		{

            b = (b / a);
            c = (c / a);
            d = (d / a);
            e = (e / a);
            a = (a / a);

            var radicando = Math.Pow(c,2) + Math.Pow(d,2) - 4 * e;
			if (radicando >= 0)
			{
				var radio = ((1/2d) * Math.Sqrt(radicando)).ToString();
				return radio;
			}
			else
			{
				var radio = "Raíz está fuera de los numeros reales, no se puede calcualar el radio.";
				return radio;
			}

		}
		static void Main(string[] args)
        {
            try
            {
                Console.Title = "TIPO DE CÓNICA";
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Le informaremos con qué cónica está trabajando de acuerdo a los valores de su funcion");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("El formato de la función es: Ax^2+By^2+Cx+Dy+E=0");

                Console.Write("Ingrese el valor de A: ");
                var valorA = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor de B: ");
                var valorB = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor de C: ");
                var valorC = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor de D: ");
                var valorD = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor de E: ");
                var valorE = double.Parse(Console.ReadLine());

                if ((valorA != 0) || (valorB != 0))
                {
                    if (ValidarParabola(valorA, valorB))
                    {
                        Console.WriteLine("Los valores ingresados corresponden a una Parábola.");
                    }
                    else
                    {
                        if (ValidarElipse(valorA, valorB))
                        {
                            Console.WriteLine("Los valores ingresados corresponden a una Elipse.");
                        }
                        else
                        {
                            if (ValidarHiperbola(valorA, valorB))
                            {
                                Console.WriteLine("Los valores ingresados corresponden a una Hipérbola.");
                            }
                            else
                            {
                                if (ValidarCircunferencia(valorA, valorB))
                                {
                                    Console.WriteLine("Los valores ingresados corresponden a una Circunferencia.");
                                    Console.WriteLine($"RADIO: {RadioCircunferencia(valorA, valorB, valorC, valorD, valorE)}");
                                    Console.WriteLine("COORDENADAS DEL CENTRO: {0}", CoordenadasCentroCircunferencia(valorA, valorB, valorC, valorD, valorE));

                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Los valores ingresados en A y B son cero, por lo tanto su función es Lineal.");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error de ingreso... ");
            }
		}
    }
}
