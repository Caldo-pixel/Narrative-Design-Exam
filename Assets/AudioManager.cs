using UnityEngine;
using Yarn.Unity;

public class AudioManager : MonoBehaviour
{

    public AudioSource regularDialogue;
    public AudioSource angryDialogue;
    public AudioSource music;

    public GameObject bgArt1;
    public GameObject bgArt2;
    public GameObject bgArt3;
    public GameObject bgArt4;
    public GameObject bgArt5;
    public GameObject bgArt6;
    public GameObject bgArt7;
    public GameObject bgArt8;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bgArt1.SetActive(true);
        bgArt2.SetActive(false);
        bgArt3.SetActive(false);
        bgArt4.SetActive(false);
        bgArt5.SetActive(false);
        bgArt6.SetActive(false);
        bgArt7.SetActive(false);
        bgArt8.SetActive(false);

        music.loop = true;
        music.volume = 0.1f;
        music.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*[YarnCommand("music_stop")]
    public void musicStop()
    {
        music.Stop();
    }*/

    [YarnCommand("reg_dialogue_start")]
    public void regDialogueStart()
    {
        regularDialogue.loop = true;
        regularDialogue.Play();
    }

    [YarnCommand("reg_dialogue_end")]
    public void regDialogueStop()
    {
        regularDialogue.Stop();
    }

    [YarnCommand("angry_dialogue_start")]
    public void angryDialogueStart()
    {
        angryDialogue.loop = true;
        angryDialogue.Play();
    }

    [YarnCommand("angry_dialogue_end")]
    public void angryDialogueStop()
    {
        angryDialogue.Stop();
    }


    [YarnCommand("rec2")]
    public void rec2()
    {
        bgArt1.SetActive(false);
        bgArt2.SetActive(true);
    }

    [YarnCommand("meet1")]
    public void meet1()
    {
        bgArt1.SetActive(false);
        bgArt3.SetActive(true);
    }

    [YarnCommand("meet2")]
    public void meet2()
    {
        bgArt3.SetActive(false);
        bgArt4.SetActive(true);
    }

    [YarnCommand("main1")]
    public void main1()
    {
        bgArt2.SetActive(false);
        bgArt4.SetActive(false);
        bgArt5.SetActive(true);
    }

    [YarnCommand("main2")]
    public void main2()
    {
        bgArt5.SetActive(false);
        bgArt7.SetActive(false);
        bgArt6.SetActive(true);
    }

    [YarnCommand("main3")]
    public void main3()
    {
        bgArt5.SetActive(false);
        bgArt6.SetActive(false);
        bgArt7.SetActive(true);
    }

    [YarnCommand("main4")]
    public void main4()
    {
        bgArt5.SetActive(false);
        bgArt6.SetActive(false);
        bgArt7.SetActive(false);
        bgArt8.SetActive(true);
    }
}
