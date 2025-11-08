using UnityEngine;

public class ColorFIxedUpdate : MonoBehaviour
{
    MeshRenderer meshr;
    void Awake()
    {
        meshr = GetComponent<MeshRenderer>();
    }

    void FixedUpdate()
    {
        meshr.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
