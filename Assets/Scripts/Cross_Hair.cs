using UnityEngine;

public class Cross_Hair : MonoBehaviour
{
    public GameObject CrossHair;
    private Vector3 target;



    void Update()
    {
        target = transform.GetComponent <Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        CrossHair.transform.position =  new Vector2(target.x, target.y);    
    }


    /*private void Awake()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseCursorPos;
    }

    private void CrossHair()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = mouseCursorPos;
    }
    */
}
