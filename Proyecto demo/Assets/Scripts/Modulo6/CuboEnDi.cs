using UnityEngine;

public class CuboEnDi : MonoBehaviour
{
    public GameObject cubo;
    void OnEnable()
    {
        Instantiate(cubo);
    }

    void OnDisable()
    {
        Instantiate(cubo);
    }
}
