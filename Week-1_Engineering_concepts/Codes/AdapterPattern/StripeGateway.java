package AdapterPattern;
public class StripeGateway {
    public void makePayment(double value) {
        System.out.println("Payment of $" + value + " processed using Stripe.");
    }
}
