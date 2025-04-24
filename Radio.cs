using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Radio : Simulator
{
    [SerializeField] KeyCode Tecla;
    [SerializeField] List<AudioClip> AudioClipList;
    [SerializeField] AudioSource AudioSource;
    [SerializeField] Creadores creadores;

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        AsignarCreador(creadores);
    }

    private void Update()
    {
        if (Input.GetKeyDown(Tecla))
        {
            Cambiar();
        }
    }

    public void Cambiar()
    {
        AudioSource.clip = AudioClipList[0];
        Escuchar();
    }

    private void Escuchar()
    {
        AudioSource.Play();
    }

    public override void AsignarCreador(Creadores creador)
    {
        CreadoresSimulator = creador;
    }
}
