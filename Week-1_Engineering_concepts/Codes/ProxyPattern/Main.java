package ProxyPattern;

public class Main {
    public static void main(String[] args) {
        Image image1 = new ProxyImage("nature1.jpg");
        Image image2 = new ProxyImage("nature2.jpg");

        System.out.println("\nFirst call to image1:");
        image1.display(); 
        System.out.println("\nSecond call to image1:");
        image1.display(); 
        System.out.println("\nFirst call to image2:");
        image2.display(); 
    }
}
