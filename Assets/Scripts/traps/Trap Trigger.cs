using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    Rigidbody rb;
    public GameObject arrowPrefab;

    private void OnTriggerEnter(Collider other) // fixed the collider issue, just need to actually set up the traps now
    {
        Debug.Log("Arrow");
        GameObject arrow = Instantiate(arrowPrefab, transform.position, transform.rotation);
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
    }
}
