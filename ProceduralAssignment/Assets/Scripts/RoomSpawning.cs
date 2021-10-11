using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawning : MonoBehaviour
{
    public int DoorDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorDirection==1)
        {
            //Spawn Door with right Exit
        }

        if (DoorDirection == 2)
        {
            //Spawn Room With Left Exit
        }

        if (DoorDirection == 3)
        {
            //Spawn Room with Up exit
        }

        if (DoorDirection==4)
        {
            //Spawn Room with Down Exit
        }
    }
}
