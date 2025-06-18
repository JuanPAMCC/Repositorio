using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("algo paso");
        Debug.Log("Algo paso");
        Debug.LogWarning("Algo salio medianamente mal"); 
        Debug.LogError("Algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Algo sigue pasando");
    }


    void Awake()
    {
        Debug.Log("Algo pasa pero Awake");
    }

    void OnDestroy()
    {
        Debug.LogError("SE DESTRUYE SE DESTRUYE");
    }


}
