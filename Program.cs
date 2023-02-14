using System;
class Nodo
{
    public int elemento;
    public Nodo next;
    public Nodo(int dato)
    {
        this.elemento = dato;
        this.next = null;
    }
}
class Lista
{
    public Nodo head;
    public Nodo tail;
    public int lenght;
    public Lista()
    {
        this.head = null;
        this.tail = null;
        this.lenght = 0;
    }
    public void print()
    {
        Nodo temp = this.head;
        while (temp != null)
        {
            Console.Write(temp.elemento);
            if (temp.next != null)
            {
                Console.Write(" -> ");
            }
            temp = temp.next;
        }
        Console.WriteLine();
    }
    public bool append(int dato)
    {
        Nodo nodo = new Nodo(dato);
        if (this.lenght == 0)
        {
            this.head = nodo;
            this.tail = nodo;
        }
        else
        {
            this.tail.next = nodo;
            this.tail = nodo;
        }
        this.lenght++;
        return true;
    }
    public Lista intercalar_lista(Lista lista)
    {
        Lista lista_intercalada = new Lista();
        Nodo temp1 = this.head;
        Nodo temp2 = lista.head;
        if (this.lenght == lista.lenght)
        {
            while (temp1 != null && temp2 != null)
            {
                lista_intercalada.append(temp1.elemento);
                lista_intercalada.append(temp2.elemento);
                temp1 = temp1.next;
                temp2 = temp2.next;
            }
        }
        return lista_intercalada;
    }
}

namespace Intercalar_Listas_enlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista_1 = new Lista();
            Lista lista_2 = new Lista();


            lista_1.append(1);
            lista_1.append(2);
            lista_1.append(3);
            lista_1.append(4);


            lista_2.append(9);
            lista_2.append(8);
            lista_2.append(7);
            lista_2.append(6);
            Lista inter = lista_1.intercalar_lista(lista_2);
            inter.print();

            Console.ReadKey();
        }
    }
}
