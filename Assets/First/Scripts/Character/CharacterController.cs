using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class CharacterController : MonoBehaviour
{
   [SerializeField, Range(0,10)] private float _speed = 5f;
   [SerializeField, Range(0,10)] private float _jumpForce = 5f;

   [HideInInspector]public int points = 0;
   
   private float horizontal;
   private float vertical;
   private bool isJumped;
   private Vector3 movement;
   private Rigidbody playerRb;
   private CharacterMovement characterMovement;
   private JumpController jumpController;
   private void Awake() 
   {
      playerRb = GetComponent<Rigidbody>();
      jumpController = GetComponent<JumpController>();
      characterMovement = GetComponent<CharacterMovement>();
   }

   private void Update() 
   {
      horizontal = Input.GetAxis("Horizontal");
      vertical = Input.GetAxis("Vertical");
      movement = new Vector3(horizontal, playerRb.velocity.y, vertical);
      if(Input.GetKeyDown(KeyCode.Space))
      {
         isJumped = true;
      }
      if(Input.GetKeyUp(KeyCode.Space))
      {
         isJumped =  false;
      }
   }

   private void FixedUpdate() 
   {
      //Move
      characterMovement.PlayerMove(movement, _speed);
      //Jump
      if(isJumped && jumpController.isGround)
      {
         jumpController.PlayerJump(playerRb, _jumpForce);
      }
   }
}
