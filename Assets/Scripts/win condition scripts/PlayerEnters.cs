using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PlayerEnters : MonoBehaviour
{
    public int score = 0;
    public List<Vector3> startingPos = new List<Vector3>();

    void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            startingPos = StartingPos(startingPos);
        }
        Debug.Log(startingPos);
    }




    private List<Vector3> StartingPos(List<Vector3> startingPos)
    {
        int randomInt = Random.Range(1, 10);
        switch (randomInt)
        {
            case 1:
                startingPos[0] = new Vector3(50,2,-20) ;
                break;
            case 2:
                startingPos[0] = new Vector3(50, 2, -20);
                break;
            case 3:
                startingPos[0] = new Vector3(50, 2, -20);
                break;
            case 4:
                startingPos[0] = new Vector3(50, 2, -20);
                break;
            case 5:
                startingPos[0] = new Vector3(50, 2, -20);
                break;
            case 6:
                startingPos[0] = new Vector3(50, 2, -20);
                break;
            case 7:
                startingPos[0] = new Vector3(50, 2, -20);
                break;
            case 8:
                startingPos[0] = new Vector3(50, 2, -20);
                break;
            case 9:
                startingPos[0] = new Vector3(50, 2, -20);
                break;
            case 10:
                startingPos[0] = new Vector3(50, 2, -20);
                break;
        }

        return startingPos;
    }
}
