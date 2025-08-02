import React from 'react';

const IndianPlayers = () => {
  const T20players = ["Virat", "Rohit", "Bumrah", "Hardik"];
  const RanjiTrophy = ["Pujara", "Rahane", "Saha", "Unadkat"];

  const allPlayers = [...T20players, ...RanjiTrophy];

  const oddTeam = allPlayers.filter((_, index) => index % 2 !== 0);
  const evenTeam = allPlayers.filter((_, index) => index % 2 === 0);

  return (
    <div>
      <h2>Indian Players</h2>
      <h3>Even Players</h3>
      <ul>
        {evenTeam.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h3>Odd Players</h3>
      <ul>
        {oddTeam.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h3>List of Indian Players Merged :</h3>
      <ul>
        {allPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;
