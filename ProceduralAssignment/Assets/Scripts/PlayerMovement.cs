using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Motion Properties")]
    float finalmovementX;
    float finalmovemnetY;

    public float M_Speed;
    public float M_DecerlerationTime;
    public float M_AccelerationTime;
    
    bool HorizontalAcclerationActive = false;
    bool VerticalAccelerationActive = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HorizontalMovement()
    {
        //a=v/t
        if (HorizontalAcclerationActive==true)
        {
            finalmovementX =+ M_Speed / M_AccelerationTime;
        }
        if (HorizontalAcclerationActive == false)
        {
            finalmovementX = -M_Speed / M_DecerlerationTime;
        }
    }

    public void VerticalMovement()
    {
        if (VerticalAccelerationActive == true)
        {

        }
    }

}
