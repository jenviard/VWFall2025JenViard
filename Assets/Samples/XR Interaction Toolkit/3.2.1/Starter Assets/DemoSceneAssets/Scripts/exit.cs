using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void QuitGame()
    {
        // This will quit the application when built
        Application.Quit();

        // This is only for the Unity editor (so you can test)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
