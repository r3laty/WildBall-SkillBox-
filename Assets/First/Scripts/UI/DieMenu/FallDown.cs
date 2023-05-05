using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Canvas _dieMenu;

    private void Start() 
    {
        Time.timeScale = 1f;    
    }
    private void Update() 
    {     
        if(_player.position.y <= Vector3.down.y)
        {
            Time.timeScale = 0;
            _dieMenu.gameObject.SetActive(true);
        }
    }
}
