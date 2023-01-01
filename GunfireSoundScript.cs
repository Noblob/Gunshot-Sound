using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunfireSoundScript : MonoBehaviour
{
    public float ClipLength = 1f;
    public GameObject AudioClip;

    // Start is called before the first frame update
    void Start()
    {
        AudioClip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(PlaySound());
        }

    }

    IEnumerator PlaySound()
    {
        AudioClip.SetActive(true);
        yield return new WaitForSeconds(ClipLength);
        AudioClip.SetActive(false);
    }
}
