// Las variables nos permiten almacenar información en la memoria de la computadora,
// para poder utilizarla en cualquier momento de la ejecución del programa.

// Console.WriteLine es un método que se usa para imprimir en la consola.
// Para escribir en consola se usa Console.WriteLine, y dentro de los paréntesis se coloca el
// texto que se quiere imprimir.

Console.WriteLine("Teoria y ejemplos de Variables");

// Variable de tipo int, se usa para almacenar números enteros.
int alturanEnCentimetros;
alturanEnCentimetros = 180;
Console.WriteLine("La altura en centimetros es: " + alturanEnCentimetros);

int edadDeAndres = 25;
Console.WriteLine("La edad de Andres es: " + edadDeAndres);

int distanciaDeLaTierraAlSolEnKilometros = 150_000_000; // Se pueden usar guiones bajos para separar los dígitos.
Console.WriteLine("Distancia de la tierra en kilometros es: " + distanciaDeLaTierraAlSolEnKilometros);

// int.MaxValue es una constante que contiene el valor máximo que puede almacenar una variable de tipo int.
int numeroSuperGrande = int.MaxValue;
Console.WriteLine("Numero maximo para la variable int : " + numeroSuperGrande);

// uint es un tipo de dato que se usa para almacenar números enteros positivos.
uint unint2 = 3_000_000_000; // 0 a hasta mas de 4 mil millones
Console.WriteLine("Ejemplo de unint2: " + unint2);

// long es un tipo de dato que se usa para almacenar números enteros que van desde -9,223,372,036,854,775,808 hasta 9,223,372,036,854,775,807.

long long1 = 8_000_000_000_000;
Console.WriteLine("Ejemplo de long1: " + long1);

// ulong es un tipo de dato que se usa para almacenar números enteros positivos que van desde 0 hasta 18,446,744,073,709,551,615.

ulong ulong1 = 18_000_000_000_000;
Console.WriteLine("Ejemplo de ulong1: " + ulong1);

// byte es un tipo de dato que se usa para almacenar números enteros positivos que van desde 0 hasta 255.
byte byt1 = 145;
Console.WriteLine("Ejemplo de byte: " + byt1);

// sbyte es un tipo de dato que se usa para almacenar números enteros que van desde -128 hasta 127.
sbyte sbyt1 = 120;
Console.WriteLine("Ejemplo de sbyte: " + sbyt1);

// short es un tipo de dato que se usa para almacenar números enteros que van desde -32,768 hasta 32,767.
short short1 = 30_000;
Console.WriteLine("Ejemplo de short: " + short1);

// unshort es un tipo de dato que se usa para almacenar números enteros que van desde 0 hasta 65,535.
ushort ushort1 = 60_000;
Console.WriteLine("Ejemplo de ushort1: " + ushort1);

// float es un tipo de dato que se usa para almacenar números decimales con una precisión de 7 dígitos.
float altura = 180.123456789f; // F es un sufijo que se usa para indicar que el número es de tipo float.
Console.WriteLine("La altura es: " + altura);

// double es un tipo de dato que se usa para almacenar números decimales con una precisión de 15 dígitos.
double anchura = 45.99; // D es un sufijo que se usa para indicar que el número es de tipo double.
Console.WriteLine("La anchura es: " + anchura);

// decimal es un tipo de dato que se usa para almacenar números decimales con una precisión de 28 dígitos.
decimal monto = 9.99m; // M es un sufijo que se usa para indicar que el número es de tipo decimal. La precision es de 28 digitos a 29 digitos. Se recomienda para temas de dinero.
Console.WriteLine("El monto es: " + monto);

// bool es un tipo de dato que se usa para almacenar valores de verdadero o falso.
bool soyFelipe = true;
bool dosMasDosEsCinco = false;
Console.WriteLine("Soy Felipe: " + soyFelipe);
Console.WriteLine("Dos mas dos es cinco: " + dosMasDosEsCinco);

// char es un tipo de dato que se usa para almacenar un solo carácter.
char primeraLetraDeABC = 'A'; // Se usa comillas simples para indicar que es un solo carácter.
Console.WriteLine("La primera letra de ABC es: " + primeraLetraDeABC);

// string es un tipo de dato que se usa para almacenar texto.
string Nombre = "Andres Espitia"; // Se usa comillas dobles para indicar que es un texto.
Console.WriteLine("El nombre de Andres es: " + Nombre);

