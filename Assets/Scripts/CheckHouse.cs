using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class AssemblyPiece : MonoBehaviour
{
    public Transform targetTransform;
    public int stepIndex;
    public Material highlightMaterial;
    public Material defaultMaterial;

    public static int currentStep = 0;
    public static bool isDisassemblyMode = false;

    private AudioSource audioSource;
    private Rigidbody rb;
    private BoxCollider boxCollider;
    private MeshRenderer meshRenderer;
    private bool isSolved = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetTransform.position);

        // Highlight current step
        if ((stepIndex == currentStep && !isSolved && !isDisassemblyMode) ||
            (stepIndex == currentStep - 1 && isSolved && isDisassemblyMode))
        {
            meshRenderer.material = highlightMaterial;
        }
        else
        {
            meshRenderer.material = defaultMaterial;
        }

        // Assembly logic
        if (distance < 0.05f && !isSolved && stepIndex == currentStep && !isDisassemblyMode)
        {
            ForceRelease();
            SnapToTarget();
            LockPiece();
            audioSource.Play();
            isSolved = true;
            currentStep++;
        }

        // Disassembly logic
        if (distance < 0.05f && isSolved && stepIndex == currentStep - 1 && isDisassemblyMode)
        {
            UnlockPiece();
            targetTransform.gameObject.SetActive(true);
            isSolved = false;
            currentStep--;
        }
    }

    void ForceRelease()
    {
        GrabInteractable grab = transform.GetChild(0).GetComponent<GrabInteractable>();
        foreach (GrabInteractor interactor in grab.Interactors)
        {
            interactor.Unselect();
        }
    }

    void SnapToTarget()
    {
        transform.SetPositionAndRotation(targetTransform.position, targetTransform.rotation);
        targetTransform.gameObject.SetActive(false);
    }

    void LockPiece()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
        boxCollider.enabled = false;
    }

    void UnlockPiece()
    {
        rb.constraints = RigidbodyConstraints.None;
        boxCollider.enabled = true;
    }
}