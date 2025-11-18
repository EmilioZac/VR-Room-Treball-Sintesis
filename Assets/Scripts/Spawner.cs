using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    public GameObject prefab1;  // tu primer prefab
    public GameObject prefab2;  // tu segundo prefab

    public float spawnTime = 1.5f;   // cada cuánto tiempo spawnea
    private float timer = 0f;

    public BoxCollider spawnArea;    // el Box Collider donde aparecerán

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTime)
        {
            Spawn();
            timer = 0f;
        }
    }

    void Spawn()
    {
        // decidir si spawnea uno o dos
        int count = Random.Range(1, 3); // 1 o 2

        for (int i = 0; i < count; i++)
        {
            Vector3 pos = GetRandomPosition();
            GameObject selected = (Random.value > 0.5f) ? prefab1 : prefab2;

            Instantiate(selected, pos, Quaternion.identity);
        }
    }

    Vector3 GetRandomPosition()
    {
        Vector3 size = spawnArea.size;
        Vector3 center = transform.position + spawnArea.center;

        float x = Random.Range(center.x - size.x / 2, center.x + size.x / 2);
        float y = Random.Range(center.y - size.y / 2, center.y + size.y / 2);
        float z = Random.Range(center.z - size.z / 2, center.z + size.z / 2);

        return new Vector3(x, y, z);
    }
}


