package InventoryManagementSystem;
public class Main {
    public static void main(String[] args) {
        InventoryManager manager = new InventoryManager();

        Product p1 = new Product("P001", "Laptop", 10, 50000);
        Product p2 = new Product("P002", "Keyboard", 50, 500);
        Product p3 = new Product("P003", "Mouse", 100, 300);

        manager.addProduct(p1);
        manager.addProduct(p2);
        manager.addProduct(p3);

        manager.displayInventory();

        manager.updateProduct("P001", 8, 48000);
        manager.deleteProduct("P002");

        System.out.println("\nAfter updates:");
        manager.displayInventory();
    }
}
