using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasTransisi : MonoBehaviour
{
    public static string NamaScene;

    // Tambahkan variabel durasiAnimasi di sini
    public float durasiAnimasi = 1.0f;

    public void btn_pindah(string nama)
    {
        // Aktifkan objek sebelum memutar animasi
        this.gameObject.SetActive(true);

        NamaScene = nama;
        GetComponent<Animator>().Play("end");

        // Tunda pemanggilan Object_InActive selama durasi animasi
        Invoke("Object_InActive", durasiAnimasi);
    }

    public void Object_InActive()
    {
        this.gameObject.SetActive(false);
    }

    public void Pindah_Scene()
    {
        SceneManager.LoadScene(NamaScene);
    }

    public void btn_keluargame()
    {
        Application.Quit();
    }
}
