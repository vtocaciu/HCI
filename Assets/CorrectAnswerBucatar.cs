using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucatarGameCorrectAnswer : MonoBehaviour
{
    public AudioSource audioSource;

    public void onCorrectAnswerClicked()
    {
        audioSource.Play();
    }
}
