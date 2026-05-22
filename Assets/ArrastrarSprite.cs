using UnityEngine;

public class ArrastrarSprite : MonoBehaviour
{
    private Vector3 offset;
    private Camera camara;

    void Start()
    {
        camara = Camera.main;
    }

    void OnMouseDown()
    {
        Vector3 mousePos = camara.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;
        offset = transform.position - mousePos;
    }

    void OnMouseDrag()
    {
        Vector3 mousePos = camara.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;
        transform.position = mousePos + offset;
    }
}