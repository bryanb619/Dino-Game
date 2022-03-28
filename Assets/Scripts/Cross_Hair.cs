using UnityEngine;

public class Cross_Hair : MonoBehaviour
{
    
    private void Awake()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = mouseCursorPos;
    }

    private void CrossHair()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = mouseCursorPos;
    }
}
