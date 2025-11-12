using System.Collections;
using UnityEngine;

public class DissaperingWalls : MonoBehaviour
{
    public GameObject wall;
    public float MinDelay;
    public float MaxDelay;
    public float Timer;

    void Start()
    {
        if(wall == null)   //Checks if wall is assigned
        {
            wall = GetComponent<GameObject>();
        }

        StartCoroutine(WallLoop());  

    }

    IEnumerator WallLoop()
    {
        while (true)  //runs forever while true
        {
            yield return new WaitForSeconds(Random.Range(MinDelay, MaxDelay)); //Delay between disapperence 
            wall.SetActive(false);
            yield return new WaitForSeconds(Timer);  //How long the wall is turned off
            wall.SetActive(true);
        }
    }

}
