var arr: any[]=[];
let arr1: string[]=[];
let quale_btn: number;
let controllo=false;
let realname: string;
let controllo1=false;
let controllo_button=false;
let scielta:number;
let punti=0;

//aggiungi il tipo
function avvia()
{
  (<HTMLInputElement> document.getElementById("quiz")).innerHTML ="--Quiz--";
  if(controllo_button==false)
  {
    controllo_button=true;
    var via=Math.floor(Math.random()*2);
    if(via==0)
    {
        
      (<HTMLInputElement> document.getElementById("sium")).innerHTML ="  Chi e' ?";
      for(let i=0;i<4;i++){Genera_gioco_nome(i);}
    }
    else
    {
      
      
      for(let i=0;i<4;i++){Genera_gioco_mossa(i);}  
    }
  }
  else
  {
    alert("Il quiz e' gia' attivo");
  }
  
    
}

function Genera_gioco_nome(i:number)
{
  let ID;
  
  
  ID=(Math.floor(Math.random()*199))+1;
  fetch('https://pokeapi.co/api/v2/pokemon/'+ID)
  .then(response => response.json())
  .then(data =>{ 
  if(i==0)
    {
      (<HTMLImageElement> document.getElementById("immagine")).src=data.sprites.front_shiny;
      arr[i]=data.name;
      realname=data.name;
    }
    else if(i!=3)
    {
      arr[i]=data.name;
    }
    else
    {
      arr[i]=data.name;
      controllo=true;
    }
    if(controllo==true)
    {
      controllo=false;
      Visualizza(arr.length);
        
    }
  });
}


function Visualizza(sium: number)
{
  for(let i=0;i<sium;i++)
  {
    
    let index:number=Math.floor(Math.random()*arr.length);

    switch(i)
    {
      case 0:(<HTMLInputElement> document.getElementById("1")).innerHTML =arr[index];arr.splice(index,1);if(index==0){quale_btn=1; controllo1=true;}
      break;
      case 1:(<HTMLInputElement> document.getElementById("2")).innerHTML =arr[index];arr.splice(index,1);if(index==0 && controllo1==false){quale_btn=2;controllo1=true;}
      break;
      case 2:(<HTMLInputElement> document.getElementById("3")).innerHTML =arr[index];arr.splice(index,1);if(index==0 && controllo1==false){quale_btn=3;controllo1=true;}
      break;
      case 3:(<HTMLInputElement> document.getElementById("4")).innerHTML =arr[index];arr.splice(index,1);if(index==0 && controllo1==false){quale_btn=4;controllo1=true;}
      break;
      
    }
    
    
    
  }
  controllo1=false;

  console.log("clicca il bottone "+quale_btn);
}

function Genera_gioco_mossa(i:number)
{
  let ID;
  ID=(Math.floor(Math.random()*199))+1;
    fetch('https://pokeapi.co/api/v2/pokemon/'+ID)
    .then(response => response.json())
    .then(data =>{ //console.log(data);
      if(i==0)
      {
        (<HTMLImageElement> document.getElementById("immagine")).src=data.sprites.back_shiny;
        arr1[i]=(data.abilities[0].ability.name);
        realname=data.name;
      }
      else if(i!=3)
      {
        arr1[i]=(data.abilities[0].ability.name);
      }
      else
      {
        arr1[i]=(data.abilities[0].ability.name);
        controllo=true;
      }
      if(controllo==true)
      {
        controllo=false;
        Visualizza1(arr1.length);
        
      }
      
     });
}
    


function Visualizza1(lenght: number)
{
  (<HTMLInputElement> document.getElementById("sium")).innerHTML ="Che mossa ha "+realname+"?";
  for(let i=0;i<lenght;i++)
  {
    
    let index:number=Math.floor(Math.random()*arr1.length);

    switch(i)
    {
      case 0:(<HTMLInputElement> document.getElementById("1")).innerHTML =arr1[index];arr1.splice(index,1);if(index==0){quale_btn=1; controllo1=true;}
      break;
      case 1:(<HTMLInputElement> document.getElementById("2")).innerHTML =arr1[index];arr1.splice(index,1);if(index==0 && controllo1==false){quale_btn=2;controllo1=true;}
      break;
      case 2:(<HTMLInputElement> document.getElementById("3")).innerHTML =arr1[index];arr1.splice(index,1);if(index==0 && controllo1==false){quale_btn=3;controllo1=true;}
      break;
      case 3:(<HTMLInputElement> document.getElementById("4")).innerHTML =arr1[index];arr1.splice(index,1);if(index==0 && controllo1==false){quale_btn=4;controllo1=true;}
      break;
      
    }
    
    
    
  }
  controllo1=false;
  console.log("clicca il bottone "+quale_btn);
}

function uno()
{
  scielta=1;
  Confronta_Ris()
}
function due()
{
  scielta=2;
  Confronta_Ris()
}
function tre()
{
  scielta=3;
  Confronta_Ris()
}
function quattro()
{
  scielta=4;
  Confronta_Ris()
}



function Confronta_Ris()
{
  if(scielta==quale_btn)
  {
    controllo_button=false;
    punti++;
    (<HTMLInputElement> document.getElementById("punti")).innerHTML ="Punti: "+punti;
    avvia();
    arr=[];
    arr1=[];
  }
  else
  {
    controllo_button=false;
    punti=0;
    (<HTMLInputElement> document.getElementById("punti")).innerHTML ="Punti: "+punti;
    (<HTMLInputElement> document.getElementById("1")).innerHTML="";
    (<HTMLInputElement> document.getElementById("2")).innerHTML="";
    (<HTMLInputElement> document.getElementById("3")).innerHTML="";
    (<HTMLInputElement> document.getElementById("4")).innerHTML="";
    (<HTMLInputElement> document.getElementById("sium")).innerHTML ="";
    (<HTMLInputElement> document.getElementById("quiz")).innerHTML ="Riprova!!";
    //(<HTMLIFrameElement> document.getElementById("immagine")).src="C:\Users\Utente\Desktop\SCUOLA\Info\java-script\typescrisp\node_modules\.bin\bianco.png";
    arr=[];
    arr1=[];
    
  }
} 