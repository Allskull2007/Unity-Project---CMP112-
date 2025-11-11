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
        if(wall == null)
        {
            wall = GetComponent<GameObject>();
        }

        StartCoroutine(WallLoop());

    }

    IEnumerator WallLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(MinDelay, MaxDelay));
            wall.SetActive(false);
            yield return new WaitForSeconds(Timer);
            wall.SetActive(true);
        }
    }

}
