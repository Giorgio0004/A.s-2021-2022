"use strict";
var arr = [];
let arr1 = [];
let quale_btn;
let controllo = false;
let realname;
let controllo1 = false;
let controllo_button = false;
let scielta;
let punti = 0;
//aggiungi il tipo
function avvia() {
    document.getElementById("quiz").innerHTML = "--Quiz--";
    if (controllo_button == false) {
        controllo_button = true;
        var via = Math.floor(Math.random() * 2);
        if (via == 0) {
            document.getElementById("sium").innerHTML = "  Chi e' ?";
            for (let i = 0; i < 4; i++) {
                Genera_gioco_nome(i);
            }
        }
        else {
            for (let i = 0; i < 4; i++) {
                Genera_gioco_mossa(i);
            }
        }
    }
    else {
        alert("Il quiz e' gia' attivo");
    }
}
function Genera_gioco_nome(i) {
    let ID;
    ID = (Math.floor(Math.random() * 199)) + 1;
    fetch('https://pokeapi.co/api/v2/pokemon/' + ID)
        .then(response => response.json())
        .then(data => {
        if (i == 0) {
            document.getElementById("immagine").src = data.sprites.front_shiny;
            arr[i] = data.name;
            realname = data.name;
        }
        else if (i != 3) {
            arr[i] = data.name;
        }
        else {
            arr[i] = data.name;
            controllo = true;
        }
        if (controllo == true) {
            controllo = false;
            Visualizza(arr.length);
        }
    });
}
function Visualizza(sium) {
    for (let i = 0; i < sium; i++) {
        let index = Math.floor(Math.random() * arr.length);
        switch (i) {
            case 0:
                document.getElementById("1").innerHTML = arr[index];
                arr.splice(index, 1);
                if (index == 0) {
                    quale_btn = 1;
                    controllo1 = true;
                }
                break;
            case 1:
                document.getElementById("2").innerHTML = arr[index];
                arr.splice(index, 1);
                if (index == 0 && controllo1 == false) {
                    quale_btn = 2;
                    controllo1 = true;
                }
                break;
            case 2:
                document.getElementById("3").innerHTML = arr[index];
                arr.splice(index, 1);
                if (index == 0 && controllo1 == false) {
                    quale_btn = 3;
                    controllo1 = true;
                }
                break;
            case 3:
                document.getElementById("4").innerHTML = arr[index];
                arr.splice(index, 1);
                if (index == 0 && controllo1 == false) {
                    quale_btn = 4;
                    controllo1 = true;
                }
                break;
        }
    }
    controllo1 = false;
    console.log("clicca il bottone " + quale_btn);
}
function Genera_gioco_mossa(i) {
    let ID;
    ID = (Math.floor(Math.random() * 199)) + 1;
    fetch('https://pokeapi.co/api/v2/pokemon/' + ID)
        .then(response => response.json())
        .then(data => {
        if (i == 0) {
            document.getElementById("immagine").src = data.sprites.back_shiny;
            arr1[i] = (data.abilities[0].ability.name);
            realname = data.name;
        }
        else if (i != 3) {
            arr1[i] = (data.abilities[0].ability.name);
        }
        else {
            arr1[i] = (data.abilities[0].ability.name);
            controllo = true;
        }
        if (controllo == true) {
            controllo = false;
            Visualizza1(arr1.length);
        }
    });
}
function Visualizza1(lenght) {
    document.getElementById("sium").innerHTML = "Che mossa ha " + realname + "?";
    for (let i = 0; i < lenght; i++) {
        let index = Math.floor(Math.random() * arr1.length);
        switch (i) {
            case 0:
                document.getElementById("1").innerHTML = arr1[index];
                arr1.splice(index, 1);
                if (index == 0) {
                    quale_btn = 1;
                    controllo1 = true;
                }
                break;
            case 1:
                document.getElementById("2").innerHTML = arr1[index];
                arr1.splice(index, 1);
                if (index == 0 && controllo1 == false) {
                    quale_btn = 2;
                    controllo1 = true;
                }
                break;
            case 2:
                document.getElementById("3").innerHTML = arr1[index];
                arr1.splice(index, 1);
                if (index == 0 && controllo1 == false) {
                    quale_btn = 3;
                    controllo1 = true;
                }
                break;
            case 3:
                document.getElementById("4").innerHTML = arr1[index];
                arr1.splice(index, 1);
                if (index == 0 && controllo1 == false) {
                    quale_btn = 4;
                    controllo1 = true;
                }
                break;
        }
    }
    controllo1 = false;
    console.log("clicca il bottone " + quale_btn);
}
function uno() {
    scielta = 1;
    Confronta_Ris();
}
function due() {
    scielta = 2;
    Confronta_Ris();
}
function tre() {
    scielta = 3;
    Confronta_Ris();
}
function quattro() {
    scielta = 4;
    Confronta_Ris();
}
function Confronta_Ris() {
    if (scielta == quale_btn) {
        controllo_button = false;
        punti++;
        document.getElementById("punti").innerHTML = "Punti: " + punti;
        avvia();
        arr = [];
        arr1 = [];
    }
    else {
        controllo_button = false;
        punti = 0;
        document.getElementById("punti").innerHTML = "Punti: " + punti;
        document.getElementById("1").innerHTML = "";
        document.getElementById("2").innerHTML = "";
        document.getElementById("3").innerHTML = "";
        document.getElementById("4").innerHTML = "";
        document.getElementById("sium").innerHTML = "";
        document.getElementById("quiz").innerHTML = "Riprova!!";
        //(<HTMLIFrameElement> document.getElementById("immagine")).src="C:\Users\Utente\Desktop\SCUOLA\Info\java-script\typescrisp\node_modules\.bin\bianco.png";
        arr = [];
        arr1 = [];
    }
}
//# sourceMappingURL=index.js.map