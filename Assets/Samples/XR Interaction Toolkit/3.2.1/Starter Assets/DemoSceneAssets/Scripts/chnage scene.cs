using UnityEngine;
using UnityEngine.UI; // Required for UI elements

public class SkyboxSwitcher : MonoBehaviour
{
    public Material skyboxMaterial1; // Assign your first 360 image material here
    public Material skyboxMaterial2; // Assign your second 360 image material here

    private bool isSkybox1Active = true; // Tracks which skybox is currently active

    void Start()
    {
        // Optional: Ensure the initial skybox is set correctly on start
        RenderSettings.skybox = skyboxMaterial1;
    }

    public void SwitchSkybox()
    {
        if (isSkybox1Active)
        {
            RenderSettings.skybox = skyboxMaterial2;
        }
        else
        {
            RenderSettings.skybox = skyboxMaterial1;
        }
        isSkybox1Active = !isSkybox1Active; // Toggle the active skybox state
    }
}