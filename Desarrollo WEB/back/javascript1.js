function firstcharacter(cadena){
    let longitud;
    let lista;
    longitud= cadena.length;
    for(let i=0; i<longitud; i++){
        lista[i]=cadena[i];
        console.log(lista[i]);
    }
    //console.log(cadena[1]);      
}

//Problem 2
let bubble;
bubble=[1,8,10,8,3]

function bubblesort(bubble){
    let longitud;
    let x;
    longitud=bubble.length;
    for(let i=0; i<longitud; i++){
        for(let j=0; j<(longitud -i-1);j++){
            if(bubble[j]>bubble[j+1]){
                x=bubble[j];
                bubble[j]=bubble[j+1];
                bubble[j+1]=x; 
        }
    }}
    //EL siguiente for imprime la cadena bubble ya acomodada
    for(let i=0; i<longitud;i++){
        console.log(bubble[i]);
    }}

    //Problem 4: Escribe una función que reciba una cadena de texto y regrese una nueva con la primer letra de cada palabra en mayúscula.
    let frase;
    frase="hola me llamo lucía.";

function mayusculas(frase){
    let separation= frase.split(" ");
    let longitud=separation.length;
    
    for (let i=0; i < longitud; i++) {
        separation[i] = separation[i].charAt(0).toUpperCase() + separation[i].slice(1);
    }
    let unir=separation.join(" ");
    console.log(unir);
}

    //Problem 6: Crea una función que cambie una cadena de texto a 'Hacker Speak'. Por ejemplo, para la cadena 'Javascript es divertido', su hacker speak es: 'J4v45c1pt 35 d1v3rt1d0'.
    let quote;
    quote="Javascript es divertido";
    function hackerspeak(quote){
        //separates the string into sone character strings.
        let separation= quote.split("");
        let longitud=separation.length;
        for(let i=0; i<longitud;i++){
            if(separation[i]=="a"){
                separation[i]="4";  
            }
            else if(separation[i]=="s"){
                separation[i]="5"; 
            }
            else if(separation[i]=="s"){
                separation[i]="5";
            }
            else if(separation[i]=="i"){
                separation[i]="1";
            }
            else if(separation[i]=="e"){
                separation[i]="3";
            }
            else if(separation[i]=="o"){
                separation[i]="0"; 
            }
            else {
                
            }}
        let unir=separation.join(" ");
        console.log(unir);
    }


let cadena;
 cadena='abacddbec'; //declares the cadena that will be analyzed
//firstcharacter(cadena);
// bubblesort(bubble);
mayusculas(frase);
hackerspeak(quote);


