using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    
    void FixedUpdate()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0,  Input.GetAxis("Vertical") * speed * Time.deltaTime));
    }
}
