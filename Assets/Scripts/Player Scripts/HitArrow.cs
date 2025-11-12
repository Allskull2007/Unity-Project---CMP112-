using UnityEngine;

public class HitArrow : MonoBehaviour
{
    public PlayerHealth PlayerHealth;
    int arrowCounter;

    void Start()
    {
        PlayerHealth = GetComponent<PlayerHealth>();
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
        PlayerHealth.ArrowHit(1);
        Destroy(collision.gameObject);
        }
    }
}
