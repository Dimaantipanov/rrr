using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject RespawnPoint;
    public List<GameObject> Corridor;
    System.Random random;
    void Start()
    {
        random = new System.Random();
        CorridorAdd();

    }

   
    public void CorridorAdd()
    {
        //Random corridor number.
        int CorridorNum = RandomGenerator(Corridor.Count);
        //Preparing for respawn corridor.
        GameObject Corridor_1 = Corridor[CorridorNum].gameObject;
        //Insert components.
        Corridor_1.GetComponent<CorridorMove>().CorridorDeparturePoint = RespawnPoint.gameObject;
        Corridor_1.GetComponent<CorridorMove>().GameManager = gameObject;
        //Set the coordinates and rotation.
        Vector3 PositionRespawnPoint = RespawnPoint.transform.position;
        Quaternion RotateRespawnPoint = RespawnPoint.transform.rotation;
        UnityEngine.Object.Instantiate(Corridor_1, PositionRespawnPoint, RotateRespawnPoint);
    }
    public int RandomGenerator(int a)
    {
        int Random = random.Next(0, a);
        return Random;
    }
}
