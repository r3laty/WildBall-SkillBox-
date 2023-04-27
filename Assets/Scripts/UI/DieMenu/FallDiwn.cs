using UnityEngine;

public class FallDiwn : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Canvas _dieMenu;
    private void Update() 
    {       
        if(_player.position.y <= Vector3.down.y)
        {
            _dieMenu.gameObject.SetActive(true);
        }
    }
}
