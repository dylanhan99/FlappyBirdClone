using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    public int RateOfTravel{get;set;}
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(RateOfTravel * Time.deltaTime, 0, 0);
    }
}
