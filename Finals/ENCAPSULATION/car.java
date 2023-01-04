package com.fredy.java;

public class car {
	
	private String make;
	private String model;
	private int year;
	
	car(String make,String model,int year){
		this.setMake(make);
		this.setModel(model);
		this.setYear(year);
		
	// is a method used to GET encapsulated variables
	}
	
	public String getMake() {
		return make;
	}
	
	public String getModel() {
		return model;
	}
	
	public int getYear() {
		return year;
	}
	
	// is a method used to SET encapsulated variables
	
	public void setMake(String make) {
		this.make = make;
	}
	
	public void setModel(String model) {
		this.model = model;
	}
	
	public void setYear(int year) {
		this.year = year;
	}
	

}
