using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagescript : MonoBehaviour
{
    public void imageFlopBig()
    {
      transform.localScale += new Vector3 (1, 1, 1);
    }

    public void imageFlopLittle()
    {
        transform.localScale -= new Vector3(1, 1, 1);
    }









}
