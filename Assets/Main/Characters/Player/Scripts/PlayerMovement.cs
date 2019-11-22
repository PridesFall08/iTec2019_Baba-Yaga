using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Input.GetAxis("Vertical") * speed * Time.deltaTime, 
            transform.position.y, 
            transform.position.z + Input.GetAxis("Horizontal") * speed * Time.deltaTime * -1);
    }
}
