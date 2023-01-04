package inheritance;

public class toddler extends person{

 String favoriteGame;

	toddler(String name, String sex, int age, String favoriteGame){
		
		super(name,sex,age);
		this.favoriteGame = favoriteGame;
		
		}
	
	void drink() {
		System.out.println(name + " Drinking Milk");
	}
	
	void checkStatus() {
		super.checkStatus();
		System.out.println("Favorite Game : " + favoriteGame);
		
	}

}