// \ es un caracter de escape que se usa para indicar que el siguiente caracter es especial.
string text = "Mi amigo me dijo una vez: \"Me caes bien\"";
Console.WriteLine("Ejemplo de \\: ", text);

// @ es un caracter de escape que se usa para indicar que el texto se va a imprimir tal cual está escrito.
string carta = @"A quien pueda interesar, 

Estimado señor, debe usted saber que...

Atentamente, Andrés Espitia

";
Console.WriteLine("Ejemplo de texto con espacios de lineas: " + carta);

// @ se usa para indicar que el texto se va a imprimir tal cual está escrito.
string directorioDelArchivo = @"C:\Users\Andres\Documents\Proyectos";
Console.WriteLine("Ejemplo del @: " + directorioDelArchivo);

// Datetime es un tipo de dato que se usa para almacenar fechas y horas.
DateTime ahora = DateTime.Now;
Console.WriteLine("La fecha y hora actual es: " + ahora);

// Espesificar una fecha y hora.
DateTime primerDiaDelAño = new DateTime(2025, 1, 1, 2, 15, 23);
Console.WriteLine("El primer día del año 2025 y hora es: " + primerDiaDelAño);

// .Now.AddDays(1) se usa para sumar un día a la fecha actual.
DateTime mañana = DateTime.Now.AddDays(1);
Console.WriteLine("Mañana es: " + mañana);
Console.WriteLine("El dia de mañana es: " + mañana.Day);
Console.WriteLine("El mes es: " + mañana.Month);
Console.WriteLine("El año es: " + mañana.Year);
Console.WriteLine("El dia de la semana es: " + mañana.DayOfWeek);


// Reglas para las variables
// int 1Edad = 25; // No se puede empezar con un número.
// se puede usar guion bajo para separar palabras.
// int edad_de_andres = 25;
// int edadDeAndres = 25; // Camel Case, significa que la primera letra de la primera palabra es minúscula y la primera letra de las siguientes palabras es mayúscula.
// int EdadDeAndres = 25; // Pascal Case, significa que la primera letra de cada palabra es mayúscula.
// No usar - en las variables.
// int edad-de-andres = 25; // No se puede usar guion medio.


// Variables implicitas tipadas
// var se usa para declarar una variable sin especificar el tipo de dato.
var apellido = "Espitia";
Console.WriteLine("El apellido de Andres es: " + apellido);
var hoy = DateTime.Now;
Console.WriteLine("La fecha y hora actual es: " + hoy);
var float1 = 3.14;
Console.WriteLine("El valor de float1 es: " + float1);

// No se puede cambiar el tipo de dato de una variable implicita.
// var edad = 25;
// edad = "25"; // No se puede cambiar el tipo de dato de una variable implicita.

// Valores por defectos de distintos tipos de datos
 int edad = default;
 Console.WriteLine("La edad es: " + edad);
 edad = 8;

bool hoyEsViernes = default;
Console.WriteLine("Valor por defecto de un int: " + hoyEsViernes);

// El valor por defecto de default es NULL 

// Tipos de valor y de referencia
// Los tipos de valor almacenan el valor directamente en la memoria.
// stack: es una parte de la memoria que se usa para almacenar variables locales y parámetros de métodos.
// Los tipos de referencia almacenan una referencia a la memoria donde se encuentra el valor.
// heap: es una parte de la memoria que se usa para almacenar objetos y arreglos.
// Las variables de tipo de valor siempre contienen un valor.
// Las variables de tipo de referencia podrian no contener referencia alguna.
// Esto se expresa con null(nulo).
// Si una variable es igual a null, significa que no contiene ninguna referencia a la memoria.
// Es un tipo de referencia.
// No contiene una referencia a algun valor en el heap.
// String es un tipo de referencia.
// Ejemplo de tipos de valor: int, decimal, double, float, bool, char, datetime.

// Ejemplo de tipos de valor: int, decimal, double, float, bool, char, datetime.
// int? es un tipo de dato que se usa para almacenar números enteros que pueden ser nulos.
// ? es un sufijo que se usa para indicar que la variable puede ser nula.
int? peso = null;
Console.WriteLine("El valor por defecto de un int: " + peso);

// Ejemplo de tipos de referencia: string, object, array, class, interface.
//string? nombre = null;
//Console.WriteLine("El valor por defecto de un string: " + nombre.ToUpper());


