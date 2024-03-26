using UnityEngine;

public class BulletImpact : MonoBehaviour
{
    public GameObject impactPrefab; // Префаб эффекта удара

    void OnCollisionEnter(Collision collision)
    {
        // Проверяем, столкнулась ли пуля с объектом, который поддерживает физику
        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            // Создаем эффект удара
            Instantiate(impactPrefab, transform.position, Quaternion.identity);

            // Отбрасываем объект, на который попала пуля
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Добавляем силу к объекту для эффекта отбрасывания
                rb.AddForceAtPosition(transform.forward * 500f, collision.contacts[0].point);
            }
        }

        // Уничтожаем пулю
        Destroy(gameObject);
    }
}
