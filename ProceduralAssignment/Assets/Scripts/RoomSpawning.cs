using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawning : MonoBehaviour
{
    public int DoorDirection;

    [Header("Room Spawning Stuff")]
    private RoomCreation RoomTemplate;
    private int RandRoom;
    public bool HasBeenSpawned = false;
   
    
    // Start is called before the first frame update
    void Start()
    {
        RoomTemplate = GetComponent<RoomCreation>();
        RoomSpawn();
        //Spawningrooms();
        
        
    }

    // Update is called once per frame
    //void Update()
    //{


    //}

    //void Spawningrooms()
    //{
    //    if (HasBeenSpawned == false)
    //    {
    //        if (DoorDirection == 1) //For a right door
    //        {
    //            //Spawn Door with Left Entrance an exit.
    //            RandRoom = Random.Range(0, RoomTemplate.LeftExitRooms.Length);
    //            Instantiate(RoomTemplate.LeftExitRooms[RandRoom], transform.position, transform.rotation);
    //        }

    //        if (DoorDirection == 2)//For a left Door.
    //        {
    //            //Spawn Room With Right Exit Door
    //            RandRoom = Random.Range(0, RoomTemplate.RightExitRooms.Length);
    //            Instantiate(RoomTemplate.RightExitRooms[RandRoom], transform.position, transform.rotation);
    //        }

    //        if (DoorDirection == 3)//For Top Door.
    //        {
    //            //Spawn Room with Down exit.
    //            RandRoom = Random.Range(0, RoomTemplate.BottomExitRooms.Length);
    //            Instantiate(RoomTemplate.BottomExitRooms[RandRoom], transform.position, transform.rotation);
    //        }

    //        if (DoorDirection == 4)//For Bottom door
    //        {
    //            //Spawn Room with an up Exit.
    //            RandRoom = Random.Range(0, RoomTemplate.TopExitRooms.Length);
    //            Instantiate(RoomTemplate.TopExitRooms[RandRoom], transform.position, transform.rotation);
    //        }
    //        HasBeenSpawned = true;
    //        print(RoomTemplate);
    //    }
    //}

    
    void RoomSpawn()
    {
        switch (DoorDirection)
        {
            case 1:
                if (RoomTemplate.LeftExitRooms.Length > 0)
                {
                    RandRoom = Random.Range(0, RoomTemplate.LeftExitRooms.Length - 1);
                    Instantiate(RoomTemplate.LeftExitRooms[RandRoom], transform.position, transform.rotation);
                }
               break;

            case 2:
                if (RoomTemplate.RightExitRooms.Length > 0)
                {
                    RandRoom = Random.Range(0, RoomTemplate.RightExitRooms.Length - 1);
                    Instantiate(RoomTemplate.RightExitRooms[RandRoom], transform.position, transform.rotation);
                }
                break;

            case 3:
                //Spawn Room with Down exit.
                if (RoomTemplate.BottomExitRooms.Length>0)
                {
                    RandRoom = Random.Range(0, RoomTemplate.BottomExitRooms.Length - 1);
                    Instantiate(RoomTemplate.BottomExitRooms[RandRoom], transform.position, transform.rotation);
                }
               break;

            case 4:
                //Spawn Room with an up Exit.
                if (RoomTemplate.TopExitRooms.Length > 0)
                {
                    RandRoom = Random.Range(0, RoomTemplate.TopExitRooms.Length - 1);
                    Instantiate(RoomTemplate.TopExitRooms[RandRoom], transform.position, transform.rotation);
                }
                break;
        }
        HasBeenSpawned = true;
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the spawnpoint tags collide with eachother HasBeenSpawned is true.
        if (other.CompareTag("SpawnPoint"))
        {
            Destroy(gameObject);
        }
        

    }
}
