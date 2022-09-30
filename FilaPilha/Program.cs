 static void Fila()
{
    Queue<int> fila = new Queue<int>();
    fila.Enqueue(1);
    fila.Enqueue(2);
    fila.Enqueue(3);
    fila.Enqueue(4);

    foreach (var item in fila)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"Removendo \n{fila.Dequeue()}");
    foreach (var item in fila)
    {
        Console.WriteLine(item);
    }
}

Fila();

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Pilha");
static void Pilha()
{
    Stack<int> pilha = new Stack<int>();
    pilha.Push(1);
    pilha.Push(2);
    pilha.Push(3);
    foreach (var item in pilha)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"Removendo \n{pilha.Pop()}");
    foreach (var item in pilha)
    {
        Console.WriteLine(item);
    }

}

Pilha();

