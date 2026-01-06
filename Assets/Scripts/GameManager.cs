using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int Puntuacion = 0;
    public TMP_Text t;

    void Update()
    {
        t.text = Puntuacion.ToString();
    }
}

