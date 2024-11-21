int xd;
double grande = 12.5; 
float chiquito = 12.5f; //lleva forzosamente una F
bool hayCerveza = false;
string name = "hector";
char l = 'a';

//Puedes hacer todo lo que necesites en VAR
var anything = 15;
var name2 = "Juan";

//Arrays
var numbers = new int[5]; //Se deben especificar los corchetes al principio y al final
numbers[0] = 1; //la posicion 0 siempre es la primera, todos los conteos inician desde 0
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

var numbers1 = new int[5] {1,2,3,4,5}; //se puede definir mas facil de esta manera


//sentencias condicionales

var age = 60;
//if (age > 60)
//{
//    Console.WriteLine("Es de la tercera edad");
//}
//else
//{
//    Console.WriteLine(age);
//}

switch (age)
{
    case < 18:
        Console.WriteLine("Es Menor de edad");
        break;
    case >= 18:
        switch (age) {
            case >= 60:
                Console.WriteLine("Es viejito");
            break;

            case < 60:
                Console.WriteLine("Es un adulto promedio");
                break;
        }
        break;

    default:
        Console.WriteLine("ni idea que pijas hiciste mal");
        break;
}