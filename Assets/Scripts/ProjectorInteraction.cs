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
    [ContextMenu("Activate Particles")]
    public void EnableProjector()
    {
        projectorParticleSystem.gameObject.SetActive(true);
        projectorParticleSystem.Play();
        Debug.Log("Green Cube Selected!");
    }
    public void TurnOnProjector(SelectEnterEventArgs args)
    {
        projectorParticleSystem.gameObject.SetActive(true);
        projectorParticleSystem.Play();
        Debug.Log("Green Cube Selected!");
    }

    public void TurnOffProjector(SelectEnterEventArgs args)
    {
        projectorParticleSystem.Stop();
    }
}
