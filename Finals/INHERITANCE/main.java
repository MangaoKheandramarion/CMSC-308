package inheritance;

public class main {

	public static void main(String[] args) {
		
	//Inheritance- is an OOP technique used to INHERIT attributes and methods from one class to another
			
		    person p = new person("Fred","Female",20);
			toddler t = new toddler("Khelvin Klein","Male",4,"Peek-a-boo");
			kid k = new kid ("Sam","Female",8,"Hide and Seek",5);
			
			p.checkStatus();
			t.checkStatus();
			k.checkStatus();
		}
	}
