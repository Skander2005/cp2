using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chekcpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {Debug.Log (Div (0f,5.9f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    string Div(float b,float a) {
    if (b ==0 )
    return "error";
    else {
    float c =  a/b;
    return c.ToString() ;
     }
    }
     }
    

