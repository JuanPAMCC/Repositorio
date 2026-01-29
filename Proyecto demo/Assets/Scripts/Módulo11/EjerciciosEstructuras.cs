using UnityEngine;
using System;
using System.Collections.Generic;

public class EjerciciosEstructuras : MonoBehaviour
{
    public bool run = true;

    void Start()
    {
        if (!run) return;

        List<int> Lista1 = Funcion(10, 0, 20);
        Debug.Log("list rand: " + ListTxt(Lista1));

        int[] fix = new int[] { 5, 2, 9, 2, 7, 1 };
        int[] fDescent = OrdDesc(fix);
        Debug.Log("arr desc: " + ArrTxt(fDescent));

        List<string> ListaStr = new List<string>() { "a", "b", "a", "c", "b", "d" };
        HashSet<string> SetStr = SinRep(ListaStr);
        Debug.Log("hash sin rep: " + SetTxt(SetStr));

        Stack<string> StackStr = new Stack<string>();
        StackStr.Push("uno");
        StackStr.Push("dos");
        StackStr.Push("tres");
        StackQ(StackStr);
    }

    public List<int> Funcion(int tamL, int minR, int maxR)
    {
        if (tamL < 0) tamL = 0;

        if (minR > maxR)
        {
            int tmpSwap = minR;
            minR = maxR;
            maxR = tmpSwap;
        }

        if (minR == maxR) maxR = minR + 1;

        List<int> ListaRnd = new List<int>(tamL);

        for (int i = 0; i < tamL; i++)
        {
            int valRnd = UnityEngine.Random.Range(minR, maxR);
            ListaRnd.Add(valRnd);
        }

        return ListaRnd;
    }

    public int[] OrdDesc(int[] arrIn)
    {
        if (arrIn == null) return null;

        int[] arrCopy = (int[])arrIn.Clone();
        Array.Sort(arrCopy);
        Array.Reverse(arrCopy);
        return arrCopy;
    }

    public HashSet<T> SinRep<T>(List<T> ListaIn)
    {
        HashSet<T> SetOut = new HashSet<T>();
        if (ListaIn == null) return SetOut;

        for (int i = 0; i < ListaIn.Count; i++)
            SetOut.Add(ListaIn[i]);

        return SetOut;
    }

    public void StackQ(Stack<string> StackIn)
    {
        if (StackIn == null)
        {
            Debug.Log("stack null");
            return;
        }

        Queue<string> QueueOut = new Queue<string>();
        Stack<string> StackTmp = new Stack<string>();

        Debug.Log("stack");
        while (StackIn.Count > 0)
        {
            string val = StackIn.Peek();
            Debug.Log("peek " + val);

            QueueOut.Enqueue(val);
            StackIn.Pop();
            StackTmp.Push(val);
        }

        while (StackTmp.Count > 0)
            StackIn.Push(StackTmp.Pop());

        Debug.Log("queue");
        while (QueueOut.Count > 0)
        {
            string val = QueueOut.Peek();
            Debug.Log("peek " + val);
            QueueOut.Dequeue();
        }
    }

    string ArrTxt(int[] arrIn)
    {
        if (arrIn == null) return "null";
        return "[" + string.Join(", ", arrIn) + "]";
    }

    string ListTxt(List<int> ListaIn)
    {
        if (ListaIn == null) return "null";
        return "[" + string.Join(", ", ListaIn) + "]";
    }

    string SetTxt<T>(HashSet<T> SetIn)
    {
        if (SetIn == null) return "null";
        List<string> ListaOutTxt = new List<string>();
        foreach (var it in SetIn)
            ListaOutTxt.Add(it == null ? "null" : it.ToString());
        return "[" + string.Join(", ", ListaOutTxt) + "]";
    }
}