using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void IrAEscena2()
    {
        SceneManager.LoadScene("Escena2");
    }
}