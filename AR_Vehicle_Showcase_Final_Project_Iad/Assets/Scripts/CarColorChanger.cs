using UnityEngine;

public class CarColorChanger : MonoBehaviour
{
    [Header("Drag the root GameObject of the whole car")]
    public GameObject carRoot;

    [Header("Materials")]
    public Material redMaterial;
    public Material greenMaterial;
    public Material blueMaterial;

    private Renderer[] allRenderers;

    void Start()
    {
        if (carRoot != null)
        {
            // Get all Renderers in this car (including children)
            allRenderers = carRoot.GetComponentsInChildren<Renderer>();
        }
        else
        {
            Debug.LogError("Car root object not assigned.");
        }
    }

    public void ApplyMaterial(string colorName)
    {
        if (allRenderers == null || allRenderers.Length == 0) return;

        Material newMat = null;

        switch (colorName.ToLower())
        {
            case "red":
                newMat = redMaterial;
                break;
            case "green":
                newMat = greenMaterial;
                break;
            case "blue":
                newMat = blueMaterial;
                break;
        }

        if (newMat == null) return;

        foreach (Renderer rend in allRenderers)
        {
            rend.material = newMat;
        }
    }
}
