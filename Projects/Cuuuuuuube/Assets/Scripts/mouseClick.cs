using UnityEngine;

public class mouseClick : MonoBehaviour
{
public delegate void ClickAction(bool hitCube);
public event ClickAction OnClick;

void Update()
{
    if (Input.GetMouseButtonDown(0))
    {
        CheckClick();
    }
}

void CheckClick()
{
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;

    bool hitCube = Physics.Raycast(ray, out hit);
    
    // Log to console
    if (hitCube)
    {
        Debug.Log("HIT! Collided with: " + hit.collider.name + " (Tag: " + hit.collider.tag + ")");
    }
    else
    {
        Debug.Log("MISS! Clicked on empty space");
    }
        
    // Notify listeners about the click result
    OnClick?.Invoke(hitCube);
}
}
