using System.Collections;
using UnityEngine;

public class rino_0 : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    // A rhinÃ³ mozgÃ¡si sebessÃ©ge (egysÃ©g/mÃ¡sodperc)
    public float sebesseg = 5f;

    // Ennyi idÅ‘ mÃºlva Ã¡lljon meg a rhinÃ³ (mÃ¡sodpercben)
    public float megallasIdozito = 5f;

    // MeghatÃ¡rozza, hogy a rhinÃ³ Ã©ppen mozog-e
    private bool mozog = true;

    // Start egyszer fut le, mielÅ‘tt az elsÅ‘ Update meghÃ­vÃ³dik
    void Start()
    {
        // Itt most nincs speciÃ¡lis inicializÃ¡lÃ¡s
    }

    // Update minden frame-ben lefut
    void Update()
    {
        if (mozog)
        {
            // ElÅ‘re mozgatjuk az objektumot a beÃ¡llÃ­tott sebessÃ©ggel
            transform.position += Vector3.forward * sebesseg * Time.deltaTime;

            // Folyamatosan csÃ¶kkentjÃ¼k a megÃ¡llÃ¡si idÅ‘zÃ­tÅ‘t
            megallasIdozito -= Time.deltaTime;

            // Ha az idÅ‘zÃ­tÅ‘ lejÃ¡rt, megÃ¡llÃ­tjuk a mozgÃ¡st
            if (megallasIdozito <= 0f)
            {
                mozog = false;
            }
        }
>>>>>>> rino_0
    }
}
