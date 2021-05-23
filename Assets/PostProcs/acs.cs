using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class acs : MonoBehaviour
{
    public PostProcessVolume vol;

    // Update is called once per frame
    void Update()
    {
        TimeControl t = GameObject.FindWithTag("timebar").GetComponent<TimeControl>();
        float timeT = t.timeRemaining;
        float timeMax = t.timerMax;
        timeT -= Time.deltaTime;
        vol.profile.TryGetSettings<Vignette>(out var vignette);
        vignette.intensity.Override(1 - (timeT / timeMax));

    }
}
