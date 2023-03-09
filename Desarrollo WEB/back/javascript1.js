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


let cadena;
 cadena='abacddbec'; //declares the cadena that will be analyzed
//firstcharacter(cadena);
bubblesort(bubble);

