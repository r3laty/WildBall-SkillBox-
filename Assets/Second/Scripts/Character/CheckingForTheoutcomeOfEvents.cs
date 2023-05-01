using UnityEngine;

public class CheckingForTheoutcomeOfEvents : MonoBehaviour
{
    private CharacterController characterController;
    private bool isFinished;

    [SerializeField] private Canvas _winMenu;
    [SerializeField] private Canvas _lossWithoutGems;

    private void Awake() 
    {
        characterController = GetComponent<CharacterController>();    
    }

    private void Update() 
    {
        if(characterController.points > 1 && characterController.points == 3 && isFinished)
        {
            _winMenu.gameObject.SetActive(true);
        }
        else if(characterController.points < 3 && isFinished)
        {
            _lossWithoutGems.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Finish"))
        {
            isFinished = true;
        }    
    }
}
