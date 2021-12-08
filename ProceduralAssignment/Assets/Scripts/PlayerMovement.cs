using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Motion Properties")]
    float finalmovementX;
    float finalmovemnetY;

    public float M_Speed;

    public Rigidbody2D Rb;
    private Vector2 MoveDirection;

    //public float M_DecerlerationTime;
    //public float M_AccelerationTime;
    
    //bool HorizontalAcclerationActive = false;
    //bool VerticalAccelerationActive = false;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MoveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveDirection = MoveInput * M_Speed;
    }

    private void FixedUpdate()
    {
        Rb.MovePosition(Rb.position + MoveDirection * Time.deltaTime);
    }


}
