using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables!!!

    public Rigidbody rb;
    public float forwardSpeed = 800f;
    public float sidewaysSpeed = 900f;
    public Transform Vector3 V;
    void Start()
    {

    }


    void FixedUpdate()
    {

        //This Movement System Is NOT The Best Way But For A Game Like Mine It's Good Enough That Doesn't Mean The Same For YOU!
        
        //Movment Foward!!!
        vector3.Input()

        //Movement Left!!!
        if( Input.GetKey("a"))
        {                                            //We Use VelocityChange Because It Will Be So Slow To Move To Left Or Right 
            rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //Movement Right!!!
        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // This Is For People That Play With Arrow Keys!

        //Movement Right!!!    
        if( Input.GetKey("right"))
        {
            rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    
    
        //Movement Left!!!
        if( Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    
    
    
    
    
    
    
    }
}
