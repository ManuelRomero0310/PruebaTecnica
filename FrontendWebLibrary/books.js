const listAuthors = async () => {
    const respons = await fetch("https://localhost:44385/api/Authors");
    const authors = await respons.json();
    let Listbody = '';
    authors.forEach(function(author) {
        Listbody += '<option value="'+author.id+'">'+author.nombre+'</option>';
    });
    //
    document.getElementById('Listbody').innerHTML = Listbody;
    };

    const LisDatosBtnAutores = document.getElementById('LisDatosBtnAutores');
    LisDatosBtnAutores.addEventListener('click', () => {
        listAuthors(); 
        document.getElementById("LibroModal").style.display = "block"
    });

    const closedBtnLibros = document.getElementById('BtnLibroCerrar');
    closedBtnLibros.addEventListener('click', () => {
        listAuthors(); 
        document.getElementById("LibroModal").style.display = "none"
    });


const sendDataToAPILibro = async () => {

    var titulo = document.getElementById('nombreTitulo').value;
    var idAutor = document.getElementById('Listbody').value;

    if(titulo === ''){
        alert("Ingrese nombre del titulo del libro");
    }
    else{
    console.log(titulo,idAutor);
    const data = {
      titulo: titulo,
      idAutor: parseInt(idAutor)
    };
  
    const requestOptions = {
      method: 'POST', 
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(data)
    };
  
    try {
      const response = await fetch('https://localhost:44385/api/Books', requestOptions);
      
      if (response.ok) {
        alert('Datos enviados con éxito.');
        document.getElementById('nombreTitulo').value = "";
        document.getElementById('LibroError').value = ""
      } else {
        alert('Error al enviar datos a la API.');
      }
    } catch (error) {
      alertr('Error de red:', error);
    }
    }
  };

  const enviarDatosBtnLibro = document.getElementById('GuardarLibro');
enviarDatosBtnLibro.addEventListener('click', () => {
    sendDataToAPILibro(); 

    setTimeout(function(){
        listBooks();
    }, 500);
    
});