const listBooks = async () => {
const response = await fetch("https://localhost:44385/api/Books");
const books = await response.json();
let tablebody = '';
books.forEach(function(book) {
    tablebody += '<tr><td>'+book.id+'</td><td>'+book.titulo+'</td><td>'+book.nombreAutor+'</td></tr>';
});
document.getElementById('tabla_libros').innerHTML = tablebody;
};

setTimeout(function(){
    listBooks();
}, 500);

const AbrirModalAutores = document.getElementById('AbrirModalAutores');
    AbrirModalAutores.addEventListener('click', () => {
        listAuthors(); 
        document.getElementById("autorModal").style.display = "block"
    });






