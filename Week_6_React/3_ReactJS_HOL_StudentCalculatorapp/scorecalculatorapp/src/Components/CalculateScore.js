import React from 'react';
import '../Stylesheets/mystyle.css';

function CalculateScore() {
  const name = "Sayantan Chaudhuri";
  const school = "KIIT";
  const total = 265;
  const goal = 300;
  const percentage = ((total / goal) * 100).toFixed(2);

  return (
    <div className="container">
      <h1>Student Details:</h1>
      <p><span className="label blue">Name:</span> <span className="value skyblue">{name}</span></p>
      <p><span className="label red">School:</span> <span className="value pink">{school}</span></p>
      <p><span className="label purple">Total:</span> <span className="value gray">{total}Marks</span></p>
      <p><span className="label green">Score:</span> <span className="value greenlight">{percentage}%</span></p>
    </div>
  );
}

export default CalculateScore;
