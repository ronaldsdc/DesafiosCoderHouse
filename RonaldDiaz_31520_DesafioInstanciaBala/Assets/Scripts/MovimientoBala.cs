using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public int Speed;
    public Vector3 Direction;
    public int Damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovBala();

    }
    void MovBala()
    {
        transform.Translate(Direction * Speed * Time.deltaTime);

    }
}
