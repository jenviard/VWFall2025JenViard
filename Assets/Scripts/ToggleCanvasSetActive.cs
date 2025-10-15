using UnityEngine;

public class ToggleCanvasSetActive : MonoBehaviour
{
    [SerializeField] private GameObject panelRoot; 
    private bool isActive = false; 

    private void Start()
    {
        panelRoot.SetActive(isActive);
    }

    public void TogglePanel()
    {
        isActive = !isActive;
        panelRoot.SetActive(isActive);
    }
}

