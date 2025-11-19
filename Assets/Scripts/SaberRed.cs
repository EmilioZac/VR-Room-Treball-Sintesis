using UnityEngine;

public class SaberRed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto que entra tiene tag "Cube"
        if (other.CompareTag("CubeRed"))
        {
            Destroy(other.gameObject);
        }
    }
}


