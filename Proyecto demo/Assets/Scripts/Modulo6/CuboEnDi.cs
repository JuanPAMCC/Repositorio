using UnityEngine;

public class CuboEnDi : MonoBehaviour
{
    void OnEnable()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    void OnDisable()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
