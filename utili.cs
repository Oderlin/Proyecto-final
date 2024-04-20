class Utils{
  public static string input(string msg){
    Console.Write(msg);
    return Console.ReadLine()??"";
  }  

  public static void Pausa(string msg=""){
    Console.WriteLine(msg);
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
  }

  public static int InputInt(string msg){
    Console.Write(msg);
    int numero = 0;
    while(!int.TryParse(Console.ReadLine(), out numero)){
      Console.WriteLine("Ingrese el numero: ");
    }
    return numero;
  }

  public static string inputModificar(string msg, string valor){
    Console.Write($"El valor actual de {msg} es {valor}, digite el nuevo o presione enter para no modificar: ");
    string nuevoValor = Console.ReadLine()??"";
    if(nuevoValor != ""){
    valor = nuevoValor;
    }
    return valor;
  }

}