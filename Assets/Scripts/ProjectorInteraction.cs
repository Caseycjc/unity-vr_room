using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ProjectorInteraction : MonoBehaviour
{
    public XRBaseInteractable greenCube;
    public XRBaseInteractable redCube;
    public ParticleSystem projectorParticleSystem;

    private void OnEnable()
    {
        greenCube.selectEntered.AddListener(TurnOnProjector);
        redCube.selectEntered.AddListener(TurnOffProjector);
    }

    private void OnDisable()
    {
        greenCube.selectEntered.RemoveListener(TurnOnProjector);
        redCube.selectEntered.RemoveListener(TurnOffProjector);
    }

    public void TurnOnProjector(SelectEnterEventArgs args)
    {
        projectorParticleSystem.Play();
    }

    public void TurnOffProjector(SelectEnterEventArgs args)
    {
        projectorParticleSystem.Stop();
    }
}
