using UnityEngine;

public class GO4OR : MonoBehaviour
{
    MeshRenderer meshr;
    public bool estado;
    public GO1FixedUpdate refFixed;
    public GO2Update refUpdate;

    void Awake()
    {
        meshr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        estado = (refFixed != null && refUpdate != null) && (refFixed.estado || refUpdate.estado);
        switch (estado)
        {
            case true:
                meshr.material.color = Color.white;
                break;
            default:
                meshr.material.color = Color.black;
                break;
        }
    }
}


