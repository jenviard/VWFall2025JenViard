using UnityEngine;

public class ToggleMirror: MonoBehaviour
{
    [SerializeField] private CanvasGroup panelGroup;
    private bool isVisible = true;

    public void TogglePanel()
    {
        isVisible = !isVisible;
        panelGroup.alpha = isVisible ? 1f : 0f;
        panelGroup.interactable = isVisible;
        panelGroup.blocksRaycasts = isVisible;
    }
}
