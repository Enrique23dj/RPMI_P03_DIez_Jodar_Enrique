using UnityEngine;

public class PlayerCardController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        print("Click");
        GetComponent<SpriteRenderer>().sortingLayerName = "Selected Cards";

    }
    private void OnMouseDrag()
    {
        
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        transform.position = newPosition;

    }
    private void OnMouseUp()
    {

        GetComponent<SpriteRenderer>().sortingLayerName = "Default";

    }
}
