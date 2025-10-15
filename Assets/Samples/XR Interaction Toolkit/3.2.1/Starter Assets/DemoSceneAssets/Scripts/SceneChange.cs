using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void SceneChanger(string changeScene)
    {
        SceneManager.LoadScene(changeScene);
    }
    
}
