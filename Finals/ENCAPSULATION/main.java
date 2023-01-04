package com.fredy.java;

public class main {

	public static void main(String[] args) {
	
	//Encapsulation - is an OOP technique used to hide data from direct access
	
	car car = new car("Mustang","Ford",2021);
	
	car.setYear(2024);
	car.setMake("Ranger SuperCab");
	
	System.out.println(car.getMake());
	System.out.println(car.getModel());
	System.out.println(car.getYear());
	
	}
}
 