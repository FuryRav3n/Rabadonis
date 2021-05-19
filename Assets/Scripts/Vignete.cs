using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class Vignete : MonoBehaviour
{
    PostProcessVolume m_Volume;
    Vignette m_Vignette;
    public PostProcessProfile profile;
    void Start()
    {
        // Create an instance of a vignette
        m_Vignette = ScriptableObject.CreateInstance<Vignette>();
        m_Vignette.enabled.Override(true);
        m_Vignette.intensity.Override(0.5f);
        m_Vignette.opacity.Override(0.5f);
        // Use the QuickVolume method to create a volume with a priority of 100, and assign the vignette to this volume
        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Vignette);

    }
        void Update()
        {
            // Change vignette intensity using a sinus curve
            m_Vignette.intensity.value = Mathf.Sin(Time.realtimeSinceStartup);
        }
        void OnDestroy()
        {
            RuntimeUtilities.DestroyVolume(m_Volume, true, true);
        }
}