import React, { Component } from 'react';

class CurrencyConvertor extends Component {
  constructor(props) {
    super(props);
    this.state = {
      amount: '',
      currency: 'Euro'
    };
  }

  handleAmountChange = (e) => {
    this.setState({ amount: e.target.value });
  }

  handleCurrencyChange = (e) => {
    this.setState({ currency: e.target.value });
  }

  handleSubmit = (e) => {
    e.preventDefault();
    const { amount, currency } = this.state;

    const conversionRates = {
      Euro: 80
    };

    const result = amount * conversionRates[currency];
    alert(`Converting to ${currency} Amount is ${result}`);
  }

  render() {
    return (
      <div>
        <h2 style={{ color: "green" }}>Currency Convertor!!!</h2>
        <form onSubmit={this.handleSubmit}>
          <div>
            <label>Amount: </label>
            <input
              type="number"
              value={this.state.amount}
              onChange={this.handleAmountChange}
            />
          </div>
          <br />
          <div>
            <label>Currency: </label>
            <select value={this.state.currency} onChange={this.handleCurrencyChange}>
              <option value="Euro">Euro</option>
              {}
            </select>
          </div>
          <br />
          <button type="submit">Submit</button>
        </form>
      </div>
    );
  }
}

export default CurrencyConvertor;
