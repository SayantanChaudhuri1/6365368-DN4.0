package BuilderPattern;

public class Main {
    public static void main(String[] args) {
        Computer basicPC = new Computer.Builder("Intel i3", "8GB").build();
        System.out.println(" Basic PC ");
        basicPC.showSpecs();
        Computer gamingPC = new Computer.Builder("AMD Ryzen 7", "32GB").setStorage("1TB SSD").setGraphicsCard("NVIDIA RTX 3080").setOperatingSystem("Windows 11").build();

        System.out.println("\n Gaming PC ");
        gamingPC.showSpecs();
    }
}
