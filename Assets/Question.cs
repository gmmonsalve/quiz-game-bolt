﻿
public class Question {
	
	public string fact;
	public bool isTrue;

	public Question(string question, bool value)
  {
    fact = question;
	isTrue = value;
  }

	public string getFact(){
		return fact;
	}

	public bool getIsTrue(){
		return isTrue;
	}

}