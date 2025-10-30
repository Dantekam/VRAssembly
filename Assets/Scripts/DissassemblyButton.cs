using UnityEngine;

public class DisassemblyButton : MonoBehaviour
{
    public Renderer buttonRenderer;
    public Material disassemblyOffMaterial;
    public Material disassemblyOnMaterial;

    void Start()
    {
        UpdateButtonColor();
    }

    public void ToggleDisassembly()
    {
        AssemblyPiece.isDisassemblyMode = !AssemblyPiece.isDisassemblyMode;
        Debug.Log("Disassembly Mode: " + AssemblyPiece.isDisassemblyMode);
        UpdateButtonColor();
    }

    void UpdateButtonColor()
    {
        if (AssemblyPiece.isDisassemblyMode)
        {
            buttonRenderer.material = disassemblyOnMaterial;
        }
        else
        {
            buttonRenderer.material = disassemblyOffMaterial;
        }
    }
}
