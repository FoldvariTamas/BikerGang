import React, { useState, useEffect } from 'react';

export default function WelcomeMessage(){
    const [greeting, setGreeting] = useState('');

    useEffect(() => {
        fetch("https://localhost:7091/LandingPage", {
            method: 'GET',
            headers: {
              'Content-Type': 'application/json',
            }
          })
          .then(response => response.json())
          .then(data => setGreeting(data))
          .catch(error => console.error(error))
    }, []);


    return (
      <div>
        <h1>{greeting}</h1>
      </div>
    );  
}



  