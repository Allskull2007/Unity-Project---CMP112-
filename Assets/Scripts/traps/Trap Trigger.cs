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
        hasTriggered = true;    //Traps cannot be repeated 

        float totalWidth = (columns - 1) * Spacing;
        float totalDepth = (rows - 1) * Spacing;     //The size of the grid the arrows spawn in

        for (int row = 0; row < rows; row++)   //Loops for each grid cell
        {
            for (int col = 0; col < columns; col++)
            {
                float xOffset = col * Spacing - totalWidth / 2f - XBackOffset;
                float zOffset = row * Spacing - totalDepth / 2f - BackOffset;    //Adjusts position using the offsets and spacing values

                Vector3 spawnPos = transform.position + new Vector3(xOffset, SpawnHeight, zOffset);   //Create instance of arrows
                GameObject arrow = Instantiate(ArrowPrefab, spawnPos, Quaternion.Euler(-90f, 0f, 0f));  //Spawns the arrows facing down
                Rigidbody rb = arrow.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.useGravity = true;  //The arrows fall down
                }
                Destroy(arrow, 2.5f); //arrows get destroyed after 2.5 seconds

            }
        }
    }
}
