using System;
using System.Windows.Forms;
using Confluent.Kafka;

namespace KafkaProducerAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Please enter your message here:";
            button3.Text = "Send";
            button4.Text = "Cancel";
            this.Text = "Form - 1";

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;

            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                try
                {
                    var result = await producer.ProduceAsync("demo", new Message<Null, string> { Value = message });
                    MessageBox.Show("Message sent to Kafka successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // empty

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
