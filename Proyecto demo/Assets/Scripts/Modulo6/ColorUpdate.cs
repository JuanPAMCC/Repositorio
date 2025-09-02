using UnityEngine;

public class ColorUpdate : MonoBehaviour
{
    MeshRenderer meshr;
    void Awake()
    {
        meshr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
            meshr.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
