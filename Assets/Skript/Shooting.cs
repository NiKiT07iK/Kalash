using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint; // �������, ����� ���� ���������� ������
    public GameObject bulletPrefab; // ������ �������

    public AudioClip gunshotSound; // ���� ��������
    public AudioSource audioSource; // �������� �����

    // ��������� ����������� ����� ����
    void Update()
    {
        // ����������, �� ��������� ������ ������� (���������, ���� ������ ���� ��� �����)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(); // ��������� ������� �������
        }
    }

    void Shoot()
    {
        // ��������� ������ �� ������� firePoint
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // ������������� ���� ��������
        audioSource.PlayOneShot(gunshotSound);
    }
}

