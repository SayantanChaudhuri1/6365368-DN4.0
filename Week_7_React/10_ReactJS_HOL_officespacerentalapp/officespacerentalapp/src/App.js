import React from 'react';

function App() {
  const offices = [
    {
      name: "DBS",
      rent: 50000,
      address: "Chennai",
      image: "https://cdn.pixabay.com/photo/2017/08/06/11/08/interior-2591364_960_720.jpg"
    },
    {
      name: "WeWork",
      rent: 65000,
      address: "Bangalore",
      image: "https://images.unsplash.com/photo-1524758631624-e2822e304c36?ixlib=rb-4.0.3&auto=format&fit=crop&w=960&q=80"
    }
  ];

  return (
    <div style={{ padding: '30px' }}>
      <h1 style={{ fontFamily: 'Arial', fontWeight: 'bold' }}>
        Office Space , at Affordable Range
      </h1>

      {offices.map((office, index) => (
        <div key={index} style={{ marginBottom: '40px' }}>
          <img src={office.image} alt="office" width="250" height="200" />

          <h2 style={{ marginTop: '20px' }}>Name: {office.name}</h2>

          <p style={{
            color: office.rent <= 60000 ? 'red' : 'green',
            fontWeight: 'bold'
          }}>
            Rent: Rs. {office.rent}
          </p>

          <p>Address: {office.address}</p>
        </div>
      ))}
    </div>
  );
}

export default App;
