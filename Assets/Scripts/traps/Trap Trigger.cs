using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    Rigidbody rb;
    public GameObject arrowPrefab;

    private void OnTriggerEnter(Collision Collider)
    {
        Debug.Log("Arrow");
        GameObject arrow = Instantiate(arrowPrefab, transform.position, transform.rotation);
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        if (rb != null )
        {

        }
    }
}
