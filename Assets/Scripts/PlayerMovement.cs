using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
   /* void Start()
    {
        rb.AddForce(0, 200, 500);
    } */

    // Update is called once per frame
    public float Forwardforce = 2000f;
    public float Sidewaysforce = 500f;
    void FixedUpdate()
    {
      rb.AddForce(0, 0, Forwardforce * Time.deltaTime);
       if( Input.GetKey("d") )
        rb.AddForce(Sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

       if( Input.GetKey("a") )
        rb.AddForce(-Sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

       if ( rb.position.y < -1f )
        FindObjectOfType<GameManager>().EndGame();
    }
}
