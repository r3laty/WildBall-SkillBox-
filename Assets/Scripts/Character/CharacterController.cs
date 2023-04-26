using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class CharacterController : MonoBehaviour
{
   [SerializeField, Range(0,10)]private float _speed = 5f;
   public int points = 0;
   
   private float horizontal;
   private float vertical;
   private Vector3 movement;
   private Rigidbody playerRb;
   private CharacterMovement characterMovement;



   private void Awake() 
   { 
      playerRb = GetComponent<Rigidbody>();
      characterMovement = GetComponent<CharacterMovement>();
   }

   private void Update() 
   {
      horizontal = Input.GetAxis("Horizontal");
      vertical = Input.GetAxis("Vertical");
      movement = new Vector3(horizontal, playerRb.velocity.y, vertical);
   }

   private void FixedUpdate() 
   {
      characterMovement.PlayerMove(movement, _speed);
   }
}
