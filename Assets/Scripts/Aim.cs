using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public ClubSelect _clubSelect;
    //up and down limiters constrain launch degree based on club selection
    private bool isAimingUp = false;
    private bool isAimingDown = false;
    //speedAdjust changes how fast the aiming arrow moves
    private float speedAdjust = 30.0f;
    private float startPosition;
    //aimDeg is the aiming direction
    [SerializeField] public float aimDeg;

    // Start is called before the first frame update
    void Start()
    {
        aimDeg = (_clubSelect.upLimit + _clubSelect.downLimit) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isAimingDown)
        {
            AimActiveDown();
        }
        if (isAimingUp)
        {
            AimActiveUp();
        }   
    }

    void AimActiveUp()
    {
        aimDeg += Time.deltaTime * speedAdjust;
        if (aimDeg >= _clubSelect.upLimit)
        {
            isAimingUp = false;
            aimDeg = _clubSelect.upLimit;
        }
    }

    void AimActiveDown()
    {
        aimDeg -= Time.deltaTime * speedAdjust;
        if (aimDeg <= _clubSelect.downLimit)
        {
            isAimingDown = false;
            aimDeg = _clubSelect.downLimit;
        }
    }

    public void StartAimingUp()
    {
        isAimingUp = true;
    }

    public void StartAimingDown()
    {
        isAimingDown = true;
    }

    public void StopAiming()
    {
        isAimingUp = false;
        isAimingDown = false;
    }

}
