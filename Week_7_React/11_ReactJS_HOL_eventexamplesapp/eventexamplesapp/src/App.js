import React from 'react';
import CurrencyConvertor from './CurrencyConvertor';

class App extends React.Component {
  constructor() {
    super();
    this.state = {
      count: 1
    };

    this.increment = this.increment.bind(this);
    this.sayHello = this.sayHello.bind(this);
    this.incrementAll = this.incrementAll.bind(this);
    this.sayWelcome = this.sayWelcome.bind(this);
    this.handleClick = this.handleClick.bind(this);
  }

  increment() {
    this.setState({ count: this.state.count + 1 });
  }

  sayHello() {
    alert("Hello! Member.");
  }

  incrementAll() {
    this.increment();
    this.sayHello();
  }

  sayWelcome(message) {
    alert(message);
  }

  handleClick(e) {
    alert("I was clicked");
  }

  render() {
    return (
      <div style={{ padding: "20px" }}>
        <h3>{this.state.count}</h3>

        <button onClick={this.incrementAll}>Increment</button>
        <br /><br />
        <button onClick={() => this.setState({ count: this.state.count - 1 })}>Decrement</button>
        <br /><br />
        <button onClick={() => this.sayWelcome("Welcome!")}>Say welcome</button>
        <br /><br />
        <button onClick={this.handleClick}>Click on me</button>

        <br /><br /><br />

        <CurrencyConvertor />
      </div>
    );
  }
}

export default App;
