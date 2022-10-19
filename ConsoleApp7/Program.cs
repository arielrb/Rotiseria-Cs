/*
    Validar sí el usuario existe, en caso contrario registrarse

    Saludo de bienvenida a usuarios existentes

    El programa debe repetirse hasta que se hayan registrado 10 usuarios
 */
class Rotiseria
{
    static void Main(string[] args)
    {

        string[] userNames = new string[10] { "Migue", "dasd", "sda", "dasd", "sasd", "sad", "asd", "asdf", "afsfa", "asfsaf" };
        int arrayCurrentIndex = 9;
        bool userType;

        Console.WriteLine("Rotisería a la C#");

        while (arrayCurrentIndex < 10)
        {
            //Sin este if, se genera un overflow
            /*
            if(arrayCurrentIndex == 10) 
            {
                Console.WriteLine("Ya no podemos aceptar mas usuarios, lo siento mucho!!!");
                Environment.Exit(0);
            }*/
            Console.Write("\n Estas en el sistema? Escribir - True / False: ");
            userType = bool.Parse(Console.ReadLine());

            if (userType == true)
            {
                Console.Write("\n Joya!, si estas en el sistema, por favor escribe tu nombre: ");
                string userToSearch = Console.ReadLine();

                Console.WriteLine($"\n El usuario solicitado es {userToSearch}");
                int index = Array.IndexOf(userNames, userToSearch);
                if (index == -1)
                {
                    Console.WriteLine("El usuario no lo encontramos! ¿prueba de nuevo?");
                }
                else
                {
                    Console.WriteLine($"\n Hola! ¿puedo tomar tu pedido {userNames[index]}?");
                }
            }
            else if(userType == false)
            {
                Console.WriteLine("Por favor escribe tu nombre para registrar \n");
                userNames[arrayCurrentIndex] = Console.ReadLine();
                Console.WriteLine("Tu usuario fue creado correctamente \n" +
                    $"Tu nombre de usuario desde ahora es {userNames[arrayCurrentIndex]}");
                arrayCurrentIndex++;

            }
        }
        Console.WriteLine("El restaurante esta lleno! La lista de clientes es: \n");
        int auxiliarIndex = 0;
        foreach( string item in userNames)
        {
            Console.WriteLine($"\n Usuario numero: {auxiliarIndex} y el cliente {userNames[auxiliarIndex]}");
            auxiliarIndex++;
        }
        Console.WriteLine("Gracias por elegirnos!");
        Environment.Exit(0);
    }
}