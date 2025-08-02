import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: "Virat Kohli", score: 85 },
    { name: "Rohit Sharma", score: 65 },
    { name: "KL Rahul", score: 72 },
    { name: "Hardik Pandya", score: 55 },
    { name: "Ravindra Jadeja", score: 90 },
    { name: "Jasprit Bumrah", score: 45 },
    { name: "Shreyas Iyer", score: 76 },
    { name: "Rishabh Pant", score: 88 },
    { name: "Shubman Gill", score: 62 },
    { name: "Mohammed Shami", score: 50 },
    { name: "Axar Patel", score: 78 },
  ];

  const lowScorers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>List of Players</h2>
      <ul>
        {players.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>

      <h3>List of players having score less than 70</h3>
      <ul>
        {lowScorers.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
