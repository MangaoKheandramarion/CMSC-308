package polymorphism;

public class main {

	public static void main(String[] args) {
		// POLYMORPHISM- it is an OOP technique that utilizes inheritance top create 1 class- 
		//and make several classes inherit from that class so that it can take many forms

		Animal a = new Dog();
		Animal b = new Cat();
		Animal c = new Bird();
		Animal d = new Pig();
		 
		a.makeSound();
		b.makeSound();
		c.makeSound();
		d.makeSound();
		
		}
		
	}

