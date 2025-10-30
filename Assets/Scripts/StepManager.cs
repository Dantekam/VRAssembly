using UnityEngine;
using TMPro;

public class StepManager : MonoBehaviour
{
    public TextMeshProUGUI stepText; // Canvas-based TextMeshPro
    public string[] stepInstructions;

    [Header("Next Phase Unlock")]
    public GameObject pathwaySet; // Assign in Inspector
    private bool pathwayUnlocked = false;

    void Update()
    {
        int currentStep = AssemblyPiece.currentStep;

        if (currentStep < stepInstructions.Length)
        {
            stepText.text = $"Step {currentStep + 1}: {stepInstructions[currentStep]}";
        }
        else
        {
            if (!pathwayUnlocked)
            {
                UnlockPathway();
                pathwayUnlocked = true;
            }

            // Show final message on Canvas TextMeshPro
            stepText.text = "House complete! This next set is all you.";
        }
    }

    void UnlockPathway()
    {
        if (pathwaySet != null)
        {
            pathwaySet.SetActive(true);
        }
    }
}
