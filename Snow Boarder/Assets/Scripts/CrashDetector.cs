using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1.0f;
    [SerializeField] ParticleSystem crashEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadSceneMethod", loadDelay);
        }
    }

    void ReloadSceneMethod()
    {
        Debug.Log("Broke my neck!!!!");
        SceneManager.LoadScene(0);
    }
}
