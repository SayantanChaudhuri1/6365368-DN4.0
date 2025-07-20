using System;
using System.Threading.Tasks;
using Confluent.Kafka;

class Program
{
    public static async Task Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Kafka Producer started. Type messages and press Enter (type 'exit' to quit).");

        while (true)
        {
            Console.Write("> ");
            var message = Console.ReadLine();

            if (message == "exit")
                break;

            var result = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
            Console.WriteLine($"Sent: {message} to partition {result.Partition} at offset {result.Offset}");
        }

        Console.WriteLine("Producer closed.");
    }
}
