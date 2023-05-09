import React, { useState, useEffect } from 'react';

export default function WelcomeMessage(){
    const [greeting, setGreeting] = useState('');
       
    
    useEffect(() => {
        fetch("https://localhost:7091/LandingPage")
        .then(response => response.text())
        .then(data => {
            setGreeting(data)
          })
    }, []);
    

    return (
      <div>
        <h1>{greeting}</h1>
      </div>
    );  
}



  