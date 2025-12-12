using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnstartClick()
    {
        //Aqui defines lo que pasa al hacer click
        Debug.Log("!Boton Start presionado!");

        //Ejemplo: cargar una escena llamada "GameScene"
        SceneManager.LoadScene(1);
    }

    public void QuitBtn() 
    {
        Application.Quit();

    }
        // funcion para que el boton de quit funcione al hacer click
    // Update is called once per frame
    void Update()
    {

    }
}
