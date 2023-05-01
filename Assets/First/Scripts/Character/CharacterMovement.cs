using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    private void Awake() 
    {
        playerRb = GetComponent<Rigidbody>();   
    }

    public void PlayerMove(Vector3 vector, float speed)
    {
        playerRb.velocity = new Vector3(vector.x * speed, vector.y, vector.z * speed);
    }
}