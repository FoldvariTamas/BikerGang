import React, { useState, useEffect } from 'react';

export default function Bike(){

    let trialBike = {};

    const [bikeData, setBikeData] = useState(trialBike);

    useEffect(() => {
        fetch("https://localhost:7091/Bike")
        .then(data => data.json())
        .then(info => {
            setBikeData(info)
        })
    }, []);

    // return (
    //     <div>
    //         <h1>Bike info</h1>
    //         <p>{bikeData.manufacturer}</p>
    //         <p>{bikeData.model}</p>
    //         <p>{bikeData.type}</p>
    //         <p>{bikeData.wheelSize}</p>
    //         <p>{bikeData.frameSize}</p>
    //         <p>{bikeData.state}</p>
    //         <p>{bikeData.insured}</p>
    //     </div>
    // );

    return (
        <div>
          <h1>Bike info</h1>
          {Object.keys(bikeData).map(key => (
            <p key={key}>{bikeData[key]}</p>
          ))}
        </div>
      );

}