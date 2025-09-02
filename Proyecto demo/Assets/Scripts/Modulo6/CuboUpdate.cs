using UnityEngine;

public class CuboUpdate : MonoBehaviour
{
    void Update()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
