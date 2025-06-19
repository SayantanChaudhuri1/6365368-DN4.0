package ObserverPattern;

public class Main {
    public static void main(String[] args) {
        StockMarket market = new StockMarket();

        Observer mobileApp = new MobileApp("StockMobile");
        Observer webApp = new WebApp("InvestNow");

        market.registerObserver(mobileApp);
        market.registerObserver(webApp);
        System.out.println("\nStock price update 1:");
        market.setStock("TATA", 1123.45);
        System.out.println("\nStock price update 2:");
        market.setStock("RELIANCE", 2745.10);
        System.out.println("\nWebApp unsubscribes:");
        market.removeObserver(webApp);
        System.out.println("\nStock price update 3:");
        market.setStock("INFY", 1588.75);
    }
}
