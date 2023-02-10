/*

int[] numbers;			 Declara un arreglo 'numbers' de cualquier longitud
numbers = new int[10];   'numbers' es un arreglo de 10 enteros
numbers = new int[20];   Ahora 'numbers' es un arreglo de 20 enteros


int[] numbers = new int[5] {1, 2, 3, 4, 5};						Así se declara un arreglo inicializándolo
string[] names = new string[3] {"Matt", "Joanne", "Robert"};

int[] numbers = new int[] {1, 2, 3, 4, 5};						La longitud puede omitirse por ser inicializado
string[] names = new string[] {"Matt", "Joanne", "Robert"};

int[] numbers = {1, 2, 3, 4, 5};						El 'new' también puede omitirse
string[] names = {"Matt", "Joanne", "Robert"};

int[,] numbers = new int[3, 2] { {1, 2}, {3, 4}, {5, 6} };						Así se declara un arreglo bidimendional
string[,] siblings = new string[2, 2] { {"Mike","Amy"}, {"Mary","Albert"} };    o simplemente un arreglo de un arreglo

int[,] numbers = new int[,] { {1, 2}, {3, 4}, {5, 6} };                         También se puede omitir la longitud
string[,] siblings = new string[,] { {"Mike","Amy"}, {"Mary","Albert"} };

int[,] numbers = { {1, 2}, {3, 4}, {5, 6} };						El 'new' también puede omitirse
string[,] siblings = { {"Mike", "Amy"}, {"Mary", "Albert"} };

Los areglos tienen propiedades por ser considerados como un objeto:

string nombre,apellido;
string[] datos = {nombre, apellido};

* Longitud de 'datos': int Length.datos
* Longitud de 'nombre': int Length.nombre o también int Length.datos[0]

*/