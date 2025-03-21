using UnityEngine;
using System.Collections;

public class MusicParticleTrigger : MonoBehaviour
{
    public AudioSource musicSource;
    public ParticleSystem particleEffect;
    public float effectDuration = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            StartCoroutine(ActivateEffects());
        }
    }

    IEnumerator ActivateEffects()
    {
        if (musicSource != null)
        {
            musicSource.Play();
        }

        if (particleEffect != null)
        {
            particleEffect.Play();
        }

        yield return new WaitForSeconds(effectDuration);

        if (musicSource != null)
        {
            musicSource.Stop();
        }

        if (particleEffect != null)
        {
            particleEffect.Stop();
        }
    }
}
