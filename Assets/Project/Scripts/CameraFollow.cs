using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset = new Vector3(0f, 12f, -8f);

    private void LateUpdate()
    {
        if (player == null)
        {
            return;
        }
        Vector3 desiredPos = player.position + offset;
        transform.position = desiredPos;
    }
}