// Expresiones - Operaciones binarias
// Operadores aritméticos: +, -, *, /, %.
// Operadores de comparación: ==, !=, >, <, >=, <=.
// Operadores lógicos: &&, ||, !.
// Operadores de asignación: =, +=, -=, *=, /=, %=.
// Operadores de incremento y decremento: ++, --.

// Operadores de concatenación: +.
var cantidad1 = 10;
var cantidad2 = 20;
var resultado = cantidad1 + cantidad2;
Console.WriteLine("El resultado de la suma de " + cantidad1 + " y " + cantidad2 +"  es:  " + resultado);

// Concatenar texto, se usa el operador + para concatenar texto.
var nombre = "Andres";
var apellido1 = "Espitia";
var resultadoString = nombre + apellido1;
Console.WriteLine("El resultado de la concatenación es: " + resultadoString);

// Operadores aritméticos - Suma, resta, multiplicación, división y residuo.
// +, -, *, /, %.
var cantidad3 = 7.1M;
var cantidad4 = 3.5M;
var resultadoSuma = cantidad3 + cantidad4;
var resultadoResta = cantidad3 - cantidad4;
var resultadoMultiplicacion = cantidad3 * cantidad4;
// Se usa (double) para convertir el resultado a un número decimal.
// Casteo, es la conversión de un tipo de dato a otro.
//var resultadoDivision = (double)cantidad3 / cantidad4; 
var resultadoDivision = cantidad3 / cantidad4;
var resultadoResiduo = cantidad3 % cantidad4;

Console.WriteLine("El resultado de la suma es: " + resultadoSuma);
Console.WriteLine("El resultado de la resta es: " + resultadoResta);
Console.WriteLine("El resultado de la multiplicación es: " + resultadoMultiplicacion);
Console.WriteLine("El resultado de la división es: " + resultadoDivision);
Console.WriteLine("El resultado del residuo es: " + resultadoResiduo);

// Overflow Aritmetico
// Cuando el resultado de una operación aritmética es mayor que el valor máximo que puede almacenar una variable, se produce un overflow aritmético.
// En C# se puede usar la palabra clave checked para detectar un overflow aritmético.
// El unchecked se usa para desactivar la detección de un overflow aritmético.

//checked
//{
//    var maximo1 = int.MaxValue;
//    var suma1 = maximo1 + 1;
//    Console.WriteLine("El valor máximo de un int es: " + maximo1);
//    Console.WriteLine("El resultado de la suma es: " + suma1);
//}

// checked
// Este codigo genera una excepcion de tipo System.OverflowException
// Para evitar que se genere la excepcion se puede usar la palabra clave unchecked.
var maximo = int.MaxValue;
var suma = unchecked(maximo + 1);
Console.WriteLine(maximo);
Console.WriteLine(suma);

// Interpolacion de strings
// Se usa el signo $ antes de las comillas para indicar que se va a interpolar un string.
var cantidad5 = 7;
var cantidad6 = 4;
var resultado1 = cantidad5 + cantidad6;
var nombre2 = "Andres";
// Opcion 1, concatenar con el signo +
Console.WriteLine("El resultado de la suma de " + cantidad1 + " y " + cantidad2 + "  es:  " + resultado);
// Opcion 2, interpolacion usando el signo $
Console.WriteLine($"El resultado de la suma de {cantidad5} y {cantidad6} es: {resultado1}");
// Opcion 3, interpolacion usando el signo $ usando string
Console.WriteLine($"El nombre de Andres en mayuscula es : {nombre2.ToUpper()}");

// Operaciones Unarias
// Operadores de incremento y decremento: ++, --.
var cantidad7 = 7;
var cantidad8 = 5;
var cantidadPorMenos1 = -cantidad7; // (-1) * cantidad7
//Console.WriteLine("El resultado de la cantidad por menos 1 es: " + cantidadPorMenos1);
//cantidad7++; // cantidad7 = cantidad7 + 1
//cantidad7--; // cantidad7 = cantidad7 - 1
//Console.WriteLine("El resultado de la cantidad7++ es: " + cantidad7);
//Console.WriteLine("El resultado de la cantidad7-- es: " + cantidad7);
//++cantidad7; // cantidad7 = cantidad7 + 1
//--cantidad7; // cantidad7 = cantidad7 - 1
//Console.WriteLine("El resultado de la ++cantidad7 es: " + cantidad7);
//Console.WriteLine("El resultado de la --cantidad7 es: " + cantidad7);

