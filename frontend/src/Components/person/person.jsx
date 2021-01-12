import React from 'react'
import { useState , useEffect } from 'react';
import "./person.scss"

function Person(props){

    const [person, setPerson] = useState(0);
    function getDivColor(colorCode){
        if(colorCode === "orange"){
            return "orange";
        }
    }

    useEffect(async () => {
        const person = await fetch("http://localhost:5000/Home/getallpersons")
        .then(Response => Response.json())
        console.log("data...",person);
      },[]);

    return(
        <div className = "personContainer">
             <div>{console.log("data...")}</div>
            <h1>{props.name}</h1>
            <h1>{props.cin}</h1>
            <h1>{props.colorCode}</h1>
        </div>
    )
}


export default Person