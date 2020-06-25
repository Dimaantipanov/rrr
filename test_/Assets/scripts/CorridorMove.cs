using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorMove : MonoBehaviour
{
    //Corridor speed.
    public float CorridorSpeed =1;
    //Corridor departure point.
    public GameObject CorridorDeparturePoint;
    public GameObject GameManager;
    //There was no repeated operation.
    public bool Trigger;

    void FixedUpdate()
    {
        //Сontinuous movement along the x axis.
        gameObject.transform.Translate(Vector3.left * CorridorSpeed  * Time.deltaTime);
        //Spacing from respawn point to corridor.
        if ((CorridorDeparturePoint.transform.position.x-gameObject.transform.position.x)>70&& !Trigger)
        {
            //Add a random corridor once.
            GameManager.GetComponent<GameManager>().CorridorAdd();
            Trigger = true;
        }
        //Spacing from respawn point to corridor.
        if ((CorridorDeparturePoint.transform.position.x - gameObject.transform.position.x) > 100)
        {
            Trigger = false;
            //We remove the far gone corridor.
            Destroy(gameObject);
        }

    }
}
