// Lógica Booleana

// Descisiones e iteraciones

var cantidad1 = 5;
var cantidad2 = 5;

var cantidadIgualACantidad2 = cantidad1 == cantidad2; // true, porque 5 es igual a 5
var cantidadDiferenteDeCantidad2 = cantidad1 != cantidad2; // false, porque 5 no es diferente de 5
Console.WriteLine($"Son {cantidad1} y {cantidad2} iguales?:  {cantidadIgualACantidad2}");
Console.WriteLine($"Son {cantidad1} y {cantidad2} diferentes?:  {cantidadDiferenteDeCantidad2}");

// Operadores de comparación, mayor que.
// Menor que = <
// Mayor que = >
// Menor o igual que = <=
// Mayor o igual que = >=

var esCantidad1MenorQue10 = cantidad1 < 10; // true, porque 5 es menor que 10
var esCantidad1MayorQue10 = cantidad1 > 10; // false, porque 5 no es mayor que 10

var esCantidad1MenorOIgualQue10 = cantidad1 <= 10; // true, porque 5 es menor que 10
var esCantidad1MayorOIgualQue10 = cantidad1 >= 10; // false, porque 5 no es mayor ni igual que 10

// Con strings, los operadores de comparación funcionan de la misma manera
var nombre1 = "Juan";
var nombre2 = "Pedro";

var sonLosNombresIguales = nombre1 == nombre2; // false, porque Juan no es igual a Pedro
var sonLosNombresDiferentes = nombre1 != nombre2; // true, porque Juan es diferente a Pedro

// En versiones mas recientes de C# NO se recomienda usar == para verificar si algo es nullo, se prefiere usar is null
var esNombre1Nulo = nombre1 is null; // false, porque nombre1 no es nulo
var esNombre1NoNulo = nombre1 is not null; // true, porque nombre1 no es nulo

Console.WriteLine($"Es {nombre1} igual a nulo?: " + esNombre1Nulo);
Console.WriteLine($"Es {nombre1} diferente a nulo?: " + esNombre1NoNulo);

// Operadores condicionales AND y OR (Booleanos)
// AND = &&
// && es verdadero si ambos operandos son verdaderos

// true && true = true
// true && false = false
// false && true = false
// false && false = false
var cantidad3 = 6;
var estaEntre5y10 = cantidad3 > 5 && cantidad3 < 10; // true, porque 6 es mayor que 5 y menor que 10
Console.WriteLine($"Es {cantidad3} mayor que 5 y menor que 10?: " + estaEntre5y10);

// OR = ||
// || es verdadero si al menos uno de los operandos es verdadero
// alt + 124 = |

// true || true = true
// true || false = true
// false || true = true
// false || false = false
var cantidad1Es5o6 = cantidad3 == 5 || cantidad3 == 6; // true, porque 6 es igual a 6
Console.WriteLine($"Es {cantidad3} igual a 5 o 6?: " + cantidad1Es5o6);

// Error de referencia nula
// Si intentamos acceder a una propiedad de un objeto nulo, se lanza una excepción de referencia nula
// Para evitar esto, podemos usar el operador de nulabilidad ?.
string? apellido = null;
var estaElApellidoEnMayuscula = apellido is not null && apellido == apellido.ToUpper(); // true, porque Espitia es igual a Espitia
Console.WriteLine($"Esta el apellido en mayuscula?: " + estaElApellidoEnMayuscula);


// Condicional IF
// if (condicion)
// Se ejecuta si la condición es verdadera

var cantidad4 = 6;
if (cantidad4 > 5)
{
    Console.WriteLine($"{cantidad4} es mayor que 5");
} else if (cantidad4 == 3)
{
    Console.WriteLine("El valor es 3!");
}
else
{
    Console.WriteLine("Es menor o igual a 5");
}

Console.WriteLine("Fin del programa");


// Operador ternario

bool usuarioEstaLogueado = false;

// Forma tradicional
// Se usa para asignar valores a variables
//string mensajeBienvenida;
//if (usuarioEstaLogueado)
//{
//    mensajeBienvenida = "¡Que bueno que has vuelto!";
//} else
//{
//    mensajeBienvenida = "Logueate para comenzar";
//}

