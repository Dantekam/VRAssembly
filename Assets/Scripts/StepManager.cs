using UnityEngine;
using TMPro;

public class StepManager : MonoBehaviour
{
    public TextMeshProUGUI stepText;
    public string[] stepInstructions;

    void Update()
    {
        int currentStep = AssemblyPiece.currentStep;

        if (currentStep < stepInstructions.Length)
        {
            stepText.text = $"Step {currentStep + 1}: {stepInstructions[currentStep]}";
        }
        else
        {
            stepText.text = "Assembly complete!";
        }
    }
}
