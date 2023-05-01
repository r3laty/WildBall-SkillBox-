using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class JumpController : MonoBehaviour
{
    [HideInInspector] public bool isGround;
    public void PlayerJump(Rigidbody playerRb, float jumpForce)
    {
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }    
    }
    private void OnCollisionExit(Collision other) 
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }   
    }
}
