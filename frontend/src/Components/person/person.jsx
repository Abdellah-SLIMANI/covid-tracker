import React from 'react'
import { useState , useEffect } from 'react';
import "./person.scss"

function Person(props){

    const [person, setPerson] = useState([]);
    function getDivColor(colorCode){
        if(colorCode === "orange"){
            return "orange";
        }
    }

    useEffect(async () => {
        const person = await fetch("http://localhost:5000/Home/getallpersons")
            .then(Response => Response.json())
        console.log("data...",person);

        setPerson([...person])
      },[]);

    return(
        <div className= 'mainContainer'>
            {person.map(bnadem => (
                <div className='personContainer'>
                    <h4>{bnadem.personName}</h4>
                    <p>{bnadem.cin}</p>
                    <p>{bnadem.age}</p>
                </div>
            ))}
        </div>
    )
}


export default Person