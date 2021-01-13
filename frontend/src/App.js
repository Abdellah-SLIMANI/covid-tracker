import './App.scss';
import Person from './Components/person/person'
import logo from "./logo.jpg"
import { useState, useEffect } from 'react';
import Modal from 'react-modal'

function App(props) {

  const [modalIsOpen, setIsOpen] = useState(false);

  useEffect(()=>{
    addPerson()
  },[]);

  function openModal(){
      setIsOpen(true);
  }
  function closeModal(){
      setIsOpen(false);
    }

    const customStyles = {
      content : {
        top                   : '50%',
        left                  : '50%',
        right                 : 'auto',
        bottom                : 'auto',
        marginRight           : '-50%',
        transform             : 'translate(-50%, -50%)'
      }
    };

    async function addPerson(event){
      try{
          let personData = await fetch("http://localhost:5000/Home/getallpersons",{
              method: 'POST',
              mode: "no-cors",
              headers: {
                'Content-Type': 'application/json',
              },
              body: JSON.stringify({
                personName: event.target.personName.value,
                age: event.target.age.value,
                cin:event.target.cin.value 
              })      
          });

      }catch(e){
          console.log("Post error:",e)
      }
  }

  const handleSubmit = (event) => {
    event.preventDefault()
    addPerson() 
  }




    function addPersonModal(){
      return(
        <Modal
        isOpen={modalIsOpen}
        onRequestClose={closeModal}
        style={customStyles}
        contentLabel="Example Modal"
      >
        <button onClick={closeModal}>close</button>
        <div>Add a Patient</div>
        <form onSubmit={handleSubmit}>
          Person Name : <input type= 'text' name= 'personName'/><br/>
          Age: <input type= 'text' name= 'age'/><br/>
          Cin: <input type= 'text' name= 'cin'/><br/>
          <button onClick= {addPerson()}>Add</button>
        </form>
      </Modal>
      )
    }

  return (
    <div className="App">
      <div className="header">
        <img src={logo}></img>
        <div>
          <ul>
            <li>
              Filter by
            </li>
            <li onClick ={()=>openModal()}>Add patients</li>
            {addPersonModal()}
          </ul>
        </div>
      </div>
      <div className="gridContainer">
        <Person/>
      </div>
    </div>
  );
}

export default App;
