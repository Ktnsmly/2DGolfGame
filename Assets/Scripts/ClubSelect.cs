using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubSelect : MonoBehaviour
{
    [SerializeField] public float upLimit;
    [SerializeField] public float downLimit;
    // Start is called before the first frame update
    void Start()
    {
        upLimit = 80.0f;
        downLimit = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
