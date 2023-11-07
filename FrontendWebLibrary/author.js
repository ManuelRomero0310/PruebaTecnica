const sendDataToAPIAutor= async () => {
    var autorName = document.getElementById('autorNombre').value;
    if(autorName === ''){
        alert("Ingrese nombre del autor");
    }
    else{

    const data = {
        nombre: autorName
    };
  
    const requestOptions = {
      method: 'POST', 
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(data)
    };
  
    try {
      const response = await fetch('https://localhost:44385/api/Authors', requestOptions);
      
      if (response.ok) {
        alert('Datos enviados con éxito.');
        document.getElementById('autorNombre').value = "";
      } else {
        alert('Error al enviar datos a la API.');
      }
    } catch (error) {
      alert('Error de red:', error);
    }
    }
  };

  const enviarDatosBtnAutor = document.getElementById('GuardarAutor');
enviarDatosBtnAutor.addEventListener('click', () => {
    sendDataToAPIAutor(); 
});

const closedBtnAutores = document.getElementById('BtnAutorCerrar');
    closedBtnAutores.addEventListener('click', () => {
        listAuthors(); 
        document.getElementById("autorModal").style.display = "none"
    });