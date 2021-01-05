import './App.css';
import { connect } from 'react-redux'

function App() {
  return (
    <div className="App">
      <div className="header">
        <img/>
      </div>
      <div className="tableContainer">
        <table>
            <td>Hello</td>
        </table>
      </div>
    </div>
  );
}

export default connect()(App);
