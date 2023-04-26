using UnityEngine;
using UnityEngine.UI;

public class DoorCollider : MonoBehaviour
{
    [SerializeField] private Text _manual;
    [SerializeField] private Text _manual1;
    [SerializeField] private Text _manual2;
    [SerializeField] private Text _manualWithoutPoints;
    [SerializeField] private GameObject _door;
    [SerializeField] private Animator _animeDoor;

    private CharacterController characterController;
    private bool isClaimed;

    private void Awake() 
    {
        characterController = GetComponent<CharacterController>();    
    }

    private void Update() 
    {
        if(isClaimed && Input.GetKeyDown(KeyCode.E))
        {
            _animeDoor.SetBool("isClaimed", true);
        }    
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Door"))
        {
            if(characterController.points == 3)
            {
                _manualWithoutPoints.gameObject.SetActive(true);
                isClaimed = true;
            }
            if(characterController.points == 2)
            {
                _manual1.gameObject.SetActive(true);
            }
            if(characterController.points == 1)
            {
                _manual2.gameObject.SetActive(true);
            }
            if(characterController.points == 0)
            {
                _manual.gameObject.SetActive(true);
            }
        }
    }
    private void OnCollisionExit(Collision other) 
    {
            if(characterController.points == 3)
            {
                _manualWithoutPoints.gameObject.SetActive(false);
            }
            if(characterController.points == 2)
            {
                _manual1.gameObject.SetActive(false);
            }
            if(characterController.points == 1)
            {
                _manual2.gameObject.SetActive(false);
            }
            if(characterController.points == 0)
            {
                _manual.gameObject.SetActive(false);
            }
    }
}
