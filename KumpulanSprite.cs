using UnityEngine;
using System.Collections.Generic;

public class KumpulanSprite : MonoBehaviour
{
    public List<Sprite> KoleksiGambar = new List<Sprite>();

    void Start()
    {
        // Contoh: Mengisi list dengan sprite dari Resources
        for (int i = 0; i < KoleksiGambar.Count; i++)
        {
            KoleksiGambar.Add(Resources.Load<Sprite>("path/to/your/sprite" + (i + 1)));
        }
    }

    // Contoh: Mengakses Sprite dari list berdasarkan indeks
    public void TampilkanSprite(int i)
    {
        if (i >= 0 && i < KoleksiGambar.Count)
        {
            // Lakukan sesuatu dengan sprite pada indeks ke-i
            Sprite sprite = KoleksiGambar[i];
            // Contoh: Menetapkan sprite ke komponen Image
            GetComponent<SpriteRenderer>().sprite = sprite;
        }
        else
        {
            Debug.LogError("Index sprite tidak valid.");
        }
    }
}