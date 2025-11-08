using UnityEngine;
using System;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public float a = 12.75f;
    public float b = 3.20f;
    public string colPal = "rojo";
    public float flt = 3.1415926f;
    public string nomComp = "Nombre Apellido1 Apellido2";
    public string mil1 = "1500";
    public string mil2 = "2750";
    public string oracPar = "Hola Mundo";
    public string oracCut = "#####Inicio del mensaje";

    int cont = 0;
    float acum = 1f;
    Renderer rend;

    void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    void Start()
    {
        float op = a / b;
        int opInt = (int)op;
        Debug.Log("casteo explicito a int: " + opInt);

        string flt4 = flt.ToString("F4");
        Debug.Log("float con 4 decimales: " + flt4);

        string n1 = "", n2 = "", n3 = "";
        int i1 = nomComp.IndexOf(' ');
        int i2 = i1 >= 0 ? nomComp.IndexOf(' ', i1 + 1) : -1;
        if (i1 < 0)
        {
            n1 = nomComp;
        }
        else if (i2 < 0)
        {
            n1 = nomComp.Substring(0, i1);
            n2 = nomComp.Substring(i1 + 1);
        }
        else
        {
            n1 = nomComp.Substring(0, i1);
            n2 = nomComp.Substring(i1 + 1, i2 - i1 - 1);
            n3 = nomComp.Substring(i2 + 1);
        }
        Debug.Log("substring 3 partes -> " + n1 + " | " + n2 + " | " + n3);

        string[] partes = nomComp.Split(' ');
        Debug.Log("split en lista -> [" + string.Join(", ", partes) + "]");

        int v1, v2;
        bool ok1 = int.TryParse(mil1, out v1);
        bool ok2 = int.TryParse(mil2, out v2);
        if (ok1 && ok2)
        {
            int suma = v1 + v2;
            Debug.Log("suma miles ok: " + suma);
        }
        else
        {
            Debug.Log("tryparse fallo en mil1 o mil2");
        }

        string src = oracPar ?? "";
        char[] buf = new char[src.Length];
        int w = 0;
        for (int i = 0; i < src.Length; i++)
        {
            if ((i % 2) == 0) buf[w++] = src[i];
        }
        string pares = new string(buf, 0, w);
        string[] paresList = new string[pares.Length];
        for (int i = 0; i < pares.Length; i++) paresList[i] = pares[i].ToString();
        Debug.Log("indices pares: " + string.Join(",", paresList));

        string cut = oracCut ?? "";
        if (cut.Length > 5) cut = cut.Substring(5);
        Debug.Log("quitando 5 primeros: " + cut);

        ColPorPal(colPal);
    }

    void Update()
    {
        cont += 1;
    }

    void FixedUpdate()
    {
        acum *= 1.01f;

        if (rend != null)
        {
            bool esPar = (cont % 2) == 0;
            rend.material.color = esPar ? new Color(0f, 1f, 1f) : new Color(1f, 0f, 1f);
        }
    }

    void ColPorPal(string p)
    {
        if (rend == null) return;
        switch ((p ?? "").ToLowerInvariant())
        {
            case "rojo": rend.material.color = Color.red; break;
            case "verde": rend.material.color = Color.green; break;
            case "azul": rend.material.color = Color.blue; break;
            case "amarillo": rend.material.color = Color.yellow; break;
            default: rend.material.color = Color.white; break;
        }
    }
}
