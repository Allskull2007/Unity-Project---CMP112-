using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public int Arrowamout;
    public float Spacing;
    public float SpawnHeight;
    public int rows = 3;
    public int columns = 3;
    public float BackOffset = 2f;
    public float XBackOffset = 2f;
    private bool hasTriggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (hasTriggered) return;
        hasTriggered = true;

        float totalWidth = (columns - 1) * Spacing;
        float totalDepth = (rows - 1) * Spacing;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                float xOffset = col * Spacing - totalWidth / 2f - XBackOffset;
                float zOffset = row * Spacing - totalDepth / 2f - BackOffset;

                Vector3 spawnPos = transform.position + new Vector3(xOffset, SpawnHeight, zOffset);
                GameObject arrow = Instantiate(ArrowPrefab, spawnPos, Quaternion.identity);
                Rigidbody rb = arrow.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.useGravity = true;
                }
            }
        }

     
        
    }
}
