using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public Rigidbody rigidbody;
    public float movementSpeed = 1000f;
    public float sideSpeed = 50f;

    void FixedUpdate()
    {
        rigidbody.AddForce(0,0,movementSpeed * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rigidbody.AddForce(sideSpeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }else if(Input.GetKey("a"))
        {
            rigidbody.AddForce(-sideSpeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rigidbody.position.y < 1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
