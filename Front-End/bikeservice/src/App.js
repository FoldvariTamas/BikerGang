import { Routes, Route } from 'react-router-dom';
import LandingPage from './LandingPage';
import Bike from './Components/Bike';
import './App.css';

function App() {
  return (
    <div>
      <Routes>
        <Route path="/" element={<LandingPage/>}/>
        <Route path="/bike" element={<Bike/>}/>
      </Routes>
    </div>
  );
}

export default App;
