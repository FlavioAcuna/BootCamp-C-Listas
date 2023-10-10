
List<string> listNombres = new List<string>();

listNombres.Add("Alex");
listNombres.Add("Martha");
listNombres.Add("Roger");
listNombres.Add("Julieta");
listNombres.Add("Alan");
//Seleccionar el lugar donde insertar el dato
listNombres.Insert(3, "Maria");
//seleccionar solo un valor de la lista
Console.WriteLine(listNombres[2]);

Console.WriteLine("------------");

//Mostrar todos los elementos de la lista a diferencia de arreglos en la lista es .count
for (int i = 0; i < listNombres.Count; i++)
{
    Console.WriteLine(listNombres[i]);
}
//Remover elemento con string
listNombres.Remove("Roger");
//Remover elemento con el indice
listNombres.RemoveAt(1);

Console.WriteLine("------------");
//ForEach en lista
foreach (string nombre in listNombres)
{
    Console.WriteLine(nombre);
}