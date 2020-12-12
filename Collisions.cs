using UnityEngine;

public class Collisions : MonoBehaviour
{
    // Variables!!!
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
//We Check For A Tag Not A Name Because If We Use ".name" And Your Game Is BIG Then There Will Be So Many Names So It Will Be Hard For Unity To Find The One That You Want!
        if(collisionInfo.collider.tag == "Knife")
        { // You CAN'T Use This If Your Game Is Not Like Mine In This Style!!!
            movement.enabled = false;
        }


                            
    }




}
