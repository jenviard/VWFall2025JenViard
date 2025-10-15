using UnityEngine;

public class ToggleCanvasSetActive : MonoBehaviour
{
    [SerializeField] private GameObject panelRoot; // assign in inspector
    private bool isActive = false; // start OFF

    private void Start()
    {
        // make sure the panel really starts hidden
        panelRoot.SetActive(isActive);
    }

    public void TogglePanel()
    {
        isActive = !isActive;
        panelRoot.SetActive(isActive);
    }
}
