using UnityEngine;
using UnityEngine.Events;

public class viewCheckpoints : MonoBehaviour
{
    public FloatEvent saveCheckpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Checkpoint")
        {
            saveCheckpoint?.Invoke(other.transform.position.z);
        }
    }

}
