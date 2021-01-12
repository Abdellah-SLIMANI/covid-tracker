import './App.scss';
import Person from './Components/person/person'
import logo from "./logo.jpg"

function App() {
  return (
    <div className="App">
      <div className="header">
        <img src={logo}></img>
      </div>
      <div className="gridContainer">
        <Person name= "Moahmmed"></Person>
      </div>
    </div>
  );
}

export default App;
