using System;

public class Stack
{
    private int maxSize;     // Tamaño máximo de la pila
    private int top;         // Índice del elemento superior
    private int[] stackArray; // Arreglo que almacena los elementos de la pila

    public Stack(int size)
    {
        maxSize = size;          // Inicializa el tamaño máximo
        stackArray = new int[maxSize]; // Crea el arreglo con el tamaño especificado
        top = -1;                // Inicializa el índice superior en -1 (pila vacía)
    }

    public bool IsEmpty()
    {
        return (top == -1); // Comprueba si la pila está vacía (índice superior en -1)
    }

    public bool IsFull()
    {
        return (top == maxSize - 1); // Comprueba si la pila está llena (índice superior igual al tamaño máximo - 1)
    }

    public void Push(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("La pila está llena. No se puede insertar más elementos.");
        }
        else
        {
            stackArray[++top] = item; // Inserta un elemento en la posición superior y luego incrementa el índice superior
            Console.WriteLine($"Se insertó {item} en la pila.");
        }
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía. No se puede realizar la operación Pop.");
            return -1;
        }
        else
        {
            int poppedItem = stackArray[top--]; // Obtiene el elemento en la posición superior y luego decrementa el índice superior
            Console.WriteLine($"Se retiró {poppedItem} de la pila.");
            return poppedItem;
        }
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía. No se puede realizar la operación Peek.");
            return -1;
        }
        else
        {
            return stackArray[top]; // Retorna el elemento en la posición superior sin modificar el índice superior
        }
    }
}

class Program
{
    static void Main()
    {
        Stack stack = new Stack(5);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        int peekedItem = stack.Peek();
        Console.WriteLine($"Elemento en la cima de la pila: {peekedItem}");

        int poppedItem = stack.Pop();
        Console.WriteLine($"Elemento retirado de la pila: {poppedItem}");
    }
}