using UnityEngine;

public class ColorAwake : MonoBehaviour
{
    MeshRenderer meshr;

    void Awake()
    {
        meshr = GetComponent<MeshRenderer>();
        meshr.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
