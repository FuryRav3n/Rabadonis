using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class acs : MonoBehaviour
{
    public PostProcessVolume vol;
    // Start is called before the first frame update
    void Start()
    {
        //vol.profile.TryGetSettings<Bloom>(out var bloom);
        //bloom.intensity.Override(50f);
        //vol.profile.TryGetSettings<Vignette>(out var vignette);
    }

    // Update is called once per frame
    void Update()
    {
        TimeControl t = GameObject.FindWithTag("timebar").GetComponent<TimeControl>();
        float timeT = t.timeRemaining;
        float timeMax = t.timerMax;
        timeT -= Time.deltaTime;
        vol.profile.TryGetSettings<Vignette>(out var vignette);
        vignette.intensity.Override(timeT / timeMax);

    }
}
