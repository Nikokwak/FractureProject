using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class cameraBlackFadeCUstom : MonoBehaviour
{
    public float timeToFade;
    public Image fadeImage;
    public IEnumerator fade()
    {
        float time = timeToFade;
        while (time > 0)
        {
            time-=Time.deltaTime;
            Debug.Log(time/timeToFade);
            fadeImage.color = new Color(0f,0f,0f,1f-time/timeToFade);
            yield return new WaitForEndOfFrame();
        }

        yield return null;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(fade());
            Debug.Log("HERE");
        }
    }
}
