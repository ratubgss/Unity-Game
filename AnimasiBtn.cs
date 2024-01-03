using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiBtn : MonoBehaviour
{
    public void _Animasi()
    {
        GetComponent<Animation>().Play("button");
        KumpulanSuara.instance.Panggil_Suara(0);
    }
}
