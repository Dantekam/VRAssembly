using UnityEngine;

public class GoalBlockHighlighter : MonoBehaviour
{
    public int stepIndex;
    public Material highlightMaterial;
    public Material defaultMaterial;

    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (AssemblyPiece.currentStep == stepIndex && !AssemblyPiece.isDisassemblyMode)
        {
            meshRenderer.material = highlightMaterial;
        }
        else
        {
            meshRenderer.material = defaultMaterial;
        }
    }
}
