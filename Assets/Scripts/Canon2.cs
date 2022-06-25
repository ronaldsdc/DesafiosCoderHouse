using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon2 : MonoBehaviour
{
   
    public GameObject ObjetoBala2;
 
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Disparo2();
           
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Disparo3();

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Disparo4();

        }
        
    }
    void Disparo2()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(ObjetoBala2);
            
        }
        

    }
    void Disparo3()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(ObjetoBala2);

        }

    }
    void Disparo4()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(ObjetoBala2);

        }

    }

}
