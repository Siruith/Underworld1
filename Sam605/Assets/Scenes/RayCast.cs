using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void OnDrawGizmos ()
    {
       float distanciaMax = 100000f;
       RaycastHit hit;

       bool Detecta = Physics.Raycast(transform.position, transform.forward, out hit, distanciaMax);
       if (Detecta)  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
