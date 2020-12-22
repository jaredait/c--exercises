using System;

namespace Cambio_de_base_recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opc;

            Console.WriteLine("1. DEC a HEX\n2. HEX a DEC");
            try
            {
                opc = Convert.ToByte(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        HexADec_DriverCode();
                        break;
                    case 2:
                        DecAHex_DriverCode();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Fin del programa.");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }            
        }


        // Funcion que recibe un caracter y retorna su equivalente en decimal
        public static int ADecimal(char n)
        {
            int aux = 0;

            switch (n)
            {
                case '0':
                    aux = 0;
                    break;
                case '1':
                    aux = 1;
                    break;
                case '2':
                    aux = 2;
                    break;
                case '3':
                    aux = 3;
                    break;
                case '4':
                    aux = 4;
                    break;
                case '5':
                    aux = 5;
                    break;
                case '6':
                    aux = 6;
                    break;
                case '7':
                    aux = 7;
                    break;
                case '8':
                    aux = 8;
                    break;
                case '9':
                    aux = 9;
                    break;
                case 'A':
                    aux = 10;
                    break;
                case 'B':
                    aux = 11;
                    break;
                case 'C':
                    aux = 12;
                    break;
                case 'D':
                    aux = 13;
                    break;
                case 'E':
                    aux = 14;
                    break;
                case 'F':
                    aux = 15;
                    break;
                default:
                    throw new System.Exception();
            }
            return aux;
        }
        // Funcion que recibe un entero y retorna su equivalente en hexadecimal
        public static char AHexadecimal(int n)
        {
            char aux = '\0';

            if (n >= 0 && n <= 9)
                aux = Convert.ToChar(Convert.ToString(n));
            else
                switch (n)
                {
                    case 10:
                        aux = 'A';
                        break;
                    case 11:
                        aux = 'B';
                        break;
                    case 12:
                        aux = 'C';
                        break;
                    case 13:
                        aux = 'D';
                        break;
                    case 14:
                        aux = 'E';
                        break;
                    case 15:
                        aux = 'F';
                        break;
                    default:
                        throw new System.Exception();
                }
            return aux;
        }


        // Conversion de HEX a DEC mediante recursion
        public static int HexADec(string cadena, int indice)
        {
            int equivalente = 0;
            if (indice > 0)
            {
                // Conversion caracter por caracter de hexadecimal a decimal mediante la funcion ADecimal
                equivalente = ADecimal(Convert.ToChar(cadena.Substring(0, 1)));
                return equivalente * (int)Math.Pow(16, indice - 1) + HexADec(cadena.Substring(1, cadena.Length - 1), indice - 1);
            }
            return equivalente;
        }
        // Driver code de HexADec
        static void HexADec_DriverCode()
        {
            int numDec;
            Console.Write("Ingresa el numero decimal\nDEC = ");
            try
            {
                numDec = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("HEX = {0}", DecAHex(numDec));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        // Conversion de DEC a HEX mediante recursion
        public static string DecAHex(int numDec)
        {
            string numHex = string.Empty;
            int residuo;

            if (numDec < 15)
                return Convert.ToString(AHexadecimal(numDec));

            residuo = numDec % 16;
            return DecAHex(numDec/16) + numHex + AHexadecimal(residuo);
        }
        // Driver code de DecAHex
        static void DecAHex_DriverCode()
        {
            string numHex;
            Console.Write("Ingresa el numero hexadecimal\nHEX = ");
            try
            {
                numHex = Console.ReadLine();
                numHex = numHex.ToUpper();

                // Verificar si es que todos los caracteres pertenecen a la base hexadecimal
                foreach (char car in numHex)
                    ADecimal(car);

                Console.WriteLine("DEC = {0}", HexADec(numHex, numHex.Length));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
