import './App.scss';
import person from './Components/person/person'

function App() {
  return (
    <div className="App">
      <div className="header">
        <img/>
      </div>
      <div className="gridContainer">
        {person()}
        {person()}
        {person()}
        {person()}
        {person()}
        {person()}
        {person()}

      </div>
    </div>
  );
}

export default App;
