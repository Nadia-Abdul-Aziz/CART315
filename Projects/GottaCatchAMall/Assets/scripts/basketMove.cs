using UnityEngine;

public class basketMove : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;

    public float speed = 0.1f;
    public float basket_x, basket_y;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(left))
        {
            basket_x -= 0.01f;
 
        } 
        
        if (Input.GetKeyDown(right))
        {
            basket_x += 0.01f;
        } 
        
        transform.position = new Vector3(basket_x, -4.0f, 0 );
    }
}
