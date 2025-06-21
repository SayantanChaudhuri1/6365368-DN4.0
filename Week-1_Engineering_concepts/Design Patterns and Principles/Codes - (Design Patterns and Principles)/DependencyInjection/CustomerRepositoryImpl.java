package DependencyInjection;

import java.util.HashMap;
import java.util.Map;

public class CustomerRepositoryImpl implements CustomerRepository {
    private Map<String, Customer> database = new HashMap<>();

    public CustomerRepositoryImpl() {
        database.put("101", new Customer("101", "Sayantan"));
        database.put("102", new Customer("102", "Ananth"));
    }

    @Override
    public Customer findCustomerById(String id) {
        return database.get(id);
    }
}
