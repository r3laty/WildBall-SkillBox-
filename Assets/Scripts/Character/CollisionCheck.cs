using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    [SerializeField] private Animator _purpleGem;
    [SerializeField] private Animator _redGem;
    [SerializeField] private Animator _blueGem;

    private CharacterController characterController;

    private void Awake() 
    {
        characterController = GetComponent<CharacterController>();
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Purple"))
        {
            characterController.points++;
            _purpleGem.SetBool("purpleTouched", true);
        }

        if(other.CompareTag("Red"))
        {
            characterController.points++;
            _redGem.SetBool("redTouched", true);
        }
        if(other.CompareTag("Blue"))
        {
            characterController.points++;
            _blueGem.SetBool("blueTouched", true);
        }
        
    }
}
