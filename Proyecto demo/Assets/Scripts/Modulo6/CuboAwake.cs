using UnityEngine;

public class CuboAwake : MonoBehaviour
{
    void Awake()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
