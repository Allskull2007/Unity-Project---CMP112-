using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour
{
    public float TotalTime;
    void Update()
    {
        if( TotalTime > 0)
        {
            TotalTime -= Time.deltaTime;    
        }

    }
}