// Si el ++ esta por delante de la variable, primero se incrementa la variable y luego se usa el valor.
// Si el ++ esta por detras de la variable, primero se usa el valor de la variable y luego se incrementa la variable.
var suma2 = cantidad7 + cantidad8; // cantidad7 = cantidad7 + 1, cantidad7 + cantidad8 // 8 + 5
Console.WriteLine("El resultado de la suma es: " + suma2);


// Expresiones Void
// Las expresiones void no devuelven ningún valor.

// Operadores de asignación: =, +=, -=, *=, /=, %=.
var cantidad9 = 7m;
var cantidad10 = 5m;
// No se altera la cantidad9
var suma3 = cantidad9 + cantidad10;
/*cantidad7 += cantidad8;*/ // cantidad7 = cantidad7 + cantidad8
//Console.WriteLine("Cantidad9 es: " + cantidad9);

//cantidad9 -= cantidad10; // cantidad9 = cantidad9 - cantidad10
//Console.WriteLine("Cantidad9 es: " + cantidad9);

//cantidad9 *= cantidad10; // cantidad9 = cantidad9 * cantidad10
//Console.WriteLine("Cantidad9 es: " + cantidad9);

//cantidad9 /= cantidad10; // cantidad9 = cantidad9 / cantidad10
//Console.WriteLine("Cantidad9 es: " + cantidad9);

cantidad9 %= cantidad10; // cantidad9 = cantidad9 % cantidad10
Console.WriteLine("Cantidad9 es: " + cantidad9);

var nombre3 = "Andres";
var apellido2 = " Espitia";

nombre3 += apellido2; // nombre3 = nombre3 + apellido2
Console.WriteLine("El nombre completo es: " + nombre3);

// Ordenes de procedencia de las operaciones
var cantidad11 = 1;
var cantidad12 = 2;
var cantidad13 = 3;
var cantidad14 = cantidad11 + cantidad12 + cantidad13; // 6
var cantidad15 = cantidad11 + cantidad12 * cantidad13; // 7
var cantidad16 = (cantidad11 + cantidad12) * cantidad13; // 9   

// No hacer esto, es confuso.
var cantidad17 = (++cantidad11 + cantidad12++) * (cantidad13 + --cantidad13); // ??

// Lo mejor es separar las operaciones.
var cantidad18 = ++cantidad11 + cantidad12;
var cantidad19 = cantidad13 + --cantidad13;
var cantidad20 = cantidad18 * cantidad19;

Console.WriteLine("El resultado de la cantidad15 es: " + cantidad16);


// Constantes y valores magicos
// Las constantes son variables cuyo valor no cambia durante la ejecución del programa.
// Se usa la palabra clave const para declarar una constante.
// Se recomienda usar constantes en lugar de valores mágicos.

var cantidad21 = 1;
cantidad21 = 2;

const int miConstante = 7;

const double FactorConversionKilometroPorHoraAMetrosPorSegundo = 3.6;

// velocidad en kilometros por hora (KPH)
// velocidad en metros por segundo (MPS)

var velocidadKPH = 100;
var velocidadMPS = velocidadKPH / FactorConversionKilometroPorHoraAMetrosPorSegundo;


// Advertencia y Errores en C#
// Control + . para corregir errores.
// Evitar advertencia, Ctrl + . y seleccionar la opción: "Suprimir advertencia en el archivo".
// #pragma warning disable CS0219
// Lo que este dentro de #pragma warning disable CS0219 y #pragma warning restore CS0219 no generara advertencias.
// #pragma warning restore CS0219

// Ser extricto con las advertencias.
// Ctrl + . = Suppress or Configure issues. = Configure CS0219. = Error.


// Resumen
// Las sentencias de alto nivel permiten archivos de código más limpios y fáciles de leer.
// Solo se permite un archivo de alto nivel por programa.
// Las variables se usan para almacenar información en la memoria de la computadora.
// Los tipos de datos se usan para especificar el tipo de información que se va a almacenar en una variable.
// Las variables de tipo de valor almacenan el valor directamente en la memoria.
// Las variables de tipo de referencia almacenan una referencia a la memoria donde se encuentra el valor.
// Los tipos de referencia pueden ser nulos.
// Nulificables se usan para almacenar valores nulos.
// Expresiones void no devuelven ningún valor.
// Las constantes son variables cuyo valor no cambia durante la ejecución del programa.



