using UnityEngine;

public class CuboAwake : MonoBehaviour
{
    public GameObject cubo;
    void Awake()
    {
        Instantiate(cubo);
    }
}
