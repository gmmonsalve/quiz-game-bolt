using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    // Start is called before the first frame update
   public ArrayList preguntas = new ArrayList();
   
   
    void Start()
    {
        
         preguntas.Add("Hola");
         preguntas.Add("soy");
         preguntas.Add("una prueba");
         Debug.Log("Sí estoy aquí jaja");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setQuestions(){
    }

    public string getQuestion(){
        
      string question = preguntas[0];
      return question;
   }
}
