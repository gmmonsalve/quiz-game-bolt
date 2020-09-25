using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using Bolt;
using Ludiq;

public class Quiz : MonoBehaviour
{
    // Start is called before the first frame update
   public  List<Question> preguntas = new List<Question>();
   string string_pregunta;
   int i = 0;
   
   
   
    void Start()
    {
         Debug.Log("Sí estoy aquí jaja");   
         setQuestions(); 
         //Debug.Log(preguntas[0]);
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setQuestions(){
         preguntas.Add(new Question("5+8=0",false));
         preguntas.Add(new Question("5+8=13",true));
         preguntas.Add(new Question("4+3=10",false));
         preguntas.Add(new Question("6+4=5",false));
         preguntas.Add(new Question("11+12=23",true));
         preguntas.Add(new Question("100+5=105",true));

    }

    public string getQuestion(){
         if(preguntas.Count == 0){
              string_pregunta = "Juego terminado!";  
              Variables.ActiveScene.Set("finish", true);
         }else{
          if(i>preguntas.Count-1){
               i=0;
               }else{
                    int randomNum = Random.Range(0, preguntas.Count);
                    Question pregunta = preguntas[randomNum];
                    string_pregunta = pregunta.getFact();
                    Variables.ActiveScene.Set("currentQuestionIsTrue", pregunta.getIsTrue());
                    preguntas.RemoveAt(randomNum);
         }

         }
         
          return string_pregunta;
           
   }

   

}
