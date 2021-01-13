import React from 'react'
import { useState , useEffect } from 'react';
import "./person.scss";
import Modal from 'react-modal';

function Person(){

    const [person, setPerson] = useState([]);
    const [modalIsOpen, setIsOpen] = useState(false);
    function openModal(){
        setIsOpen(true);
    }
    function closeModal(){
        setIsOpen(false);
      }
    useEffect(async () => {
        const person = await fetch("http://localhost:5000/Home/getallpersons")
            .then(Response => Response.json())
        setPerson([...person])
      },[]);

      function colorC(p){
          if(p.colorCode == "red"){
              return "red"
          }else if(p.colorCode == "orange"){
              return "orange"
          }else if(p.colorCode == "green"){
              return "green"
          }else if (p.isAlive == "true"){
              return "dead";
          }
      }

      function PersonModal(person){
          return(
            <Modal
            isOpen= {modalIsOpen}
          >
              <button onClick={()=>closeModal()}></button>
              {person.personName}          
          </Modal>
          )
      }

    return(
        <div className= 'mainContainer'>
            {person.map(bnadem => (
                <div className= {`${colorC(bnadem)} personContainer`} onClick= {() => openModal()}>
                    <h4>{bnadem.personName}</h4>
                    <p>{bnadem.cin}</p>
                    <p>{bnadem.age}</p>
                    {PersonModal(bnadem)}
                </div>
            ))}
        </div>
    )
}


export default Person