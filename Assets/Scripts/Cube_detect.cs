using UnityEngine;

public class DestroyCubeOnEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto que entra tiene tag "Cube"
        if (other.CompareTag("Cube"))
        {
            Destroy(other.gameObject);
        }
    }
}


