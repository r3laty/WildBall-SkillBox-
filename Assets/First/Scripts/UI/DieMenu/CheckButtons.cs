using UnityEngine.SceneManagement;
using UnityEngine;

public class CheckButtons : MonoBehaviour
{
    public void YesButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
