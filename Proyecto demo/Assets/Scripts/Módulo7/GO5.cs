using UnityEngine;

public class GO5 : MonoBehaviour
{
    MeshRenderer meshr;
    public bool estado;
    public GO3AND refAND;
    public GO4OR refOR;

    void Awake()
    {
        meshr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        estado = (refAND != null && refOR != null) && (refAND.estado && refOR.estado);
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
