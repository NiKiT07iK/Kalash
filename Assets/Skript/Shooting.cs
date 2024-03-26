using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint; // Позиція, звідки буде починатися вистріл
    public GameObject bulletPrefab; // Префаб снаряду

    public AudioClip gunshotSound; // Звук выстрела
    public AudioSource audioSource; // Источник звука

    // Оновлення викликається кожен кадр
    void Update()
    {
        // Перевіряємо, чи натиснуто кнопку стрільби (наприклад, лівий клацок миші або пробіл)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(); // Викликаємо функцію стрільби
        }
    }

    void Shoot()
    {
        // Створюємо снаряд на позиції firePoint
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // Воспроизвести звук выстрела
        audioSource.PlayOneShot(gunshotSound);
    }
}

