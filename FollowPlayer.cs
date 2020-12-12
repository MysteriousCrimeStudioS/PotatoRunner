using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables!!!
    public Transform Player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // The Offset Is Because We Need To Make It Not Spawn Inside The Player So You Have To Find *Your* Perfect Offset!
        transform.position = Player.position + offset;
    }
}
