using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject ObjetoBala;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ObjetoBala);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Disparo()
    {
        Instantiate(ObjetoBala);
    }
}
