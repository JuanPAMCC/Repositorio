using UnityEngine;
using System;

public class EjerciciosdeCiclosyareglos : MonoBehaviour
{
    [Header("E1")]
    public int n = 0;
    public int minR = 0;
    public int maxR = 0;

    [Header("E2")]
    public string oracion = "hola esto es una oracion de prueba";

    [Header("E3")]
    public int f = 2;
    public int c = 3;

    void Start()
    {
        E1();
        E2();
        E3();
    }

    void E1()
    {
        if (n <= 0) n = 1;
        int[] a = new int[n];
        int[] b = new int[n];
        int[] s = new int[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = UnityEngine.Random.Range(minR, maxR);
            b[i] = UnityEngine.Random.Range(minR, maxR);
            s[i] = a[i] + b[i];
        }

        Debug.Log("array a -> [" + string.Join(", ", a) + "]");
        Debug.Log("array b -> [" + string.Join(", ", b) + "]");
        Debug.Log("suma s -> [" + string.Join(", ", s) + "]");
    }

    void E2()
    {
        string[] p = (oracion ?? "").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string outTxt = "";
        foreach (var w in p)
        {
            if (outTxt.Length > 0) outTxt += " ";
            outTxt += w;
        }
        Debug.Log("foreach -> " + outTxt);
    }

    void E3()
    {
        if (f < 2) f = 2;
        if (c < 3) c = 3;

        int[,] M = new int[f, c];
        int[] v = new int[c];
        int[] r = new int[f];

        for (int i = 0; i < f; i++)
            for (int j = 0; j < c; j++)
                M[i, j] = UnityEngine.Random.Range(1, 10);

        for (int j = 0; j < c; j++)
            v[j] = UnityEngine.Random.Range(1, 10);

        for (int i = 0; i < f; i++)
        {
            int sum = 0;
            for (int j = 0; j < c; j++)
                sum += M[i, j] * v[j];
            r[i] = sum;
        }

        string[] filasTxt = new string[f];
        for (int i = 0; i < f; i++)
        {
            int[] row = new int[c];
            for (int j = 0; j < c; j++) row[j] = M[i, j];
            filasTxt[i] = "[" + string.Join(", ", row) + "]";
        }

        Debug.Log("M -> [" + string.Join(" ; ", filasTxt) + "]");
        Debug.Log("v -> [" + string.Join(", ", v) + "]");
        Debug.Log("r = M*v -> [" + string.Join(", ", r) + "]");
    }
}
