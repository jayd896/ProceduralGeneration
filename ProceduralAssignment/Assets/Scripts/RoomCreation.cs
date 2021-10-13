using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCreation : MonoBehaviour
{
    [Header("Room Types")]
    public GameObject[] RightExitRooms; //1:This means use Right Exitrooms for Doors that are to the left.
    public GameObject[] LeftExitRooms; //2: This means use Left exitrooms for Doors that are to the Right.
    public GameObject[] TopExitRooms; //3:This means use Top Exit Rooms for Door that are at the bottom.
    public GameObject[] BottomExitRooms; //4:This means use the Bottom Exit Doors for rooms that are at the top.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
