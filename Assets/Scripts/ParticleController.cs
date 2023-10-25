using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem projectorParticles;

    public void StartParticles()
    {
        if (!projectorParticles.isPlaying)
        {
            projectorParticles.Play();
        }
    }

    public void StopParticles()
    {
        if (projectorParticles.isPlaying)
        {
            projectorParticles.Stop();
        }
    }
}
