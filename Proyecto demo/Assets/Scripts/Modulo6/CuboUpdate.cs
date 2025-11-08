using UnityEngine;

public class CuboUpdate : MonoBehaviour
{
    public GameObject cubo;
    void Update()
    {
        Instantiate(cubo);
    }
}
