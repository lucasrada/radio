using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radio : Simulator
{
    [SerializeField] KeyCode Tecla;
    [SerializeField] List<AudioClip> AudioClipList;
    [SerializeField] AudioSource AudioSource;
    [SerializeField] Creadores creadores;
    [SerializeField] private Text text;

    private void Awake()
    {
        Font homevideo;
        homevideo = (Font)Resources.GetBuiltinResource(typeof(Font), "HomeVideo.ttf");
        text.font = homevideo;
    }

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        AsignarCreador(creadores);
        text = GetComponent<Text>();
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
        text.text = "Nombre de la cancion";
        AudioSource.Play();
    }

    public override void AsignarCreador(Creadores creador)
    {
        CreadoresSimulator = creador;
    }
}
