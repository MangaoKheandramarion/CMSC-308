package inheritance;

public class kid extends toddler{
	
	int gradelevel;
	
	kid(String name, String sex, int age,String favoriteGame,int gradeLevel){
		super(name,sex,age,favoriteGame);
		this.gradelevel = gradeLevel;
		
	}
 
	void saygradeLevel() {
		
		System.out.println("I am Grade " + gradelevel);
	}
}
