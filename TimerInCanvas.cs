using UnityEngine;

public class TimerInCanvas : MonoBehaviour
{
    [HideInInspector] public float _time;

    private void Update()
    {
        _time = Time.fixedTime;
    }
}
