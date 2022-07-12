


using System.Net;
//Creamos un requesty un response
//request = peticion al servidor del API
//response = guardamos los datos que obtenemos de la peticion

HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://api.adviceslip.com/advice");
HttpWebResponse response = (HttpWebResponse)request.GetResponse();

//creamos un stream
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);
    

string json = reader.ReadToEnd();

Console.WriteLine("Como se llama usted? ");
string nombre = Console.ReadLine();
nombre = nombre.UpperFirstChar();
Console.WriteLine($"Bievenido {nombre}, que dia es hoy?: ");
string dia = Console.ReadLine();
dia = dia.UpperFirstChar();
switch (dia)
{
    case "Lunes":
        Console.WriteLine($"El consejo del dia de hoy es: \n{json}");
    break;
    case "Martes":
        Console.WriteLine($"El consejo del dia de hoy es: \n{json}");
    break;
    case "Miercoles":
        Console.WriteLine($"El consejo del dia de hoy es: \n{json}");
    break;
    case "Jueves":
        Console.WriteLine($"El consejo del dia de hoy es: \n{json}");
    break;
    case "Viernes":
        Console.WriteLine($"El consejo del dia de hoy es: \n{json}");
    break;
    case "Sabado":
        Console.WriteLine($"El consejo del dia de hoy es: \n{json}");
    break;
    case "Domingo":
        Console.WriteLine($"El consejo del dia de hoy es: \n{json}");
    break;
    default:
        Console.WriteLine("No escribiste un dia valido :(");
    break;
}



public static class StringExtension { 
    public static string UpperFirstChar(this string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return null;
    }
    char[] chars = input.ToCharArray();
    chars[0] = char.ToUpper(chars[0]);
    return new string(chars);
    }
}