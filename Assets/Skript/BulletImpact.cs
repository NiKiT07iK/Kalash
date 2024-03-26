using UnityEngine;

public class BulletImpact : MonoBehaviour
{
    public GameObject impactPrefab; // ������ ������� �����

    void OnCollisionEnter(Collision collision)
    {
        // ���������, ����������� �� ���� � ��������, ������� ������������ ������
        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            // ������� ������ �����
            Instantiate(impactPrefab, transform.position, Quaternion.identity);

            // ����������� ������, �� ������� ������ ����
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // ��������� ���� � ������� ��� ������� ������������
                rb.AddForceAtPosition(transform.forward * 500f, collision.contacts[0].point);
            }
        }

        // ���������� ����
        Destroy(gameObject);
    }
}
