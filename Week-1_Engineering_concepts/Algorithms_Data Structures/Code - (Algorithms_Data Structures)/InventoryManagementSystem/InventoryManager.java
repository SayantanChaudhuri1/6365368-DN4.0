
package InventoryManagementSystem;
import java.util.HashMap;
import java.util.Map;


public class InventoryManager {
    private Map<String, Product> inventory;

    public InventoryManager() {
        inventory = new HashMap<>();
    }

    public void addProduct(Product product) {
        inventory.put(product.getProductId(), product);
        System.out.println("Product added successfully.");
    }

    // Update an existing product
    public void updateProduct(String productId, int newQty, double newPrice) {
        Product p = inventory.get(productId);
        if (p != null) {
            p.setQuantity(newQty);
            p.setPrice(newPrice);
            System.out.println("Product updated.");
        } else {
            System.out.println("Product not found.");
        }
    }

    public void deleteProduct(String productId) {
        if (inventory.containsKey(productId)) {
            inventory.remove(productId);
            System.out.println("Product removed.");
        } else {
            System.out.println("Product not found.");
        }
    }

    public void displayInventory() {
        if (inventory.isEmpty()) {
            System.out.println("Inventory is empty.");
        } else {
            for (Product p : inventory.values()) {
                System.out.println(p);
            }
        }
    }
}
