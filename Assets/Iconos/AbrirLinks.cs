using UnityEngine;

public class AbrirLinks : MonoBehaviour
{
    public void AbrirGoogle()
    {
        Application.OpenURL("https://www.google.com");
    }

    public void AbrirYoutube()
    {
        Application.OpenURL("https://www.youtube.com");
    }

    public void AbrirUnity()
    {
        Application.OpenURL("https://unity.com");
    }
}