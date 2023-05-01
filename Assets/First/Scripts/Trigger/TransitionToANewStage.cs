using UnityEngine.SceneManagement;
using UnityEngine;

public class TransitionToANewStage : MonoBehaviour
{
    public void ToTheNextLvlTransition()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
