using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentGemsCounter : MonoBehaviour
{
    [SerializeField] private Text _currentPointText;
    private CharacterController characterController;
    private void Awake() 
    {
        characterController = GetComponent<CharacterController>();    
    }
    private void Update() 
    {
        switch(characterController.points)
        {
            case 1:
                _currentPointText.text = "Количество очков: 1";
            break;
            case 2:
                _currentPointText.text = "Количество очков: 2";
            break;
            case 3:
                _currentPointText.text = "Количество очков: 3";
            break;
        }
    }
}
