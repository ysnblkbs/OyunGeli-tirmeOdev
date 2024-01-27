using UnityEngine;

public class Movement : MonoBehaviour
{
    public float hiz = 10f; // Uçağın hareket hızı

    void Update()
    {
        HareketKontrol();
    }

    void HareketKontrol()
    {
        float yatay = Input.GetAxis("Horizontal"); // Sağa ve sola hareket için yatay giriş
        float dikey = Input.GetAxis("Vertical"); // İleri hareket için dikey giriş

        Vector3 hareket = new Vector3(yatay, 0, dikey);
        transform.Translate(hareket * hiz * Time.deltaTime);

        // Uçağın geri gitmesini engellemek için kontrol
        float yeniZ = Mathf.Clamp(transform.position.z, 0f, float.MaxValue);
        transform.position = new Vector3(transform.position.x, transform.position.y, yeniZ);
    }
}
