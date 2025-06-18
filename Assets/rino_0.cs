using UnityEngine;

public class rino_0 : MonoBehaviour
{
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
    }
}
