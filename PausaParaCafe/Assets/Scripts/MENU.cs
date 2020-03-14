using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class MENU : MonoBehaviour
{

    public Button BotaoJogar, BotaoOpcoes, BotaoSair;
    [Space(20)]
    public Slider BarraVolume;

    public Dropdown Qualidades;
    public Button BotaoVoltar, BotaoSalvarPref;
    [Space(20)]
    public Text textoVol;
    public string nomeCenaJogo = "CENA1";
    private string nomeDaCena;
    private float VOLUME;
    private int qualidadeGrafica;





    void Start()
    {
        Opcoes(false);        
        AjustarQualidades();
        //
       
        //
        nomeDaCena = SceneManager.GetActiveScene().name;
        Cursor.visible = true;
        Time.timeScale = 1;
        //
        BarraVolume.minValue = 0;
        BarraVolume.maxValue = 1;

        //=============== SAVES===========//
        if (PlayerPrefs.HasKey("VOLUME"))
        {
            VOLUME = PlayerPrefs.GetFloat("VOLUME");
            BarraVolume.value = VOLUME;
            AudioListener.volume = VOLUME;
        }
        else
        {
            PlayerPrefs.SetFloat("VOLUME", 1);
            BarraVolume.value = 1;
        }
        //=============MODO JANELA===========//
       
        //=========QUALIDADES=========//
        if (PlayerPrefs.HasKey("qualidadeGrafica"))
        {
            qualidadeGrafica = PlayerPrefs.GetInt("qualidadeGrafica");
            QualitySettings.SetQualityLevel(qualidadeGrafica);
            Qualidades.value = qualidadeGrafica;
        }
        else
        {
            QualitySettings.SetQualityLevel((QualitySettings.names.Length - 1));
            qualidadeGrafica = (QualitySettings.names.Length - 1);
            PlayerPrefs.SetInt("qualidadeGrafica", qualidadeGrafica);
            Qualidades.value = qualidadeGrafica;
        }

        // =========SETAR BOTOES==========//
        BotaoJogar.onClick = new Button.ButtonClickedEvent();
        BotaoOpcoes.onClick = new Button.ButtonClickedEvent();
        BotaoSair.onClick = new Button.ButtonClickedEvent();
        BotaoVoltar.onClick = new Button.ButtonClickedEvent();
        BotaoSalvarPref.onClick = new Button.ButtonClickedEvent();
        BotaoJogar.onClick.AddListener(() => Jogar());
        BotaoOpcoes.onClick.AddListener(() => Opcoes(true));
        BotaoSair.onClick.AddListener(() => Sair());
        BotaoVoltar.onClick.AddListener(() => Opcoes(false));
        BotaoSalvarPref.onClick.AddListener(() => SalvarPreferencias());
    }
    //=========VOIDS DE CHECAGEM==========//

    private void AjustarQualidades()
    {
        string[] nomes = QualitySettings.names;
        Qualidades.options.Clear();
        for (int y = 0; y < nomes.Length; y++)
        {
            Qualidades.options.Add(new Dropdown.OptionData() { text = nomes[y] });
        }
        Qualidades.captionText.text = "Qualidade";
    }
    private void Opcoes(bool ativarOP)
    {
        BotaoJogar.gameObject.SetActive(!ativarOP);
        BotaoOpcoes.gameObject.SetActive(!ativarOP);
        BotaoSair.gameObject.SetActive(!ativarOP);
        //
        //textoVol.gameObject.SetActive(ativarOP);
        //BarraVolume.gameObject.SetActive(ativarOP);
        Qualidades.gameObject.SetActive(ativarOP);
        BotaoVoltar.gameObject.SetActive(ativarOP);
        BotaoSalvarPref.gameObject.SetActive(ativarOP);
    }
    //=========VOIDS DE SALVAMENTO==========//
    private void SalvarPreferencias()
    {

        PlayerPrefs.SetFloat("VOLUME", BarraVolume.value);
        PlayerPrefs.SetInt("qualidadeGrafica", Qualidades.value);


        AplicarPreferencias();
    }
    private void AplicarPreferencias()
    {
        VOLUME = PlayerPrefs.GetFloat("VOLUME");
        AudioListener.volume = VOLUME;
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("qualidadeGrafica"));
    }
    //===========VOIDS NORMAIS=========//
    void Update()
    {
        if (SceneManager.GetActiveScene().name != nomeDaCena)
        {
            AudioListener.volume = VOLUME;
            Destroy(gameObject);
        }
    }
    private void Jogar()
    {
        SceneManager.LoadScene(nomeCenaJogo);
    }
    private void Sair()
    {
        Application.Quit();
    }
}