using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] float m_time;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void SetScene(string set)
    {
        PlayOneShot();
        StartCoroutine(Set(set));
    }

    IEnumerator Set(string set)
    {

        yield return new WaitForSeconds(m_time);
        SceneManager.LoadScene(set);

    }
    public void PlayOneShot()
    {
        audioSource.PlayOneShot(audioSource.clip, 1f);
    }
}
