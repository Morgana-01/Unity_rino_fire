using System.Collections;
using UnityEngine;

public class rino_0 : MonoBehaviour
{
    // Mozgásirány: 1 = jobbra, 2 = balra
    int dir = 1;

    // Alap sebesség
    const float speed_0 = 4.0f;

    // Jelenlegi sebesség (állítható megálláshoz)
    float speed = 4.0f;

    // Pálya szélei (X koordináták)
    float xmin = -9.0f;
    float xmax = 9.0f;

    // Animátor referencia
    Animator anim;

    // Inicializálás - csak egyszer fut le az elején
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Minden képkockában lefut (kb. 60x másodpercenként)
    void Update()
    {
        // Ha jobbra megy
        if (dir == 1)
        {
            // Mozgás jobbra
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            // Animáció állapot 1 = jobbra megy
            anim.SetInteger("s", 1);

            // Ha elérte a jobb oldali határt, irányt vált
            if (transform.position.x > xmax)
            {
                dir = 2;
            }
        }
        // Ha balra megy
        else if (dir == 2)
        {
            // Mozgás balra
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            // Animáció állapot 2 = balra megy
            anim.SetInteger("s", 2);

            // Ha elérte a bal oldali határt, irányt vált
            if (transform.position.x < xmin)
            {
                dir = 1;
            }
        }

        // Véletlenszerûen megáll idõnként (1 a 10.000-bõl az esély képkockánként)
        if (Random.Range(0, 10000) == 1)
        {
            // Coroutine elindítása megállásra, véletlen ideig (1-5 sec)
            StartCoroutine(MegallasIdo(Random.Range(1f, 5f)));
        }
    }

    // Coroutine a megálláshoz
    IEnumerator MegallasIdo(float t)
    {
        // Sebesség nullára, animáció állásra
        speed = 0;
        anim.SetInteger("s", 0); // 0 = álló animáció

        // Várakozás t másodpercig
        yield return new WaitForSeconds(t);

        // Visszaállítás alap sebességre
        speed = speed_0;
    }
}
