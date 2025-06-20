using System.Collections;
using UnityEngine;

public class rino_0 : MonoBehaviour
{
<<<<<<< HEAD
    // Mozg�sir�ny: 1 = jobbra, 2 = balra
    int dir = 1;

    // Alap sebess�g
    const float speed_0 = 4.0f;

    // Jelenlegi sebess�g (�ll�that� meg�ll�shoz)
    float speed = 4.0f;

    // P�lya sz�lei (X koordin�t�k)
    float xmin = -9.0f;
    float xmax = 9.0f;

    // Anim�tor referencia
    Animator anim;

    // Inicializ�l�s - csak egyszer fut le az elej�n
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Minden k�pkock�ban lefut (kb. 60x m�sodpercenk�nt)
    void Update()
    {
        // Ha jobbra megy
        if (dir == 1)
        {
            // Mozg�s jobbra
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            // Anim�ci� �llapot 1 = jobbra megy
            anim.SetInteger("s", 1);

            // Ha el�rte a jobb oldali hat�rt, ir�nyt v�lt
            if (transform.position.x > xmax)
            {
                dir = 2;
            }
        }
        // Ha balra megy
        else if (dir == 2)
        {
            // Mozg�s balra
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            // Anim�ci� �llapot 2 = balra megy
            anim.SetInteger("s", 2);

            // Ha el�rte a bal oldali hat�rt, ir�nyt v�lt
            if (transform.position.x < xmin)
            {
                dir = 1;
            }
        }

        // V�letlenszer�en meg�ll id�nk�nt (1 a 10.000-b�l az es�ly k�pkock�nk�nt)
        if (Random.Range(0, 10000) == 1)
        {
            // Coroutine elind�t�sa meg�ll�sra, v�letlen ideig (1-5 sec)
            StartCoroutine(MegallasIdo(Random.Range(1f, 5f)));
        }
    }

    // Coroutine a meg�ll�shoz
    IEnumerator MegallasIdo(float t)
    {
        // Sebess�g null�ra, anim�ci� �ll�sra
        speed = 0;
        anim.SetInteger("s", 0); // 0 = �ll� anim�ci�

        // V�rakoz�s t m�sodpercig
        yield return new WaitForSeconds(t);

        // Vissza�ll�t�s alap sebess�gre
        speed = speed_0;
=======
    // A rhinó mozgási sebessége (egység/másodperc)
    public float sebesseg = 5f;

    // Ennyi idő múlva álljon meg a rhinó (másodpercben)
    public float megallasIdozito = 5f;

    // Meghatározza, hogy a rhinó éppen mozog-e
    private bool mozog = true;

    // Start egyszer fut le, mielőtt az első Update meghívódik
    void Start()
    {
        // Itt most nincs speciális inicializálás
    }

    // Update minden frame-ben lefut
    void Update()
    {
        if (mozog)
        {
            // Előre mozgatjuk az objektumot a beállított sebességgel
            transform.position += Vector3.forward * sebesseg * Time.deltaTime;

            // Folyamatosan csökkentjük a megállási időzítőt
            megallasIdozito -= Time.deltaTime;

            // Ha az időzítő lejárt, megállítjuk a mozgást
            if (megallasIdozito <= 0f)
            {
                mozog = false;
            }
        }
>>>>>>> rino_0
    }
}