// Forma corta
// Solo se puede usar para asignar valores a variables
// <condicion> ? <si la condicion es true> : <si la condicion es false>
string mensajeBienvenida = usuarioEstaLogueado ? "¡Que bueno que has vuelto!" : "Logueate para comenzar";
 
Console.WriteLine(mensajeBienvenida);

// Sentencia Switch
// Se recomienda utilizar switch cuando la comparacion la hacemos siempre sobre un mismo valor.

var lugar = 4;

// Esto es funcional, pero no es la mejor práctica
//if (lugar == 1)
//{
//    Console.WriteLine("Primer lugar");
//}
//else if (lugar == 2)
//{
//    Console.WriteLine("Segundo lugar");
//}
//else if (lugar == 3)
//{
//    Console.WriteLine("Tercer lugar");
//}
//else
//{
//    Console.WriteLine("No es un lugar valido");
//}

// Mejor práctica
switch (lugar)
{
    case 1:
        Console.WriteLine("Primer lugar");
        break;
    case 2:
        Console.WriteLine("Segundo lugar");
        break;
    case 3:
        Console.WriteLine("Tercer lugar");
        break;
    case 4:
    case 5:
        Console.WriteLine("Cuarto o quinto lugar");
        break;
    default:
        // Se ejecuta si no se cumple ningun caso
        Console.WriteLine("No es un lugar valido");
        break;
}


// Patrones relacionales

var temperatura = 37;

var mensaje = temperatura switch
{
    37 => "No tienes ninguna condicion",
    > 37 => "Tienes fiebre",
    < 37 => "Estas por debajo de la temperatura normal"
};

Console.WriteLine(mensaje);

// Patrones logicos

// Ejemplo 1: Not
string? apellido1 = null;
if (apellido1 is not null)
{
    Console.WriteLine(apellido1.ToUpper());
}

Console.WriteLine("Fin");

// Ejemplo 2: And
// parmashing, es una tecnica que se usa para pasar parametros a un metodo
// No se usa el operador && porque no es un operador de comparacion, se usa la palabra and
var temperatura1 = 41;
var mensaje1 = temperatura1 switch
{
    37 => "No tienes ninguna condicion",
    > 37 and < 39 => "Tienes fiebre",
    >= 39 and < 43 => "Tienes fiebre alta",
    >= 43 => "Estas en peligro",
    < 37 => "Estas por debajo de la temperatura normal"
};

Console.WriteLine(mensaje1);

// Ejemplo 3: Or
// _ es un comodin que se usa para cualquier otro caso

var hoy = DateTime.Today;
var estacion = hoy.Month switch
{
    3 or 4 or 5 => "Primavera",
    6 or 7 or 8 => "Verano",
    9 or 10 or 11 => "Otoño",
    12 or 1 or 2 => "Invierno",
    _ => throw new ApplicationException("Mes invalido")
};

Console.WriteLine(estacion);

// Expresiones Switch y Discard 

var lugar1 = 1;

// Esto es funcional, pero no es la mejor práctica
// Opcion 1, usando switch
switch (lugar1)
{
    case 1:
        Console.WriteLine("Primer lugar");
        break;
    case 2:
        Console.WriteLine("Segundo lugar");
        break;
    case 3:
        Console.WriteLine("Tercer lugar");
        break;
    case 4:
    case 5:
        Console.WriteLine("Cuarto o quinto lugar");
        break;
    default:
        // Se ejecuta si no se cumple ningun caso
        Console.WriteLine("No es un lugar valido");
        break;
}

// Discard "_" indicar que una variable no se va a usar
// Opcion 2, usando switch y discard
var mensaje2 = lugar switch
{
    1 => "Primer lugar",
    2 => "Segundo lugar",
    3 => "Tercer lugar",
    4 or 5 => "Cuarto o quinto lugar",
    _ => "No es un lugar valido"
};

Console.WriteLine(mensaje2);



// Bluce While
// Se ejecuta mientras la condicion sea verdadera

var contador = 1;
// while, significa mientras

