using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    Rigidbody rb;
    public GameObject arrowPrefab;

    private void OnTriggerEnter(Collision Collider)
    {
        GameObject arrow = Instantiate(arrowPrefab, transform.position, transform.rotation);
        Debug.Log("Arrow");
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        if (rb != null )
        {

        }
    }
}
