using UnityEngine;
using UnityEngine.UI;

public class CurrentGemsCounter : MonoBehaviour
{
    [SerializeField] private Text _currentPointText;
    [SerializeField] private string _pattern = "Количество очков: ";
    [SerializeField] private CharacterController characterController;
    private void Update() 
    {
        switch(characterController.points)
        {
            case 1:
                _currentPointText.text = _pattern + characterController.points.ToString();
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
