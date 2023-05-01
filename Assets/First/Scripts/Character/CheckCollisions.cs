using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    [SerializeField] private Animator _animeHeart;

    private void OnTriggerEnter(Collider other)     
    {
        if(other.CompareTag("Heart"))
        {
            _animeHeart.SetBool("GetHeart", true);
        }    
    }
}
