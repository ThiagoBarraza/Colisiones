using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Neg = new Vector3(-4, 0, 0);
        Vector3 Pos = new Vector3(4, 0, 0);

        if (transform.position!=Neg)
        {
            transform.Translate(0.2f, 0, 0);
        }
        if (transform.position !=Pos)
        {
            transform.Translate(-0.2f, 0, 0);
        }




    }
}
