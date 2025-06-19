package StrategyPattern;

public class Main {
    public static void main(String[] args) {
        PaymentContext context = new PaymentContext();
        context.setPaymentStrategy(new CreditCardPayment("1234-5678-9012-3456", "Sayantan Chaudhuri"));
        context.makePayment(500.00);
        context.setPaymentStrategy(new PayPalPayment("2206211@kiit.ac.in.com"));
        context.makePayment(350.00);
    }
}
