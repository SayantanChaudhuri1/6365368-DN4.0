package AdapterPattern;
public class PayPalGateway {
    public void sendMoney(double amount) {
        System.out.println("Payment of $" + amount + " sent using PayPal.");
    }
}
