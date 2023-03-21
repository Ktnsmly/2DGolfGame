using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimHub : MonoBehaviour
{
    public Aim _aimScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, _aimScript.aimDeg);
    }
}
