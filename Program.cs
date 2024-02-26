namespace ejercicio_en_clase_2402;

class Program
{
    static void Main(string[] args)
    {




        Console.WriteLine("EJERCICIO 1: PRIMEROS 5 NUMEROS PARES");
       for(int i = 1; i<=11; i++)
        {
           
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                i++;
            }
           
           
        }


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 2: PRIMER ENTERO DIVISIBLE");
        int suma = 0;
        for (int j = 0; j<=10; j++)

        {
            suma += j;
           

        }

        Console.WriteLine($"EL TOTAL DE LA SUMA ES:  " + suma);

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 3: ENTEROS POSITIVOS Y NEGATIVOS");


        int num1;
        int sumi = 0;


        do
        {
            Console.WriteLine("INGRESE NUMEROS POSITIVOS PARA INCIAR LA SUMA Y UN NEGATIVO PARA PARAR LA SUMA");
            num1 = int.Parse(Console.ReadLine());
            if (num1 >= 0)
            {
                sumi += num1;
            }


        } while (num1 >=0);
        Console.WriteLine($"EL TOTAL DE LA SUMA ES: " + sumi);


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 4: DIVISIBLES ENTRE 7 Y 11");

    int numdiv = 1;
        while (true)        {
            if (numdiv % 7 == 0 && numdiv % 11 == 0)            {
                Console.WriteLine($"El primer número entero positivo divisible entre 7 y 11 es: {numdiv}");                break;
            }           
            numdiv ++;        
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 5: CONTRASEÑA JUTIAPA");


        string contraseñaCorrecta = "jutiapa";
        string contraseñaIngresada;

        do
        {
            Console.Write("Ingresa la contraseña: ");
            contraseñaIngresada = Console.ReadLine();
        } while (contraseñaIngresada != contraseñaCorrecta);

        Console.WriteLine("¡Contraseña correcta!");


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 6: NUMERO ALEATORIO");

        Random random = new Random();
        int numeroAleatorio = 7;
        int intento;

        do
        {
            Console.Write("Adivina el número (entre 1 y 100): ");
            intento = int.Parse(Console.ReadLine());

            if (intento < numeroAleatorio)
            {
                Console.WriteLine("El número es mayor.");
            }
            else if (intento > numeroAleatorio)
            {
                Console.WriteLine("El número es menor.");
            }
            else
            {
                Console.WriteLine("¡Correcto! Has adivinado el número.");
            }
        } while (intento != numeroAleatorio);

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 7: PUEDE GRADUARSE");

        {
        bool todasAsignaturasAprobadas;
        double promedioGeneral;
        bool sinSancionPorComportamiento;

        // Solicitar al usuario que ingrese el estado de cada condición
        Console.WriteLine("Por favor, ingrese 's' si el estudiante ha aprobado todas las asignaturas, de lo contrario, ingrese 'n':");
        char respuesta = ' ';
        do
        {
            Console.Write("¿Todas las asignaturas aprobadas? (s/n): ");
            respuesta = Console.ReadLine().ToLower()[0];
        } while (respuesta != 's' && respuesta != 'n');

        todasAsignaturasAprobadas = respuesta == 's';

        Console.Write("Ingrese el promedio general del estudiante: ");
        promedioGeneral = double.Parse(Console.ReadLine());

        Console.WriteLine("¿El estudiante ha sido sancionado por mal comportamiento? (s/n): ");
        respuesta = ' ';
        do
        {
            Console.Write("¿Sin sanción por mal comportamiento? (s/n): ");
            respuesta = Console.ReadLine().ToLower()[0];
        } while (respuesta != 's' && respuesta != 'n');

        sinSancionPorComportamiento = respuesta == 's';

        // Verificar si el estudiante puede graduarse
        if (todasAsignaturasAprobadas && promedioGeneral >= 70 && sinSancionPorComportamiento)
        {
            Console.WriteLine("El estudiante puede graduarse.");
        }
        else
        {
            Console.WriteLine("El estudiante no cumple con los requisitos para graduarse.");
        }
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 8: PRESTAR LIBRO");

            {
        bool libroFiccion;
        bool libroNoFiccion;
        bool libroReferencia;
        bool disponible;
        bool mayorDeEdad;
        bool esMiembroPremium;
        int librosPrestados;

        // Solicitar al usuario que ingrese la información sobre el libro y el usuario
        Console.WriteLine("¿El libro es de ficción? (s/n):");
        char respuesta = ' ';
        do
        {
            Console.Write("Respuesta (s/n): ");
            respuesta = Console.ReadLine().ToLower()[0];
        } while (respuesta != 's' && respuesta != 'n');

        libroFiccion = respuesta == 's';

        Console.WriteLine("¿El libro es de no ficción? (s/n):");
        respuesta = ' ';
        do
        {
            Console.Write("Respuesta (s/n): ");
            respuesta = Console.ReadLine().ToLower()[0];
        } while (respuesta != 's' && respuesta != 'n');

        libroNoFiccion = respuesta == 's';

        Console.WriteLine("¿El libro es de referencia? (s/n):");
        respuesta = ' ';
        do
        {
            Console.Write("Respuesta (s/n): ");
            respuesta = Console.ReadLine().ToLower()[0];
        } while (respuesta != 's' && respuesta != 'n');

        libroReferencia = respuesta == 's';

        Console.WriteLine("¿El libro está disponible? (s/n):");
        respuesta = ' ';
        do
        {
            Console.Write("Respuesta (s/n): ");
            respuesta = Console.ReadLine().ToLower()[0];
        } while (respuesta != 's' && respuesta != 'n');

        disponible = respuesta == 's';

        Console.WriteLine("¿El usuario es mayor de 18 años? (s/n):");
        respuesta = ' ';
        do
        {
            Console.Write("Respuesta (s/n): ");
            respuesta = Console.ReadLine().ToLower()[0];
        } while (respuesta != 's' && respuesta != 'n');

        mayorDeEdad = respuesta == 's';

        Console.WriteLine("¿El usuario es miembro premium? (s/n):");
        respuesta = ' ';
        do
        {
            Console.Write("Respuesta (s/n): ");
            respuesta = Console.ReadLine().ToLower()[0];
        } while (respuesta != 's' && respuesta != 'n');

        esMiembroPremium = respuesta == 's';

        Console.WriteLine("¿Cuántos libros tiene actualmente prestados el usuario?:");
        librosPrestados = int.Parse(Console.ReadLine());

        // Verificar si el libro puede ser prestado
        if ((libroFiccion && disponible) || (libroNoFiccion && mayorDeEdad) || (libroReferencia && esMiembroPremium && librosPrestados < 3))
        {
            Console.WriteLine("El libro puede ser prestado al usuario.");
        }
        else
        {
            Console.WriteLine("El libro no puede ser prestado al usuario.");
        }
    }

    }
    
}
