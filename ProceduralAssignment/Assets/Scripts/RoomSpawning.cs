using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawning : MonoBehaviour
{
    public int DoorDirection;

    [Header("Room Spawning Stuff")]
    private RoomCreation RoomTemplate;
    private int randRoom;
    public bool HasBeenSpawned = false;
   
    
    // Start is called before the first frame update
    void Start()
    {
        RoomTemplate = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomCreation>();
        Spawningrooms();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void Spawningrooms()
    {
        if (HasBeenSpawned == false)
        {
            if (DoorDirection == 1) //For a right door
            {
                //Spawn Door with Left Entrance an exit.
                randRoom = Random.Range(0, RoomTemplate.LeftExitRooms.Length);
                Instantiate(RoomTemplate.LeftExitRooms[randRoom], transform.position, transform.rotation);
            }

            if (DoorDirection == 2)//For a left Door.
            {
                //Spawn Room With Right Exit Door
                randRoom = Random.Range(0, RoomTemplate.RightExitRooms.Length);
                Instantiate(RoomTemplate.RightExitRooms[randRoom], transform.position, transform.rotation);
            }

            if (DoorDirection == 3)//For Top Door.
            {
                //Spawn Room with Down exit.
                randRoom = Random.Range(0, RoomTemplate.BottomExitRooms.Length);
                Instantiate(RoomTemplate.BottomExitRooms[randRoom], transform.position, transform.rotation);
            }

            if (DoorDirection == 4)//For Bottom door
            {
                //Spawn Room with an up Exit.
                randRoom = Random.Range(0, RoomTemplate.TopExitRooms.Length);
                Instantiate(RoomTemplate.TopExitRooms[randRoom], transform.position, transform.rotation);
            }
            HasBeenSpawned = true;
        }
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
