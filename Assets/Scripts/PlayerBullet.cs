using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 25f;
    [SerializeField] private float timeDestroy = 0.5f;

    private void Start()
    {
        // Hủy viên đạn sau thời gian quy định
        Destroy(gameObject, timeDestroy);
    }

    private void Update()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        // Di chuyển viên đạn theo hướng hiện tại của nó
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime, Space.Self);
    }
}