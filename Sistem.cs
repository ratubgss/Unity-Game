using UnityEngine;
using UnityEngine.UI;

public class Sistem : MonoBehaviour
{
    public static Sistem instance;

    public int ID;
    public GameObject TempatBuah;
    public GameObject[] KoleksiBuah;
    public AudioClip[] SuaraBuah;
    public AudioSource Suara;
    public GameObject TeksObjek;
    public GameObject[] KoleksiTeksArray;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ID = 0;
        SpawnObject();
        Suara = gameObject.AddComponent<AudioSource>();
    }

    public void SpawnObject()
    {
        GameObject BendaSebelumnya = GameObject.FindGameObjectWithTag("Buah");
        if (BendaSebelumnya != null) Destroy(BendaSebelumnya);

        GameObject Benda = Instantiate(KoleksiBuah[ID]);
        Benda.transform.SetParent(TempatBuah.transform, false);
        Benda.transform.localScale = new Vector3(37, 37, 37);

        TempatBuah.GetComponent<Animation>().Play("PopUp");

        KumpulanSuara.instance.Panggil_Suara(1);
    }
    public void TampilkanTeks()
    {
        GameObject BendaSebelumnya = GameObject.FindGameObjectWithTag("Desc");
        if (BendaSebelumnya != null) Destroy(BendaSebelumnya);

        GameObject Teks = Instantiate(KoleksiTeksArray[ID]);
        Teks.transform.SetParent(TeksObjek.transform, false);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GantiBuah(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GantiBuah(false);
        }
    }

    public void GantiBuah(bool Kanan)
    {
        if (Kanan)
        {
            if (ID >= KoleksiBuah.Length - 1)
            {
                ID = 0;
            }
            else
            {
                ID++;
            }
        }
        else
        {
            if (ID <= 0)
            {
                ID = KoleksiBuah.Length - 1;
            }
            else
            {
                ID--;
            }
        }

        SpawnObject();
        TampilkanTeks();
        PanggilSuaraBuah();
    }

    public void PanggilSuaraBuah()
    {
        Suara.clip = SuaraBuah[ID];
        Suara.Play();
    }
}
