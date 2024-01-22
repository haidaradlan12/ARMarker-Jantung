using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuGTA, MenuGA, MenuButton, MenuInformasi, MenuPetunjuk;
    // Start is called before the first frame update
    void Start()
    {
        MenuGTA.DOAnchorPos(new Vector2(0,0), 1.0f);
        MenuGA.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        
        MenuInformasi.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 2500), 1.0f);
    }
    public void MenuKembalibutton()
    {
        MenuGTA.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGA.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);

        MenuInformasi.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 2500), 1.0f);
    }
    public void MenuInformasibutton()
    {
        MenuGTA.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuGA.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 2500), 1.0f);

        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 2500), 1.0f);
    }
    public void MenuPetunjukbutton()
    {
        MenuGTA.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuGA.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 2500), 1.0f);

        MenuInformasi.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }

}
