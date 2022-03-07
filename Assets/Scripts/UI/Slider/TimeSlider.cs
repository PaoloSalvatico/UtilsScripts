using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlider : MonoBehaviour
{
    public GameObject sliderSprite;
    public float maxTime;

    private void Start()
    {
        StartCoroutine(SliderTimer());
    }

    public IEnumerator SliderTimer()
    {
        sliderSprite.transform.localScale = new Vector3(0, 0.5f, 1f);
        float time = 0;
        int i = 0;
        float deltaTime = 0.1f;

        while(time < maxTime)
        {
            i++;
            time = i * deltaTime;
            float scale = time / maxTime;
            sliderSprite.transform.localScale = new Vector3(scale, 0.5f, 1f);
            yield return new WaitForSeconds(deltaTime);
        }
    }
}