// si la condicion while es falsa, el bucle no se ejecuta
while (contador <= 10)
{
    Console.WriteLine(contador);
    contador++; // contador = contador + 1
}

var balance = 200m;
var interes = 1.07m;
var contadorInteres = 1;
while (contadorInteres <= 20)
{
    balance *= interes;
    contadorInteres++;
}

Console.WriteLine($"Balance en el año {contadorInteres}: {balance}");


// Bucle Do While
// Se ejecuta al menos una vez, y luego se ejecuta mientras la condicion sea verdadera
// La diferencia con el while es que el do while se ejecuta al menos una vez

var contador2 = 1;
//while (contador2 > 10)
//{
//    Console.WriteLine(contador2);
//    contador++; // contador2 = contador2 + 1
//}

// Si la condicion es falsa, el bucle se ejecuta al menos una vez
do
{
    Console.WriteLine(contador2);
    contador2++; // contador2 = contador2 + 1
} while (contador2 > 10);

Console.WriteLine("Fin del programa");

// Bucle For
// Se ejecuta un numero determinado de veces

// La diferencia entre el while y el for es que el for tiene la inicializacion, la condicion y la modificacion en una sola linea
// Si yo quiero usar la variable contador2 en otro lugar, debo declararla fuera del bucle

//int contador3 = 1; // Inicializacion
//while (contador3 <= 10) // Condicion
//{ // Bloque de codigo
//    Console.WriteLine(contador3);
//    contador3++; // Modificacion de la variable inicializada
//}

// for (inicializacion; condicion; modificacion)
for (int contador4 = 1; contador4 <= 10; contador4++)
{
    Console.WriteLine(contador4);
}


// Bucle For Each (foreach)
// Se usa para recorrer colecciones de datos
// Nos permite iterar sobre cada elemento de una coleccion

// foreach = para cada
var nombre3 = "Andres";
foreach (var letra in nombre3)
{
    Console.WriteLine(letra); // Letra = A, n, d, r, e, s
}


// Sentencias de Saltos Break y Continue
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break; // Sale del bucle, no se ejecuta el resto del bucle, llegaria hasta el 4
        //continue; // Salta la iteracion actual, no se ejecuta el resto del bloque, llegaria hasta el 10
    } 

    Console.WriteLine(i);
}

Console.WriteLine("Fin del programa");


// Bucle infinito

//while (true)
//{
//    Console.WriteLine("Este codigo no se detiene ");
//}

//for (; ; )
//{
//    Console.WriteLine("Este codigo no se detiene ");
//}

while (true)
{
    Console.WriteLine("Te damos la bienvenida a la calculadora de suma con C#");
    Console.Write("Por favor, ingresa el primer numero: ");
    var entradaUsuario = Console.ReadLine();
    if (entradaUsuario is null)
    {
        Console.WriteLine("No ingresaste ningun valor");
        continue;
    }
    var numero1 = decimal.Parse(entradaUsuario); // Podria fallar si el usuario ingresa un valor no numerico
    Console.Write("Por favor, ingresa el segundo numero: ");
    entradaUsuario = Console.ReadLine();
    if (entradaUsuario is null)
    {
        Console.WriteLine("No ingresaste ningun valor");
        continue;
    }
    var numero2 = decimal.Parse(entradaUsuario);
    Console.WriteLine($"El resultado de la suma de {numero1} y {numero2} es: {numero1 + numero2}");
    Console.Write("Deseas hacer otra suma? (y/n): ");
    entradaUsuario = Console.ReadLine();
    if (entradaUsuario != "y")
    {
        break;
    }
}

Console.WriteLine("Gracias por usar la calculadora de suma con C#");



// RESUMEN

// 1. logica booleana, operadores de comparacion, operadores logicos, if, switch, operador ternario
// 2. Operadores condicionales AND y OR (Booleanos)
// 3. && es verdadero si ambos operandos son verdaderos
// 4. || es verdadero si al menos uno de los operandos es verdadero
// 5. Sentencias de seleccion: if, switch
// 6. Bucles: while, do while, for, foreach
// 7. Sentencias de saltos: break, continue
// 8. Bucles infinitos