using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class Trigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject trigger;

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        Object.Destroy(trigger);
    }

   
}
