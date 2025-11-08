using UnityEngine;

public class GO2Update : MonoBehaviour
{
    MeshRenderer meshr;
    public bool estado;

    void Awake()
    {
        meshr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        estado = !estado;
        if (estado)
        {
            meshr.material.color = Color.white;
        }
        else
        {
            meshr.material.color = Color.black;
        }
    }
}
