using UnityEngine;

public class SaberBlue : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto que entra tiene tag "Cube"
        
        if (other.CompareTag("CubeBlue"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Mine"))
        {
            Time.timeScale = 0f;
        }
    }
}


