using UnityEngine;

public class GO1FixedUpdate : MonoBehaviour
{
    MeshRenderer meshr;
    public bool estado;

    void Awake()
    {
        meshr = GetComponent<MeshRenderer>();
    }

    void FixedUpdate()
    {
        estado = !estado;
        if (estado == true)
        {
            meshr.material.color = Color.white;
        }
        else
        {
            meshr.material.color = Color.black;
        }
    }
}
